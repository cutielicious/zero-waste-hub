using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group20_Project
{
    public partial class frmBuy : Form
    {
        public frmBuy()
        {
            InitializeComponent();
        }

        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //go to home page
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }

        private void PopulateSuppliersCombo(ComboBox cbx)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Supplier_ID FROM SUPPLIERS";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbx.DataSource = dt;
                    cbx.DisplayMember = "Supplier_ID";
                    cbx.ValueMember = "Supplier_ID";
                    cbx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to populate the supplier combo box: " + ex.Message);
            }
        }

        private void LoadSupplierData(int supplierID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM SUPPLIERS WHERE Supplier_ID = @Supplier_ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Supplier_ID", supplierID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        txtSupplBuyName.Text = reader["Supplier_FName"].ToString();
                        txtSupplBuyPhone.Text = reader["Supplier_Phone"].ToString();
                        txtSupplBuyEmail.Text = reader["Supplier_Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier details: " + ex.Message);
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

        private decimal GetBuyingPrice(int materialTypeid)
        {
            decimal buyingPrice = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Price_per_kg FROM MATERIAL_TYPE WHERE MaterialType_ID = @MaterialType_ID";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaterialType_ID", materialTypeid);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            buyingPrice = Convert.ToDecimal(result);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading selling price " + ex.Message);
            }
            return buyingPrice;
        }

        private void calculate()
        {
            if (cbxMaterialName.SelectedValue == null)
            {
                txtTotalPrice.Text = ""; // Clear if no material selected
                return;
            }

            if (decimal.TryParse(txtQuantity.Text, out decimal quantity) && quantity > 0)
            {
                int materialTypeId = Convert.ToInt32(cbxMaterialName.SelectedValue);
                decimal sellingPrice = GetBuyingPrice(materialTypeId);
                decimal total = sellingPrice * quantity;
                txtTotalPrice.Text = total.ToString("C2");
            }
            else
            {
                txtTotalPrice.Text = ""; // Clear if invalid quantity
            }
        }

        private void Clear()
        {
            cbxSupplBuyID.SelectedIndex = -1;
            cbxMaterialName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            txtSupplBuyEmail.Clear();
            txtSupplBuyName.Clear();
            txtSupplBuyPhone.Clear();
            dtpBuyDate.Value = DateTime.Now;

            cbxSupplBuyID.Focus();
        }

        private void ClearForCart()
        {
            cbxMaterialName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            dtpBuyDate.Value = DateTime.Now;
            cbxMaterialName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add items to cart
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider1.SetError(txtQuantity, "Please enter quantity");
                return;
            }

            if (float.TryParse(txtQuantity.Text, out float quantity))
            {
                if (quantity < 0)
                {
                    errorProvider1.SetError(txtQuantity, "Quantity cannot be negative");
                    return;//don't go further
                }
            }

            //retrieve material ID
            int selectedMaterialID = Convert.ToInt32(cbxMaterialName.SelectedValue);

            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    // First check if this material already exists in the TempCart for this supplier
                    string checkQuery = @"SELECT COUNT(*) FROM TempCart WHERE Supplier_ID = @SupplierID AND MaterialType_ID = @MaterialType_ID";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SupplierID", cbxSupplBuyID.SelectedValue);
                        checkCmd.Parameters.AddWithValue("@MaterialType_ID", selectedMaterialID);

                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            // Update the existing record (add the new weight to old one)
                            string updateQuery = @"UPDATE TempCart  SET Weight_in_Kg = Weight_in_Kg + @WeightReceived  WHERE Supplier_ID = @SupplierID AND MaterialType_ID = @MaterialType_ID";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@WeightReceived", float.Parse(txtQuantity.Text));
                                updateCmd.Parameters.AddWithValue("@SupplierID", cbxSupplBuyID.SelectedValue);
                                updateCmd.Parameters.AddWithValue("@MaterialType_ID", selectedMaterialID);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert new record
                            string insertQuery = @"INSERT INTO TempCart (Supplier_ID, MaterialType_ID, Weight_in_Kg) VALUES(@SupplierID, @MaterialType_ID, @Weight)";

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@SupplierID", cbxSupplBuyID.SelectedValue);
                                insertCmd.Parameters.AddWithValue("@MaterialType_ID", selectedMaterialID);
                                insertCmd.Parameters.AddWithValue("@Weight", float.Parse(txtQuantity.Text));

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Item added to cart");
                DisplayCartItems(dbViewBuy, cbxSupplBuyID);
                ClearForCart();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An SQL error occurred: " + ex.Message);
            }
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            PopulateSuppliersCombo(cbxSupplBuyID);
            PopulateMaterialComboBoxes(cbxMaterialName);
        }

        private void cbxSupplBuyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //autofill contents
            if (cbxSupplBuyID.SelectedIndex == -1 || cbxSupplBuyID.SelectedValue == null)
                return;
            int id;
            if (int.TryParse(cbxSupplBuyID.SelectedValue?.ToString(), out id))
            {
                LoadSupplierData(id);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if(!cbxConfirm.Checked)
            {
                cbxConfirm.Focus();
                errorProvider1.SetError(cbxConfirm, "Please confirm whether you want to purchase before going ahead");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "INSERT INTO PURCHASE_HEADER (Supplier_ID, Purch_Date) VALUES (@SupplierID,@PurchDate); SELECT SCOPE_IDENTITY()";
                    int purchaseID;

                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.AddWithValue("@SupplierID", cbxSupplBuyID.SelectedValue);
                        com.Parameters.AddWithValue("@PurchDate", dtpBuyDate.Value);
                        purchaseID = Convert.ToInt32(com.ExecuteScalar());

                        List<CartItems> tempCart = new List<CartItems>();

                        new CartItems
                        {
                            MaterialType_ID = Convert.ToInt32(cbxMaterialName.SelectedValue),
                            Weight_in_Kg = float.Parse(txtQuantity.Text)
                        };

                        foreach (var item in tempCart)
                        {
                            string purch = "INSERT INTO PURCHASE_DETAIL (Purchase_ID, MaterialType_ID, Weight_in_Kg) VALUES (@Purchase_ID, @MaterialType_ID, @Weight_in_Kg)";

                            using (SqlCommand cmm = new SqlCommand(purch, con))
                            {
                                cmm.Parameters.AddWithValue("@Purchase_ID", purchaseID);
                                cmm.Parameters.AddWithValue("@MaterialType_ID", item.MaterialType_ID);
                                cmm.Parameters.AddWithValue("@Weight_in_Kg", item.Weight_in_Kg);

                                cmm.ExecuteNonQuery();
                            }
                        }

                        string emptyCart = "DELETE FROM TempCart WHERE Supplier_ID = @SupplierID";
                        SqlCommand cmd = new SqlCommand(emptyCart, con);

                        cmd.Parameters.AddWithValue("@SupplierID",cbxSupplBuyID.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to add a new purchase header: " + ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //validate date chosen
            if (dtpBuyDate.CustomFormat == "")
            {
                errorProvider1.SetError(dtpBuyDate, "Please select a date");
                return;
            }

            if (dtpBuyDate.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtpBuyDate, "You cannot select a past date");
                return;
            }
        }

        private void cbxMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void DisplayCartItems(DataGridView dgv, ComboBox cmb)//here it is
        {
            try
            {
                if (cmb.SelectedValue == null)
                {
                    dgv.DataSource = null;
                    return;
                }

                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT c.Cart_ID, m.MaterialType_ID, c.Weight_in_kg FROM TempCart c INNER JOIN  MATERIAL_TYPE m ON c.MaterialType_ID = m.MaterialType_ID WHERE c.Supplier_ID = @SupplierID ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@SupplierID", cmb.SelectedValue);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    dgv.DataSource = dt;

                    dgv.Columns["Cart_ID"].Visible = false;
                    dgv.Columns["MaterialType_ID"].HeaderText = "MaterialType_ID";
                    dgv.Columns["Weight_in_kg"].HeaderText = "Weight";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to display current cart items: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dbViewBuy.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(dbViewBuy,"Please select an item to remove.");
                return;
            }

            DataGridViewRow row = dbViewBuy.SelectedRows[0];
            object cartObj = row.Cells["Cart_ID"].Value;

            if(cartObj == null )
            {
                MessageBox.Show("No valid ID found in the selected row.");
                return;
            }

            int cartId = Convert.ToInt32(cartObj);

            DialogResult result = MessageBox.Show("Are you sure you want to remove this item from cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM TempCart WHERE Cart_ID = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", cartId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("You have successfully removed from your cart.");
                    DisplayCartItems(dbViewBuy, cbxSupplBuyID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while trying to delete item from cart " + ex.Message);
                }
            }
        }
    }
}
