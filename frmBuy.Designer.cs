namespace Group20_Project
{
    partial class frmBuy
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
            linkLabel1 = new LinkLabel();
            gbxSelectCustomer = new GroupBox();
            txtSupplBuyEmail = new TextBox();
            txtSupplBuyPhone = new TextBox();
            txtSupplBuyName = new TextBox();
            lblSupplBuyEmail = new Label();
            lblSupplBuyPhone = new Label();
            lblSupplierBuyName = new Label();
            lblSupplierIDBuy = new Label();
            cbxSupplBuyID = new ComboBox();
            groupBox1 = new GroupBox();
            txtTotalPrice = new TextBox();
            lblPricePerKg = new Label();
            btnAdd = new Button();
            dtpBuyDate = new DateTimePicker();
            txtQuantity = new TextBox();
            cbxMaterialName = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gbxRemoveItem = new GroupBox();
            label11 = new Label();
            btnDelete = new Button();
            groupBox4 = new GroupBox();
            cbxConfirm = new CheckBox();
            label2 = new Label();
            lblBuyInstruction = new Label();
            dbViewBuy = new DataGridView();
            btnBuy = new Button();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            gbxSelectCustomer.SuspendLayout();
            groupBox1.SuspendLayout();
            gbxRemoveItem.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbViewBuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1331, 578);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // gbxSelectCustomer
            // 
            gbxSelectCustomer.Controls.Add(txtSupplBuyEmail);
            gbxSelectCustomer.Controls.Add(txtSupplBuyPhone);
            gbxSelectCustomer.Controls.Add(txtSupplBuyName);
            gbxSelectCustomer.Controls.Add(lblSupplBuyEmail);
            gbxSelectCustomer.Controls.Add(lblSupplBuyPhone);
            gbxSelectCustomer.Controls.Add(lblSupplierBuyName);
            gbxSelectCustomer.Controls.Add(lblSupplierIDBuy);
            gbxSelectCustomer.Controls.Add(cbxSupplBuyID);
            gbxSelectCustomer.Location = new Point(33, 111);
            gbxSelectCustomer.Name = "gbxSelectCustomer";
            gbxSelectCustomer.Size = new Size(348, 317);
            gbxSelectCustomer.TabIndex = 17;
            gbxSelectCustomer.TabStop = false;
            gbxSelectCustomer.Text = "* Section 1: Plese select a supplier below";
            // 
            // txtSupplBuyEmail
            // 
            txtSupplBuyEmail.Enabled = false;
            txtSupplBuyEmail.Location = new Point(146, 215);
            txtSupplBuyEmail.Name = "txtSupplBuyEmail";
            txtSupplBuyEmail.ReadOnly = true;
            txtSupplBuyEmail.Size = new Size(151, 27);
            txtSupplBuyEmail.TabIndex = 8;
            // 
            // txtSupplBuyPhone
            // 
            txtSupplBuyPhone.Enabled = false;
            txtSupplBuyPhone.Location = new Point(146, 163);
            txtSupplBuyPhone.Name = "txtSupplBuyPhone";
            txtSupplBuyPhone.ReadOnly = true;
            txtSupplBuyPhone.Size = new Size(151, 27);
            txtSupplBuyPhone.TabIndex = 7;
            // 
            // txtSupplBuyName
            // 
            txtSupplBuyName.Enabled = false;
            txtSupplBuyName.Location = new Point(146, 107);
            txtSupplBuyName.Name = "txtSupplBuyName";
            txtSupplBuyName.ReadOnly = true;
            txtSupplBuyName.Size = new Size(151, 27);
            txtSupplBuyName.TabIndex = 6;
            // 
            // lblSupplBuyEmail
            // 
            lblSupplBuyEmail.AutoSize = true;
            lblSupplBuyEmail.Location = new Point(7, 213);
            lblSupplBuyEmail.Name = "lblSupplBuyEmail";
            lblSupplBuyEmail.Size = new Size(108, 20);
            lblSupplBuyEmail.TabIndex = 2;
            lblSupplBuyEmail.Text = "Supplier Email:";
            // 
            // lblSupplBuyPhone
            // 
            lblSupplBuyPhone.AutoSize = true;
            lblSupplBuyPhone.Location = new Point(6, 163);
            lblSupplBuyPhone.Name = "lblSupplBuyPhone";
            lblSupplBuyPhone.Size = new Size(112, 20);
            lblSupplBuyPhone.TabIndex = 1;
            lblSupplBuyPhone.Text = "Supplier Phone:";
            // 
            // lblSupplierBuyName
            // 
            lblSupplierBuyName.AutoSize = true;
            lblSupplierBuyName.Location = new Point(6, 107);
            lblSupplierBuyName.Name = "lblSupplierBuyName";
            lblSupplierBuyName.Size = new Size(111, 20);
            lblSupplierBuyName.TabIndex = 0;
            lblSupplierBuyName.Text = "Supplier Name:";
            // 
            // lblSupplierIDBuy
            // 
            lblSupplierIDBuy.AutoSize = true;
            lblSupplierIDBuy.Location = new Point(6, 53);
            lblSupplierIDBuy.Name = "lblSupplierIDBuy";
            lblSupplierIDBuy.Size = new Size(86, 20);
            lblSupplierIDBuy.TabIndex = 0;
            lblSupplierIDBuy.Text = "Supplier ID:";
            // 
            // cbxSupplBuyID
            // 
            cbxSupplBuyID.FormattingEnabled = true;
            cbxSupplBuyID.Location = new Point(146, 53);
            cbxSupplBuyID.Name = "cbxSupplBuyID";
            cbxSupplBuyID.Size = new Size(151, 28);
            cbxSupplBuyID.TabIndex = 5;
            cbxSupplBuyID.SelectedIndexChanged += cbxSupplBuyID_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(lblPricePerKg);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dtpBuyDate);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(cbxMaterialName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(407, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 308);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Section 2: Please select the material being bought";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(166, 163);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(125, 27);
            txtTotalPrice.TabIndex = 12;
            // 
            // lblPricePerKg
            // 
            lblPricePerKg.AutoSize = true;
            lblPricePerKg.Location = new Point(193, 163);
            lblPricePerKg.Name = "lblPricePerKg";
            lblPricePerKg.Size = new Size(0, 20);
            lblPricePerKg.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 47);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Item to cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpBuyDate
            // 
            dtpBuyDate.Location = new Point(166, 213);
            dtpBuyDate.Name = "dtpBuyDate";
            dtpBuyDate.Size = new Size(199, 27);
            dtpBuyDate.TabIndex = 9;
            dtpBuyDate.ValueChanged += dateTimePicker1_ValueChanged;
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
            label6.Size = new Size(85, 20);
            label6.TabIndex = 3;
            label6.Text = "Total Price: ";
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
            // gbxRemoveItem
            // 
            gbxRemoveItem.Controls.Add(label11);
            gbxRemoveItem.Controls.Add(btnDelete);
            gbxRemoveItem.Location = new Point(818, 114);
            gbxRemoveItem.Name = "gbxRemoveItem";
            gbxRemoveItem.Size = new Size(450, 180);
            gbxRemoveItem.TabIndex = 19;
            gbxRemoveItem.TabStop = false;
            gbxRemoveItem.Text = "* Section 3: Remove item from being purchased";
            // 
            // label11
            // 
            label11.Location = new Point(25, 32);
            label11.Name = "label11";
            label11.Size = new Size(419, 51);
            label11.TabIndex = 0;
            label11.Text = "Please select an item on the data grid view that you wish to no longer purchase, then proceed to press the button below";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(152, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Remove Item from cart";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxConfirm);
            groupBox4.Location = new Point(1295, 114);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(295, 136);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "* Section 4: Confirm Purchase";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(40, 10);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 21;
            label2.Text = "Purchase Form\r\n";
            // 
            // lblBuyInstruction
            // 
            lblBuyInstruction.Location = new Point(33, 41);
            lblBuyInstruction.Name = "lblBuyInstruction";
            lblBuyInstruction.Size = new Size(505, 53);
            lblBuyInstruction.TabIndex = 22;
            lblBuyInstruction.Text = "Please select the information you would like to purchase. Fields you do not change will remain the same. Fields marked * are required.\r\n";
            // 
            // dbViewBuy
            // 
            dbViewBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbViewBuy.Location = new Point(33, 477);
            dbViewBuy.Name = "dbViewBuy";
            dbViewBuy.RowHeadersWidth = 51;
            dbViewBuy.Size = new Size(479, 188);
            dbViewBuy.TabIndex = 23;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(937, 300);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(130, 58);
            btnBuy.TabIndex = 12;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(937, 381);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1720, 634);
            Controls.Add(btnBuy);
            Controls.Add(btnClear);
            Controls.Add(dbViewBuy);
            Controls.Add(lblBuyInstruction);
            Controls.Add(label2);
            Controls.Add(groupBox4);
            Controls.Add(gbxRemoveItem);
            Controls.Add(groupBox1);
            Controls.Add(gbxSelectCustomer);
            Controls.Add(linkLabel1);
            Name = "frmBuy";
            Text = "frmBuy";
            WindowState = FormWindowState.Maximized;
            Load += frmBuy_Load;
            gbxSelectCustomer.ResumeLayout(false);
            gbxSelectCustomer.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxRemoveItem.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbViewBuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private GroupBox gbxSelectCustomer;
        private TextBox txtSupplBuyEmail;
        private TextBox txtSupplBuyPhone;
        private TextBox txtSupplBuyName;
        private Label lblSupplBuyEmail;
        private Label lblSupplBuyPhone;
        private Label lblSupplierBuyName;
        private Label lblSupplierIDBuy;
        private ComboBox cbxSupplBuyID;
        private GroupBox groupBox1;
        private Button btnAdd;
        private DateTimePicker dtpBuyDate;
        private TextBox txtQuantity;
        private ComboBox cbxMaterialName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbxRemoveItem;
        private Label label11;
        private Button btnDelete;
        private GroupBox groupBox4;
        private CheckBox cbxConfirm;
        private Label label2;
        private Label lblBuyInstruction;
        private DataGridView dbViewBuy;
        private Label lblPricePerKg;
        private Button btnBuy;
        private Button btnClear;
        private ErrorProvider errorProvider1;
        private TextBox txtTotalPrice;
    }
}