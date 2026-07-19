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
    public partial class frmSaleTransactionPerPeriod : Form
    {
        public frmSaleTransactionPerPeriod()
        {
            InitializeComponent();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHomepage homepage = new frmHomepage();
            homepage.Show();
            this.Hide();
        }
    }
}
