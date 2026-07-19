using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Group20_Project
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";
        SqlDataAdapter? adap;

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSellMaterial_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!cbxConfirm.Checked)
            {
                errorProvider1.SetError(cbxConfirm, "Please confirm before selling any materials");
                return;
            }

            float Quantity;
            if (float.TryParse(txtQuantity.Text, out Quantity))
            {
                if (Quantity < 0 || Quantity == 0)
                {
                    errorProvider1.SetError(txtQuantity, "Quantity cannot be less than or equal to zero. Please re-enter your quantity");
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(txtQuantity, "Please enter a numerical value as your quantity ");
                return;
            }

            
            PopulateSaleOrder();
            UpdateMaterialStock(Convert.ToInt32(cbxMaterialName.SelectedValue), float.Parse(txtQuantity.Text));
            PopulateSaleOrderGrid(dgvSalesOrder);
            Clear();

        }

        private decimal GetSellingPrice(int materialTypeid)
        {
            decimal sellingPrice = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Selling_Price FROM MATERIAL_TYPE WHERE MaterialType_ID = @MaterialType_ID";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaterialType_ID", materialTypeid);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            sellingPrice = Convert.ToDecimal(result);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading selling price " + ex.Message);
            }
            return sellingPrice;
        }
        private void PopulateSaleOrder()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string query = "INSERT INTO SALES_ORDER (Customer_ID, MaterialType_ID, Date_of_Sale , Quantity_Sold ) VALUES(@Customer_ID, @MaterialType_ID, @Date_of_sale, @Quantity_Sold)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Customer_ID", cbxCustomerID.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaterialType_ID", cbxMaterialName.SelectedValue);
                    cmd.Parameters.AddWithValue("@Date_of_sale", dtpDateSold.Value);
                    cmd.Parameters.AddWithValue("@Quantity_Sold", float.Parse(txtQuantity.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale successfully added.");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error adding sale" + e.Message);
            }
        }

        private void PopulateSaleOrderGrid(DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM SALES_ORDER";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;  // Only selected customer appears
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Sale: " + ex.Message);
            }
        }

        private void Clear()
        {
            cbxCustomerID.SelectedIndex = -1;
            cbxMaterialName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtAmountDue.Clear();
            txtCustomerEmail.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            dtpDateSold.Value = DateTime.Now;

            cbxConfirm.Checked = false;

            cbxCustomerID.Focus();
        }

        private void UpdateMaterialStock(int materialTypeId, float quantitySold)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = @"UPDATE MATERIAL_TYPE SET Quantity_OnHand = Quantity_OnHand - @quantitySold WHERE MaterialType_ID = @MaterialType_ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@quantitySold", quantitySold);
                cmd.Parameters.AddWithValue("@MaterialType_ID", materialTypeId);
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Warning: No material stock was updated. Check if the MaterialType_ID exists.");
                }
            }
        }

        private void LoadCustomerData(int customerID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM CUSTOMERS WHERE Customer_ID = @CustomersID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@CustomersID", customerID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        txtCustomerName.Text = reader["Customer_Name"].ToString();
                        txtCustomerPhone.Text = reader["Customer_Phone"].ToString();
                        txtCustomerEmail.Text = reader["Customer_Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer details: " + ex.Message);
            }
        }

        private void LoadCustomersIDs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Customer_ID FROM CUSTOMERS";
                    adap = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();

                    adap.Fill(ds, "CUSTOMERS");

                    cbxCustomerID.DataSource = ds.Tables["CUSTOMERS"];
                    cbxCustomerID.DisplayMember = "Customer_ID";
                    cbxCustomerID.ValueMember = "Customer_ID";
                    cbxCustomerID.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying the custmomer id " + ex.Message);
            }
        }
        private void cbxCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCustomerID.SelectedIndex == -1 || cbxCustomerID.SelectedValue == null)
                return;
            int id;
            if (int.TryParse(cbxCustomerID.SelectedValue?.ToString(), out id))
            {
                LoadCustomerData(id);
            }
        }

        private void PopulateMaterialComboBoxes(ComboBox cbx)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT MaterialType_ID, Material_Name FROM MATERIAL_TYPE";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbx.DataSource = dt;
                    cbx.DisplayMember = "Material_Name";
                    cbx.ValueMember = "MaterialType_ID";
                    cbx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating combo boxes: " + ex.Message);
            }
        }

        private void PopulateCustomerCombo(ComboBox cbx)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Customer_ID FROM CUSTOMERS";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbx.DataSource = dt;
                    cbx.DisplayMember = "Customer_ID";
                    cbx.ValueMember = "Customer_ID";
                    cbx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to populate the customer combo box: " + ex.Message);
            }
        }

        private void frmSale_Load_1(object sender, EventArgs e)
        {
            PopulateMaterialComboBoxes(cbxMaterialName);
            PopulateCustomerCombo(cbxCustomerID);


        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void cbxMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            if (cbxMaterialName.SelectedValue == null)
            {
                txtAmountDue.Text = ""; // Clear if no material selected
                return;
            }

            if (decimal.TryParse(txtQuantity.Text, out decimal quantity) && quantity > 0)
            {
                int materialTypeId = Convert.ToInt32(cbxMaterialName.SelectedValue);
                decimal sellingPrice = GetSellingPrice(materialTypeId);
                decimal total = sellingPrice * quantity;
                txtAmountDue.Text = total.ToString("C2");
            }
            else
            {
                txtAmountDue.Text = ""; // Clear if invalid quantity
            }
        }

        private void dtpDateSold_ValueChanged(object sender, EventArgs e)
        {
            //validate date during runtime
            if (dtpDateSold.CustomFormat == "")
            {
                errorProvider1.SetError(dtpDateSold, "Please select a date");
                return;
            }

            if (dtpDateSold.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtpDateSold, "You cannot select a past date");
                return;
            }
        }
    }
}
