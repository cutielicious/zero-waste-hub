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
using System.Net.Mail;

namespace Group20_Project
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";

        /*My ouwn methods*/
        private void GoHome()
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void DisplaySuppliers(DataGridView dgv)//here it is
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM SUPPLIERS";
                    SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to display available suppliers: " + ex.Message);
            }
        }

        private void ClearAddFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSupplierPhone.Clear();
            txtEmail.Clear();
            cbxAgreement.Checked = false;
            cbxConfirmAdd.Checked = false;
            txtFirstName.Focus();
        }

        private void ClearUpdateFields()
        {
            txtUpdateName.Clear();
            txtUpdateLastName.Clear();
            txtUpdateEmail.Clear();
            mtbPhoneNumber.Clear();
            cbxName.Checked = false;
            cbxLastName.Checked = false;
            cbxEmailAddress.Checked = false;
            cbxPhoneNumber.Checked = false;
            cbxConfirmUpdate.Checked = false;
            txtUpdateName.ReadOnly = true;
            txtUpdateLastName.ReadOnly = true;
            txtUpdateEmail.ReadOnly = true;
            mtbPhoneNumber.ReadOnly = true;
        }

        private void ClearDeleteFields()
        {
            cmbDeleteSupplier.SelectedIndex = -1;
            txtDeleteName.Clear();
            txtDeleteLastName.Clear();
            cbxConfirmDelete.Checked = false;
            dgvDeleteSupplier.DataSource = null;
        }

        private void ValidatePhone(MaskedTextBox mtb)
        {

            if (mtb.MaskFull && mtb.Text.StartsWith("0"))
            {
                mtb.BackColor = Color.LightGreen; // valid
            }
            else
            {
                mtb.BackColor = Color.Red; // invalid
            }
        }
        private void LoadAll()
        {
            DisplaySuppliers(dgvAddSupplier);
            DisplaySuppliers(dgvUpdateSupplier);
            DisplaySuppliers(dgvDeleteSupplier);
            PopulateSupplierCombo(cmbUpdateSupplier);
            PopulateSupplierCombo(cmbDeleteSupplier);
            cmbUpdateSupplier.SelectedIndex = -1;
            cmbDeleteSupplier.SelectedIndex = -1;
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
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Input";
            toolTip1.Show(
                "Cell number must start with 0 and be numeric only", txtSupplierPhone,
                0, -20, // position tooltip above control
                2000);   // show for 2 seconds
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            txtSupplierPhone.PromptChar = ' ';
            txtSupplierPhone.SelectionStart = 0;
            DisplaySuppliers(dgvAddSupplier);
            DisplaySuppliers(dgvUpdateSupplier);
            DisplaySuppliers(dgvDeleteSupplier);
            PopulateSupplierCombo(cmbUpdateSupplier);
            PopulateSupplierCombo(cmbDeleteSupplier);
        }

        private void PopulateSupplierGrid(DataGridView dgv, int supplierId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM SUPPLIERS WHERE Supplier_ID = @SupplierId";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@SupplierId", supplierId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;  // Only selected customer appears
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier: " + ex.Message);
            }
        }

        /**Add Supplier Tab**/
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First name is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last name is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "A valid email with the correct domain is required");
                return;
            }

            if (txtSupplierPhone.Text.Length != 10 || !txtSupplierPhone.Text.StartsWith("0") || txtSupplierPhone.Text.Contains(" "))
            {
                txtSupplierPhone.Focus();
                errorProvider1.SetError(txtSupplierPhone, "A valid phone number is required");
                return;
            }

            if (!cbxAgreement.Checked)
            {
                cbxAgreement.Focus();
                errorProvider1.SetError(cbxAgreement, "Supplier must agree to the terms and conditions before being added to database");
                return;
            }

            if (!cbxConfirmAdd.Checked)
            {
                cbxConfirmAdd.Focus();
                errorProvider1.SetError(cbxConfirmAdd, "Please confirm that the information you have entered is correct");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "INSERT INTO SUPPLIERS (Supplier_LName,Supplier_FName, Supplier_Email, Supplier_Phone) VALUES (@SupplierLName, @SupplierFName, @SupplierEmail, @SupplierPhone)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@SupplierLName", txtLastName.Text);
                    com.Parameters.AddWithValue("@SupplierFName", txtFirstName.Text);
                    com.Parameters.AddWithValue("@SupplierEmail", txtEmail.Text);
                    com.Parameters.AddWithValue("@SupplierPhone", txtSupplierPhone.Text);
                    
                    int rowsAffected = com.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New supplier added successfully.");

                        LoadAll();
                        ClearAddFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new supplier.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to add a new supplier: " + ex.Message);
            }

        }

        private void btnSuppliersClear_Click(object sender, EventArgs e)
        {
            ClearAddFields();
        }


        /**Update Supplier Tab**/
        private void cbxName_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateName.ReadOnly = !cbxName.Checked;
        }

        private void cbxLastName_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateLastName.ReadOnly = !cbxLastName.Checked;
        }

        private void cbxEmailAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateEmail.ReadOnly = !cbxEmailAddress.Checked;
        }

        private void cbxPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            mtbPhoneNumber.ReadOnly = !cbxPhoneNumber.Checked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cmbUpdateSupplier.SelectedIndex == -1)
            {
                cmbUpdateSupplier.Focus();
                errorProvider1.SetError(cmbUpdateSupplier, "Please select a supplier to update.");
                return;
            }

            if (!cbxConfirmUpdate.Checked)
            {
                cbxConfirmUpdate.Focus();
                errorProvider1.SetError(cbxConfirmUpdate, "Please confirm before attempting to update supplier details in database.");
                return;
            }

            List<string> set = new List<string>();
            SqlCommand com = new SqlCommand();


            if (!txtUpdateName.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(txtUpdateName.Text))
                {
                    txtUpdateName.Focus();
                    errorProvider1.SetError(txtUpdateName, "Supplier name cannot be empty.Please fill in supplier first name");
                    return;
                }
                set.Add("Supplier_FName = @SupplierFName");
                com.Parameters.AddWithValue("@SupplierFName", txtUpdateName.Text);
            }

            if (!txtUpdateLastName.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(txtUpdateLastName.Text))
                {
                    txtUpdateLastName.Focus();
                    errorProvider1.SetError(txtUpdateLastName, "Supplier name cannot be empty.Please fill in supplier last name");
                    return;
                }
                set.Add("Supplier_LName = @SupplierLName");
                com.Parameters.AddWithValue("@SupplierLName", txtUpdateLastName.Text);
            }

            if (!txtUpdateEmail.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(txtUpdateEmail.Text))
                {
                    txtUpdateEmail.Focus();
                    errorProvider1.SetError(txtUpdateEmail, "Supplier email cannot be empty.Please fill in supplier email");
                    return;
                }
                if (!IsValidEmail(txtUpdateEmail.Text))
                {
                    errorProvider1.SetError(txtUpdateEmail, "Please enter a valid email address with the correct domain.");
                    txtUpdateEmail.Focus();
                    return;
                }
                set.Add("Supplier_Email = @SupplierEmail");
                com.Parameters.AddWithValue("@SupplierEmail", txtUpdateEmail.Text);
            }

            if (!mtbPhoneNumber.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(mtbPhoneNumber.Text))
                {
                    mtbPhoneNumber.Focus();
                    errorProvider1.SetError(mtbPhoneNumber, "Supplier telephone number cannot be empty.Please fill in supplier telephone number");
                    return;
                }
                set.Add("Supplier_Phone = @SupplierPhone");
                com.Parameters.AddWithValue("@SupplierPhone", mtbPhoneNumber.Text);
            }

            if (set.Count == 0)
            {
                MessageBox.Show("No fields selected for update. Please select at least one field to update.");
                return;
            }

            string setClause = string.Join(", ", set);
            com.CommandText = $"UPDATE SUPPLIERS SET {setClause} WHERE Supplier_ID = @SupplierId";
            com.Parameters.AddWithValue("@SupplierId", cmbUpdateSupplier.SelectedValue);

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    com.Connection = con;
                    int rowsAffected = com.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer details updated successfully.");
                        ClearUpdateFields();
                        LoadAll();
                        cmbUpdateSupplier.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update supplier details.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while trying to update supplier details: " + ex.Message);
            }
        }

        private void cmbUpdateSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateSupplier.SelectedIndex < 0 || cmbUpdateSupplier.SelectedValue == null)
                return;

            int id;
            if (int.TryParse(cmbUpdateSupplier.SelectedValue?.ToString(), out id))
            {
                PopulateSupplierGrid(dgvUpdateSupplier, id);
            }
        }

        private void mtbPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Input";
            toolTip1.Show("Only numbers are allowed.", mtbPhoneNumber, 2000);
        }

        private void mtbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidatePhone(mtbPhoneNumber);
        }

        private void txtSupplierPhone_TextChanged(object sender, EventArgs e)
        {
            ValidatePhone(txtSupplierPhone);
        }

        /**Delete Supplier Tab**/
        private void cmbDeleteSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeleteSupplier.SelectedIndex < 0 || cmbDeleteSupplier.SelectedValue == null)
                return;

            int id;
            if (int.TryParse(cmbDeleteSupplier.SelectedValue?.ToString(), out id))
            {
                PopulateSupplierGrid(dgvDeleteSupplier, id);
                LoadSelectedSupplier(id);
            }

            txtDeleteName.Text = cmbDeleteSupplier.SelectedValue?.ToString();
            txtDeleteLastName.Text = cmbDeleteSupplier.SelectedValue?.ToString();
        }

        private void LoadSelectedSupplier(int supplierID)
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
                        txtDeleteName.Text = reader["Supplier_FName"].ToString();
                        txtDeleteLastName.Text = reader["Supplier_LName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier details: " + ex.Message);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (cmbDeleteSupplier.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDeleteSupplier, "Please select a supplier to delete!");
                return;
            }

            if (!cbxConfirmDelete.Checked)
            {
                cbxConfirmDelete.Focus();
                errorProvider1.SetError(cbxConfirmDelete, "Please confirm before attempting to delete a supplier from database.");
                return;
            }

            int supplierID;

            if (!int.TryParse(cmbDeleteSupplier.SelectedValue?.ToString(), out supplierID))
            {
                return; // gracefully exit if conversion fails
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = "DELETE FROM SUPPLIERS WHERE Supplier_ID = @SupplierID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("The supplier has been deleted successfully!");
                    LoadAll();
                    cmbDeleteSupplier.SelectedIndex = -1;
                    ClearDeleteFields();
                }
                else
                {
                    MessageBox.Show("No supplier found with selected ID.");
                    return;
                }
            }
        }

        private void btnDeleteClear_Click(object sender, EventArgs e)
        {
            ClearDeleteFields();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }
    }
}
