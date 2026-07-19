namespace Group20_Project
{
    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuppliers SupplierForm = new frmSuppliers();
            SupplierForm.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers CustomerForm = new frmCustomers();
            CustomerForm.Show();
            this.Hide();
        }

        private void materialTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialTypes materialTypeForm = new frmMaterialTypes();
            materialTypeForm.Show();
            this.Hide();
        }

        private void materialReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialReceived materialReceivedForm = new frmMaterialReceived();
            materialReceivedForm.Show();
            this.Hide();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSale saleForm = new frmSale();
            saleForm.Show();
            this.Hide();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuy buyForm = new frmBuy();
            buyForm.Show();
            this.Hide();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmView helpform = new frmView();
            helpform.Show();
            this.Hide();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogIn logInForm = new frmLogIn();
            logInForm.Show();
            this.Hide();
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {
            if (Session.UserRole == "Assistant")
            {
                suppliersToolStripMenuItem.Enabled = true;
                customersToolStripMenuItem.Visible = false;
                materialTypeToolStripMenuItem.Visible = false;
                materialReceivedToolStripMenuItem.Enabled = true;
                sellToolStripMenuItem.Visible = false;
                buyToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Visible = false;
            }

            else if (Session.UserRole == "Owner")
            {
                suppliersToolStripMenuItem.Enabled = true;
                customersToolStripMenuItem.Enabled = true;
                materialTypeToolStripMenuItem.Enabled = true;
                materialReceivedToolStripMenuItem.Enabled = true;
                sellToolStripMenuItem.Enabled = true;
                buyToolStripMenuItem.Enabled = true;
            }
        }

        private void top10MaterialTypeSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportTopSale topSaleForm = new frmReportTopSale();
            topSaleForm.Show();
            this.Hide();

        }

        private void salesTransactionPerPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportTopSale saleTransactionForm = new frmReportTopSale();
            saleTransactionForm.Show(); 
            this.Hide();
        }
    }
}