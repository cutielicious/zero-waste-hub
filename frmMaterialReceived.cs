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
    public partial class frmMaterialReceived : Form
    {
        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";
        public frmMaterialReceived()
        {
            InitializeComponent();
        }

        public void GoHome()
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void frmMaterialReceived_Load(object sender, EventArgs e)
        {
            PopulateMaterialComboBoxes(cbxMaterialName);
            PopulateSupplierCombo(cmbSupplierID);
        }

        private void LoadSuppliersDetails(int supplierID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM SUPPLIERS WHERE Supplier_ID = @SupplierID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        txtSupplierFName.Text = reader["Supplier_FName"].ToString();
                        txtSupplierLName.Text = reader["Supplier_LName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier details: " + ex.Message);
            }
        }

        private void cmbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierID.SelectedIndex < 0 || cmbSupplierID.SelectedValue == null)
                return;

            int id;
            if (int.TryParse(cmbSupplierID.SelectedValue?.ToString(), out id))
            {
                LoadSuppliersDetails(id);
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

        private void PopulateSupplierCombo(ComboBox comboBox)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT Supplier_ID FROM SUPPLIERS";
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader reader = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "Supplier_ID";
                    comboBox.ValueMember = "Supplier_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to populate the supplier combo box: " + ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!cbxConfirm.Checked)
            {
                errorProvider1.SetError(cbxConfirm, "Please confirm before receiveing any materials");
                return;
            }

            float WeightReceived;
            if (float.TryParse(txtWeight.Text, out WeightReceived))
            {
                if (WeightReceived < 0 || WeightReceived == 0)
                {
                    errorProvider1.SetError(txtWeight, "Weight cannot be less than or equal to zero. Please re-enter you weight");
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(txtWeight, "Please enter a numerical value as your weight received");
                return;
            }

            if (dtpDateReceived.CustomFormat == " ")
            {
                errorProvider1.SetError(dtpDateReceived, "Please select a date");
                return;
            }

            if (dtpDateReceived.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtpDateReceived, "You cannot select a past date");
                return;
            }

            PopulateMaterialReceived();
            UpdateMaterialStock(Convert.ToInt32(cbxMaterialName.SelectedValue), float.Parse(txtWeight.Text));
            PopulateMaterialReceivedGrid(dgvMaterialReceived);
            Clear();
        }

        private void PopulateMaterialReceived()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string query = "INSERT INTO MATERIAL_RECEIVED (Supplier_ID, MaterialType_ID, PricePaid, Weight_Received, Date_Received) VALUES(@Supplier_ID, @MaterialType_ID, @PricePaid, @Weight_Received, @Date_Received)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Supplier_ID", cmbSupplierID.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaterialType_ID", cbxMaterialName.SelectedValue);
                    cmd.Parameters.AddWithValue("@PricePaid", Decimal.Parse(txtPricePaid.Text));
                    cmd.Parameters.AddWithValue("@Weight_Received", float.Parse(txtWeight.Text));
                    cmd.Parameters.AddWithValue("@Date_Received", dtpDateReceived.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Received successfully added.");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error adding material received" + e.Message);
            }
        }

        private void PopulateMaterialReceivedGrid(DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM MATERIAL_RECEIVED";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;  // Only selected customer appears
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Material Received: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cmbSupplierID.SelectedIndex = -1;
            cbxMaterialName.SelectedIndex = -1;
            txtSupplierFName.Clear();
            txtSupplierLName.Clear();
            txtWeight.Clear();
            cbxConfirm.Checked = false;

            cmbSupplierID.Focus();
        }

        private void UpdateMaterialStock(int materialTypeId, float weightReceived)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = @"UPDATE MATERIAL_TYPE SET Quantity_OnHand = Quantity_OnHand + @weightReceived WHERE MaterialType_ID = @MaterialType_ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@weightReceived", weightReceived);
                cmd.Parameters.AddWithValue("@MaterialType_ID", materialTypeId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
