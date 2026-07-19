namespace Group20_Project
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dtpDateSold = new DateTimePicker();
            txtAmountDue = new TextBox();
            txtQuantity = new TextBox();
            cbxMaterialName = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSellMaterial = new Button();
            cbxCustomerID = new ComboBox();
            dgvSalesOrder = new DataGridView();
            linkLabel2 = new LinkLabel();
            groupBox4 = new GroupBox();
            cbxConfirm = new CheckBox();
            gbxSelectCustomer = new GroupBox();
            txtCustomerEmail = new TextBox();
            txtCustomerPhone = new TextBox();
            txtCustomerName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).BeginInit();
            groupBox4.SuspendLayout();
            gbxSelectCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDateSold);
            groupBox1.Controls.Add(txtAmountDue);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(cbxMaterialName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(397, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Section 2: Please select the material being sold";
            // 
            // dtpDateSold
            // 
            dtpDateSold.Location = new Point(166, 213);
            dtpDateSold.Name = "dtpDateSold";
            dtpDateSold.Size = new Size(199, 27);
            dtpDateSold.TabIndex = 9;
            dtpDateSold.ValueChanged += dtpDateSold_ValueChanged;
            // 
            // txtAmountDue
            // 
            txtAmountDue.Enabled = false;
            txtAmountDue.Location = new Point(166, 160);
            txtAmountDue.Name = "txtAmountDue";
            txtAmountDue.ReadOnly = true;
            txtAmountDue.Size = new Size(125, 27);
            txtAmountDue.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(166, 108);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // cbxMaterialName
            // 
            cbxMaterialName.FormattingEnabled = true;
            cbxMaterialName.Location = new Point(166, 58);
            cbxMaterialName.Name = "cbxMaterialName";
            cbxMaterialName.Size = new Size(151, 28);
            cbxMaterialName.TabIndex = 6;
            cbxMaterialName.SelectedIndexChanged += cbxMaterialName_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 213);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 4;
            label7.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 163);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 3;
            label6.Text = "Amount Due:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 115);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 2;
            label5.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 61);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 1;
            label4.Text = "Material Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(529, 60);
            label1.TabIndex = 1;
            label1.Text = "Please complete this form to accurately document and confirm materials sold. \r\nSections with this * sign indicate that it it compulsory to fill in that section\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Sales Form\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "Customer ID:";
            // 
            // btnSellMaterial
            // 
            btnSellMaterial.Location = new Point(861, 315);
            btnSellMaterial.Name = "btnSellMaterial";
            btnSellMaterial.Size = new Size(130, 58);
            btnSellMaterial.TabIndex = 5;
            btnSellMaterial.Text = "Sell Material";
            btnSellMaterial.UseVisualStyleBackColor = true;
            btnSellMaterial.Click += btnSellMaterial_Click;
            // 
            // cbxCustomerID
            // 
            cbxCustomerID.FormattingEnabled = true;
            cbxCustomerID.Location = new Point(146, 53);
            cbxCustomerID.Name = "cbxCustomerID";
            cbxCustomerID.Size = new Size(151, 28);
            cbxCustomerID.TabIndex = 5;
            cbxCustomerID.SelectedIndexChanged += cbxCustomerID_SelectedIndexChanged;
            // 
            // dgvSalesOrder
            // 
            dgvSalesOrder.BackgroundColor = Color.LightGreen;
            dgvSalesOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesOrder.Location = new Point(43, 483);
            dgvSalesOrder.Name = "dgvSalesOrder";
            dgvSalesOrder.RowHeadersWidth = 51;
            dgvSalesOrder.Size = new Size(1027, 188);
            dgvSalesOrder.TabIndex = 13;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(1243, 695);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxConfirm);
            groupBox4.Location = new Point(827, 152);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(295, 136);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "* Section 3: Confirm Sale";
            // 
            // cbxConfirm
            // 
            cbxConfirm.Location = new Point(34, 35);
            cbxConfirm.Name = "cbxConfirm";
            cbxConfirm.Size = new Size(241, 77);
            cbxConfirm.TabIndex = 0;
            cbxConfirm.Text = "I confirm that the information provided is correct.";
            cbxConfirm.UseVisualStyleBackColor = true;
            // 
            // gbxSelectCustomer
            // 
            gbxSelectCustomer.Controls.Add(txtCustomerEmail);
            gbxSelectCustomer.Controls.Add(txtCustomerPhone);
            gbxSelectCustomer.Controls.Add(txtCustomerName);
            gbxSelectCustomer.Controls.Add(label10);
            gbxSelectCustomer.Controls.Add(label9);
            gbxSelectCustomer.Controls.Add(label8);
            gbxSelectCustomer.Controls.Add(label3);
            gbxSelectCustomer.Controls.Add(cbxCustomerID);
            gbxSelectCustomer.Location = new Point(18, 152);
            gbxSelectCustomer.Name = "gbxSelectCustomer";
            gbxSelectCustomer.Size = new Size(348, 317);
            gbxSelectCustomer.TabIndex = 16;
            gbxSelectCustomer.TabStop = false;
            gbxSelectCustomer.Text = "* Section 1: Plese select a customer below";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(146, 206);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.ReadOnly = true;
            txtCustomerEmail.Size = new Size(151, 27);
            txtCustomerEmail.TabIndex = 8;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(146, 163);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.ReadOnly = true;
            txtCustomerPhone.Size = new Size(151, 27);
            txtCustomerPhone.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(146, 107);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(151, 27);
            txtCustomerName.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 213);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 2;
            label10.Text = "Customer Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 163);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 1;
            label9.Text = "Customer Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 107);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 0;
            label8.Text = "Customer Name:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(861, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 734);
            Controls.Add(btnClear);
            Controls.Add(gbxSelectCustomer);
            Controls.Add(groupBox4);
            Controls.Add(linkLabel2);
            Controls.Add(dgvSalesOrder);
            Controls.Add(btnSellMaterial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmSale";
            Text = "frmSale";
            Load += frmSale_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).EndInit();
            groupBox4.ResumeLayout(false);
            gbxSelectCustomer.ResumeLayout(false);
            gbxSelectCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDateSold;
        private TextBox txtAmountDue;
        private TextBox txtQuantity;
        private ComboBox cbxMaterialName;
        private ComboBox cbxCustomerID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnSellMaterial;
        private DataGridView dgvSalesOrder;
        private LinkLabel linkLabel2;
        private GroupBox groupBox4;
        private CheckBox cbxConfirm;
        private GroupBox gbxSelectCustomer;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerName;
        private Button btnClear;
        private ErrorProvider errorProvider1;
    }
}