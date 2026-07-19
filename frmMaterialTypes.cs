using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Group20_Project
{
    public partial class frmMaterialTypes : Form
    {
        public frmMaterialTypes()
        {
            InitializeComponent();
        }

        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";
      
        public void GoHome()
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }

        private void frmMaterialTypes_Load(object sender, EventArgs e)
        {
            LoadAllMaterials();
            PopulateComboBoxes(cmbMaterialID);
            PopulateComboBoxes(cmbDeleteMaterial);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void LoadAllMaterials()
        {
            DisplayAllMaterials(dgvAddMaterialType);
            DisplayAllMaterials(dgvUpdateMaterials);
            DisplayAllMaterials(dgvDeleteMaterial);
        }

        private void DisplayAllMaterials(DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT * FROM MATERIAL_TYPES";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying materials: " + ex.Message);
            }
        }

        private void PopulateComboBoxes(ComboBox cbx)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "SELECT MaterialType_ID, Material_Name FROM MATERIAL_TYPES";
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

        private void btnAddMaterialType_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!ValidateAddInputs(out string materialName, out double quantity, out decimal pricePerKg, out decimal sellingPrice))
                return;

            if (!cbxAddConfirm.Checked)
            {
                errorProvider1.SetError(cbxAddConfirm, "Please confirm that the details are correct!");
                return; // Stop execution here
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    // Check for duplicate
                    string checkQuery = "SELECT COUNT(*) FROM MATERIAL_TYPES WHERE LOWER(Material_Name) = LOWER(@MaterialName)";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@MaterialName", materialName);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show(materialName + " is already in the database");
                        ClearAddFields();
                        return;
                    }

                    // Insert
                    string insertQuery = "INSERT INTO MATERIAL_TYPES(Material_Name, Quantity_OnHand, Price_Per_Kg, Selling_Price) " +
                                         "VALUES (@MaterialName, @QuantityOnHand, @PricePerKg, @SellingPrice)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@MaterialName", materialName);
                    cmd.Parameters.AddWithValue("@QuantityOnHand", quantity);
                    cmd.Parameters.AddWithValue("@PricePerKg", pricePerKg);
                    cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(materialName + " has been added successfully!", "Success");
                }

                LoadAllMaterials();
                PopulateComboBoxes(cmbMaterialID);
                PopulateComboBoxes(cmbDeleteMaterial);
                ClearAddFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding material: " + ex.Message);
            }
        }

        private bool ValidateAddInputs(out string materialName, out double quantity, out decimal pricePerKg, out decimal sellingPrice)
        {
            materialName = txtAddMaterialType.Text.Trim();
            quantity = 0;
            pricePerKg = 0;
            sellingPrice = 0;

            if (string.IsNullOrWhiteSpace(materialName))
            {
                errorProvider1.SetError(txtAddMaterialType, "Please enter a material name!");
                return false;
            }

            if (!decimal.TryParse(txtPricekg.Text, out pricePerKg))
            {
                errorProvider1.SetError(txtPricekg, "Enter a valid numeric price per kg!");
                return false;
            }

            if (!decimal.TryParse(txtSellingPrice.Text, out sellingPrice))
            {
                errorProvider1.SetError(txtSellingPrice, "Enter a valid selling price!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtQtyHand.Text) &&
                !double.TryParse(txtQtyHand.Text, out quantity))
            {
                errorProvider1.SetError(txtQtyHand, "Enter a valid numeric quantity!");
                return false;
            }

            if (!cbxAddConfirm.Checked)
            {
                errorProvider1.SetError(cbxAddConfirm, "Please confirm the details!");
                return false;
            }

            if (pricePerKg < 0 || sellingPrice < 0 || quantity < 0)
            {
                MessageBox.Show("Values cannot be negative!");
                return false;
            }

            if (sellingPrice < pricePerKg)
            {
                MessageBox.Show("Selling price cannot be less than price per kg!");
                return false;
            }

            return true;
        }

        private void ClearAddFields()
        {
            txtAddMaterialType.Clear();
            txtPricekg.Clear();
            txtQtyHand.Clear();
            txtSellingPrice.Clear();
            cbxAddConfirm.Checked = false;
            errorProvider1.Clear();
        }

        private void cmbMaterialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterialID.SelectedIndex == -1) return;
            int materialID = GetSelectedMaterialID(cmbMaterialID);
            LoadSelectedMaterial(materialID, dgvUpdateMaterials);
        }

        private void LoadSelectedMaterial(int materialID, DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM MATERIAL_TYPES WHERE MaterialType_ID = @MaterialID";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaterialID", materialID);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading material: " + ex.Message);
            }
        }

        private void cbxMaterialName_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateMaterialName.ReadOnly = !cbxMaterialName.Checked;
        }

        private void cbxPricePkg_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdatePricePkg.ReadOnly = !cbxPricePkg.Checked;
        }

        private void cbxSellingPrice_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateSellingPrice.ReadOnly = !cbxSellingPrice.Checked;
        }

        private void cbxQtyHand_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateQtyHand.ReadOnly = !cbxQtyHand.Checked;
        }

        private void btnUpdateMaterialType_Click(object sender, EventArgs e)
        {
            if (cmbMaterialID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a material to update.");
                return;
            }

            if (!cbxConfirmUpdate.Checked)
            {
                errorProvider1.SetError(cbxConfirmUpdate, "Please confirm that the details are correct!");
                return;
            }

            int materialID = GetSelectedMaterialID(cmbMaterialID);

            List<string> setParts = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(conString);

            if (!txtUpdateMaterialName.ReadOnly)
            {
                setParts.Add("Material_Name = @Name");
                cmd.Parameters.AddWithValue("@Name", txtUpdateMaterialName.Text);
            }

            if (!txtUpdateQtyHand.ReadOnly)
            {
                setParts.Add("Quantity_OnHand = @Quantity");
                cmd.Parameters.AddWithValue("@Quantity", double.Parse(txtUpdateQtyHand.Text));
            }

            if (!txtUpdatePricePkg.ReadOnly)
            {
                setParts.Add("Price_Per_Kg = @P_kg");
                cmd.Parameters.AddWithValue("@P_kg", decimal.Parse(txtUpdatePricePkg.Text));
            }

            if (!txtUpdateSellingPrice.ReadOnly)
            {
                setParts.Add("Selling_Price = @SellingPrice");
                cmd.Parameters.AddWithValue("@SellingPrice", decimal.Parse(txtUpdateSellingPrice.Text));
            }

            if (setParts.Count == 0)
            {
                MessageBox.Show("No fields selected to update!");
                return;
            }

            string setClause = string.Join(", ", setParts);
            cmd.CommandText = $"UPDATE MATERIAL_TYPES SET {setClause} WHERE MaterialType_ID = @MaterialID";
            cmd.Parameters.AddWithValue("@MaterialID", materialID);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                MessageBox.Show("Material updated successfully!");
                LoadAllMaterials();
                ClearUpdateFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating material: " + ex.Message);
            }
        }

        private int GetSelectedMaterialID(ComboBox cmb)
        {
            if (cmb.SelectedValue is DataRowView drv)
                return Convert.ToInt32(drv["MaterialType_ID"]);
            return Convert.ToInt32(cmb.SelectedValue);
        }

        private void ClearUpdateFields()
        {
            cmbMaterialID.SelectedIndex = -1;
            txtUpdateMaterialName.Clear();
            txtUpdatePricePkg.Clear();
            txtUpdateQtyHand.Clear();
            txtUpdateSellingPrice.Clear();
            txtUpdateMaterialName.ReadOnly = true;
            txtUpdatePricePkg.ReadOnly = true;
            txtUpdateQtyHand.ReadOnly = true;
            txtUpdateSellingPrice.ReadOnly = true;
            cbxMaterialName.Checked = false;
            cbxPricePkg.Checked = false;
            cbxQtyHand.Checked = false;
            cbxSellingPrice.Checked = false;
            cbxConfirmUpdate.Checked = false;
            errorProvider1.Clear();
        }

        private void cmbDeleteMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeleteMaterial.SelectedIndex == -1)
            {
                dgvDeleteMaterial.DataSource = null;
                txtDeleteMaterialName.Clear();
                return;
            }

            int materialID = GetSelectedMaterialID(cmbDeleteMaterial);
            LoadSelectedMaterial(materialID, dgvDeleteMaterial);

            // Fill material name
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = "SELECT Material_Name FROM MATERIAL_TYPES WHERE MaterialType_ID = @MaterialID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaterialID", materialID);
                var result = cmd.ExecuteScalar();
                txtDeleteMaterialName.Text = result?.ToString() ?? "";
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cmbDeleteMaterial.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDeleteMaterial, "Select a material to delete!");
                return;
            }

            if (!cbxDeleteConfirm.Checked)
            {
                errorProvider1.SetError(cbxDeleteConfirm, "Please confirm deletion!");
                return;
            }

            int materialID = GetSelectedMaterialID(cmbDeleteMaterial);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = "DELETE FROM MATERIAL_TYPES WHERE MaterialType_ID = @MaterialID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaterialID", materialID);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) MessageBox.Show("Material deleted successfully!");
                else MessageBox.Show("No material found with selected ID.");

                LoadAllMaterials();
                PopulateComboBoxes(cmbDeleteMaterial);
                ClearDeleteFields();
            }
        }

        private void ClearDeleteFields()
        {
            cmbDeleteMaterial.SelectedIndex = -1;
            txtDeleteMaterialName.Clear();
            cbxDeleteConfirm.Checked = false;
            errorProvider1.Clear();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            ClearAddFields();
        }

        private void btnTypeUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDeleteFields();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }
    }
}
