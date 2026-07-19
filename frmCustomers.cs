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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        string conString = @"Server=Localhost\SQLEXPRESS;Database=ZeroWasteHubDB;Trusted_Connection=True;TrustServerCertificate=True";
    

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoHome();
        }

        private void GoHome()
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }

        public void DisplayCustomers(DataGridView dgv)//here it is
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM CUSTOMERS";
                    SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to display available customers: " + ex.Message);
            }
        }

        public void ClearFields()
        {
            cbxCustomerAgreement.Checked = false;
            cbxConfirmAdd.Checked = false;
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
        }

        /* Add new customer */
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!cbxCustomerAgreement.Checked)
            {
                cbxCustomerAgreement.Focus();
                errorProvider1.SetError(cbxCustomerAgreement, "Customer must agree to the terms and conditions before being added as a new customer.");
                return;
            }

            if (!cbxConfirmAdd.Checked)
            {
                cbxConfirmAdd.Focus();
                errorProvider1.SetError(cbxConfirmAdd, "Please confirm before attempting to add a customer to database.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                txtCustomerName.Focus();
                errorProvider1.SetError(txtCustomerName, "Customer name cannot be empty.Please fill in customer name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerEmail.Text))
            {
                txtCustomerEmail.Focus();
                errorProvider1.SetError(txtCustomerEmail, "Customer email cannot be empty.Please fill in customer email");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
            {
                txtCustomerPhone.Focus();
                errorProvider1.SetError(txtCustomerPhone, "Customer telephone number cannot be empty.Please fill in customer telephone number");
                return;
            }

            if (!IsValidEmail(txtCustomerEmail.Text))
            {
                errorProvider1.SetError(txtCustomerEmail, "Please enter a valid email address with the correct domain.");
                txtCustomerEmail.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string sql = "INSERT INTO CUSTOMERS (Customer_Name, Customer_Email, Customer_Phone) VALUES (@CustomerName, @CustomerEmail, @CustomerPhone)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    com.Parameters.AddWithValue("@CustomerEmail", txtCustomerEmail.Text);
                    com.Parameters.AddWithValue("@CustomerPhone", txtCustomerPhone.Text);
                    int rowsAffected = com.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New customer added successfully.");
                        ClearFields();
                        DisplayCustomers(dgvAddCustomers);
                        PopulateCustomerCombo(cmbCustomer);
                        PopulateCustomerCombo(cmbDeleteCustomer);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new customer.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to add a new customer: " + ex.Message);
            }
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

        private void LoadSelectedCustomer(int customerID, DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM CUSTOMERS WHERE Customer_ID = @CustomerID";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            DisplayCustomers(dgvAddCustomers);
            DisplayCustomers(dgvUpdateCustomer);
            DisplayCustomers(dgvDeleteCustomer);
            PopulateCustomerCombo(cmbCustomer);
            PopulateCustomerCombo(cmbDeleteCustomer);
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void PopulateCustomerCombo(ComboBox cbx)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT Customer_ID, Customer_Name FROM CUSTOMERS";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbx.DataSource = dt;
                cbx.DisplayMember = "Customer_Name";
                cbx.ValueMember = "Customer_ID";
                cbx.SelectedIndex = -1;
            }
        }

        /*Updating of customer details*/
        private void cbxCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerName.ReadOnly = !cbxCustomerName.Checked;
        }

        private void cbxCustomerEmailAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerEmail.ReadOnly = !cbxCustomerEmailAddress.Checked;
        }

        private void cbxCellNumber_CheckedChanged(object sender, EventArgs e)
        {
            mtbUpdateCellNumber.ReadOnly = !cbxCellNumber.Checked;
        }

        private void PopulateCustomerGrid(DataGridView dgv, int customerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string sql = "SELECT * FROM CUSTOMERS WHERE Customer_ID = @CustomerId";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@CustomerId", customerId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;  // Only selected customer appears
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer: " + ex.Message);
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cmbCustomer.SelectedIndex == -1)
            {
                cmbCustomer.Focus();
                errorProvider1.SetError(cmbCustomer, "Please select a customer to update.");
                return;
            }

            if (!cbxCustomerConfirmUpdate.Checked)
            {
                cbxCustomerConfirmUpdate.Focus();
                errorProvider1.SetError(cbxCustomerConfirmUpdate, "Please confirm before attempting to update customer details in database.");
                return;
            }

            List<string> set = new List<string>();
            SqlCommand com = new SqlCommand();

            if (!txtUpdateCustomerName.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(txtUpdateCustomerName.Text))
                {
                    txtUpdateCustomerName.Focus();
                    errorProvider1.SetError(txtUpdateCustomerName, "Customer name cannot be empty.Please fill in customer name");
                    return;
                }
                set.Add("Customer_Name = @CustomerName");
                com.Parameters.AddWithValue("@CustomerName", txtUpdateCustomerName.Text);
            }

            if (!txtUpdateCustomerEmail.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(txtUpdateCustomerEmail.Text))
                {
                    txtUpdateCustomerEmail.Focus();
                    errorProvider1.SetError(txtUpdateCustomerEmail, "Customer email cannot be empty.Please fill in customer email");
                    return;
                }
                if (!IsValidEmail(txtUpdateCustomerEmail.Text))
                {
                    errorProvider1.SetError(txtUpdateCustomerEmail, "Please enter a valid email address with the correct domain.");
                    txtUpdateCustomerEmail.Focus();
                    return;
                }
                set.Add("Customer_Email = @CustomerEmail");
                com.Parameters.AddWithValue("@CustomerEmail", txtUpdateCustomerEmail.Text);
            }

            if (!mtbUpdateCellNumber.ReadOnly)
            {
                if (string.IsNullOrWhiteSpace(mtbUpdateCellNumber.Text))
                {
                    mtbUpdateCellNumber.Focus();
                    errorProvider1.SetError(mtbUpdateCellNumber, "Customer telephone number cannot be empty.Please fill in customer telephone number");
                    return;
                }
                set.Add("Customer_Phone = @CustomerPhone");
                com.Parameters.AddWithValue("@CustomerPhone", mtbUpdateCellNumber.Text);
            }

            if (set.Count == 0)
            {
                MessageBox.Show("No fields selected for update. Please select at least one field to update.");
                return;
            }

            string setClause = string.Join(", ", set);
            com.CommandText = $"UPDATE CUSTOMERS SET {setClause} WHERE Customer_ID = @CustomerId";
            com.Parameters.AddWithValue("@CustomerId", cmbCustomer.SelectedValue);

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
                        DisplayCustomers(dgvUpdateCustomer);
                        DisplayCustomers(dgvAddCustomers);
                        DisplayCustomers(dgvDeleteCustomer);
                        PopulateCustomerCombo(cmbCustomer);
                        PopulateCustomerCombo(cmbDeleteCustomer);
                        cmbCustomer.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update customer details.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while trying to update customer details: " + ex.Message);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex < 0 || cmbCustomer.SelectedValue == null)
                return;

            int id;
            if (int.TryParse(cmbCustomer.SelectedValue?.ToString(), out id))
            {
                PopulateCustomerGrid(dgvUpdateCustomer, id);
            }
        }

        private void ClearUpdateFields()
        {
            cbxCustomerName.Checked = false;
            cbxCustomerEmailAddress.Checked = false;
            cbxCellNumber.Checked = false;
            cbxCustomerConfirmUpdate.Checked = false;
            txtUpdateCustomerName.Clear();
            txtUpdateCustomerEmail.Clear();
            mtbUpdateCellNumber.Clear();
            txtUpdateCustomerName.ReadOnly = true;
            txtUpdateCustomerEmail.ReadOnly = true;
            mtbUpdateCellNumber.ReadOnly = true;
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        /* Deletion of customer */
        private void cmbDeleteCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeleteCustomer.SelectedIndex == -1)
            {
                dgvDeleteCustomer.DataSource = null;
                txtDeleteCustomerName.Clear();
                return;
            }
            int customerID;
            if (!int.TryParse(cmbDeleteCustomer.SelectedValue?.ToString(), out customerID))
            {
                return; // gracefully exit if conversion fails
            }

            LoadSelectedCustomer(customerID, dgvDeleteCustomer);
            txtDeleteCustomerName.Text = cmbDeleteCustomer.Text;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (cmbDeleteCustomer.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDeleteCustomer, "Please select a customer to delete!");
                return;
            }

            if (!cbxConfirmDelete.Checked)
            {
                cbxConfirmDelete.Focus();
                errorProvider1.SetError(cbxConfirmDelete, "Please confirm before attempting to delete a customer from database.");
                return;
            }

            int customerID;

            if (!int.TryParse(cmbDeleteCustomer.SelectedValue?.ToString(), out customerID))
            {
                return; // gracefully exit if conversion fails
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string sql = "DELETE FROM CUSTOMERS WHERE Customer_ID = @CustomerID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("The customer has been deleted successfully!");
                }
                else MessageBox.Show("No customer found with selected ID.");

                DisplayCustomers(dgvAddCustomers);
                DisplayCustomers(dgvUpdateCustomer);
                DisplayCustomers(dgvDeleteCustomer);
                PopulateCustomerCombo(cmbDeleteCustomer);
                PopulateCustomerCombo(cmbCustomer);
                ClearDeleteFields();
            }
        }

        private void ClearDeleteFields()
        {
            cmbDeleteCustomer.SelectedIndex = -1;
            cmbDeleteCustomer.Text = "";
            txtDeleteCustomerName.Clear();
            dgvDeleteCustomer.DataSource = null;
            cbxConfirmDelete.Checked = false;
            errorProvider1.Clear();
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
