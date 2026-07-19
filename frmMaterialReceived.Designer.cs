namespace Group20_Project
{
    partial class frmMaterialReceived
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
            lblHeading = new Label();
            gbxReceive = new GroupBox();
            txtPricePaid = new TextBox();
            label8 = new Label();
            dtpDateReceived = new DateTimePicker();
            label7 = new Label();
            lblPriceOutPut = new Label();
            txtWeight = new TextBox();
            cbxMaterialName = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnReceive = new Button();
            dgvMaterialReceived = new DataGridView();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            gbxChooseSupplier = new GroupBox();
            txtSupplierPhone = new TextBox();
            txtSupplierEmail = new TextBox();
            txtSupplierLName = new TextBox();
            txtSupplierFName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            cmbSupplierID = new ComboBox();
            label5 = new Label();
            gbxConfirmSupplier = new GroupBox();
            cbxConfirm = new CheckBox();
            linkLabel1 = new LinkLabel();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            gbxReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialReceived).BeginInit();
            gbxChooseSupplier.SuspendLayout();
            gbxConfirmSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeading.Location = new Point(26, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(133, 20);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Material Received";
            // 
            // gbxReceive
            // 
            gbxReceive.Controls.Add(txtPricePaid);
            gbxReceive.Controls.Add(label8);
            gbxReceive.Controls.Add(dtpDateReceived);
            gbxReceive.Controls.Add(label7);
            gbxReceive.Controls.Add(lblPriceOutPut);
            gbxReceive.Controls.Add(txtWeight);
            gbxReceive.Controls.Add(cbxMaterialName);
            gbxReceive.Controls.Add(label4);
            gbxReceive.Controls.Add(label3);
            gbxReceive.Controls.Add(label2);
            gbxReceive.Location = new Point(418, 99);
            gbxReceive.Name = "gbxReceive";
            gbxReceive.Size = new Size(402, 282);
            gbxReceive.TabIndex = 1;
            gbxReceive.TabStop = false;
            gbxReceive.Text = "* Section 2: Receive Donations";
            // 
            // txtPricePaid
            // 
            txtPricePaid.Location = new Point(138, 141);
            txtPricePaid.Name = "txtPricePaid";
            txtPricePaid.ReadOnly = true;
            txtPricePaid.Size = new Size(125, 27);
            txtPricePaid.TabIndex = 14;
            txtPricePaid.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 190);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 13;
            label8.Text = "Date:";
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.CustomFormat = "dd MMM yyyy";
            dtpDateReceived.Format = DateTimePickerFormat.Custom;
            dtpDateReceived.Location = new Point(130, 191);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(250, 27);
            dtpDateReceived.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 90);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 10;
            label7.Text = "kg";
            // 
            // lblPriceOutPut
            // 
            lblPriceOutPut.AutoSize = true;
            lblPriceOutPut.Location = new Point(214, 196);
            lblPriceOutPut.Name = "lblPriceOutPut";
            lblPriceOutPut.Size = new Size(0, 20);
            lblPriceOutPut.TabIndex = 9;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(130, 83);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(84, 27);
            txtWeight.TabIndex = 8;
            // 
            // cbxMaterialName
            // 
            cbxMaterialName.FormattingEnabled = true;
            cbxMaterialName.Location = new Point(132, 35);
            cbxMaterialName.Name = "cbxMaterialName";
            cbxMaterialName.Size = new Size(151, 28);
            cbxMaterialName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 141);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "Price Paid:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 90);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Weight:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Material Name:";
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(892, 230);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(130, 58);
            btnReceive.TabIndex = 11;
            btnReceive.Text = "Receive";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // dgvMaterialReceived
            // 
            dgvMaterialReceived.BackgroundColor = Color.LightGreen;
            dgvMaterialReceived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialReceived.Location = new Point(12, 445);
            dgvMaterialReceived.Name = "dgvMaterialReceived";
            dgvMaterialReceived.RowHeadersWidth = 51;
            dgvMaterialReceived.Size = new Size(923, 260);
            dgvMaterialReceived.TabIndex = 13;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(1639, 684);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(858, 40);
            label1.TabIndex = 15;
            label1.Text = "Please Complete this form to add a Material Received(donation) into the businesses database. Fields marked with * are required.\r\n\r\n";
            // 
            // gbxChooseSupplier
            // 
            gbxChooseSupplier.Controls.Add(txtSupplierPhone);
            gbxChooseSupplier.Controls.Add(txtSupplierEmail);
            gbxChooseSupplier.Controls.Add(txtSupplierLName);
            gbxChooseSupplier.Controls.Add(txtSupplierFName);
            gbxChooseSupplier.Controls.Add(label11);
            gbxChooseSupplier.Controls.Add(label10);
            gbxChooseSupplier.Controls.Add(label6);
            gbxChooseSupplier.Controls.Add(label9);
            gbxChooseSupplier.Controls.Add(cmbSupplierID);
            gbxChooseSupplier.Controls.Add(label5);
            gbxChooseSupplier.Location = new Point(12, 95);
            gbxChooseSupplier.Name = "gbxChooseSupplier";
            gbxChooseSupplier.Size = new Size(376, 286);
            gbxChooseSupplier.TabIndex = 16;
            gbxChooseSupplier.TabStop = false;
            gbxChooseSupplier.Text = "* Section 1: Please select Supplier by their ID";
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(196, 238);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.ReadOnly = true;
            txtSupplierPhone.Size = new Size(151, 27);
            txtSupplierPhone.TabIndex = 15;
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Location = new Point(197, 194);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.ReadOnly = true;
            txtSupplierEmail.Size = new Size(150, 27);
            txtSupplierEmail.TabIndex = 14;
            // 
            // txtSupplierLName
            // 
            txtSupplierLName.Location = new Point(197, 142);
            txtSupplierLName.Name = "txtSupplierLName";
            txtSupplierLName.ReadOnly = true;
            txtSupplierLName.Size = new Size(150, 27);
            txtSupplierLName.TabIndex = 13;
            // 
            // txtSupplierFName
            // 
            txtSupplierFName.Location = new Point(197, 87);
            txtSupplierFName.Name = "txtSupplierFName";
            txtSupplierFName.ReadOnly = true;
            txtSupplierFName.Size = new Size(150, 27);
            txtSupplierFName.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 241);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 11;
            label11.Text = "Supplier Phone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 194);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 10;
            label10.Text = "Supplier Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 47);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 9;
            label6.Text = "Supplier ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 146);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 8;
            label9.Text = "Supplier Last Name:";
            // 
            // cmbSupplierID
            // 
            cmbSupplierID.FormattingEnabled = true;
            cmbSupplierID.Location = new Point(196, 39);
            cmbSupplierID.Name = "cmbSupplierID";
            cmbSupplierID.Size = new Size(151, 28);
            cmbSupplierID.TabIndex = 7;
            cmbSupplierID.SelectedIndexChanged += cmbSupplierID_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 94);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 5;
            label5.Text = "Supplier First Name:";
            // 
            // gbxConfirmSupplier
            // 
            gbxConfirmSupplier.Controls.Add(cbxConfirm);
            gbxConfirmSupplier.Location = new Point(846, 99);
            gbxConfirmSupplier.Name = "gbxConfirmSupplier";
            gbxConfirmSupplier.Size = new Size(324, 125);
            gbxConfirmSupplier.TabIndex = 17;
            gbxConfirmSupplier.TabStop = false;
            gbxConfirmSupplier.Text = "* Section 3: Confirm details";
            // 
            // cbxConfirm
            // 
            cbxConfirm.Location = new Point(5, 24);
            cbxConfirm.Name = "cbxConfirm";
            cbxConfirm.Size = new Size(241, 77);
            cbxConfirm.TabIndex = 1;
            cbxConfirm.Text = "I confirm that the information provided is correct.";
            cbxConfirm.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1060, 733);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(892, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMaterialReceived
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 785);
            Controls.Add(btnClear);
            Controls.Add(linkLabel1);
            Controls.Add(gbxConfirmSupplier);
            Controls.Add(gbxChooseSupplier);
            Controls.Add(btnReceive);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(dgvMaterialReceived);
            Controls.Add(gbxReceive);
            Controls.Add(lblHeading);
            Name = "frmMaterialReceived";
            Text = "frmMaterialReceived";
            WindowState = FormWindowState.Maximized;
            Load += frmMaterialReceived_Load;
            gbxReceive.ResumeLayout(false);
            gbxReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialReceived).EndInit();
            gbxChooseSupplier.ResumeLayout(false);
            gbxChooseSupplier.PerformLayout();
            gbxConfirmSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private GroupBox gbxReceive;
        private ComboBox cbxMaterialName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtWeight;
        private Label label7;
        private Label lblPriceOutPut;
        private DataGridView dgvMaterialReceived;
        private Button btnReceive;
        private LinkLabel linkLabel2;
        private Label label8;
        private DateTimePicker dtpDateReceived;
        private Label label1;
        private GroupBox gbxChooseSupplier;
        private Label label9;
        private ComboBox cmbSupplierID;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label6;
        private TextBox txtSupplierPhone;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierLName;
        private TextBox txtSupplierFName;
        private GroupBox gbxConfirmSupplier;
        private CheckBox cbxConfirm;
        private LinkLabel linkLabel1;
        private Button btnClear;
        private ErrorProvider errorProvider1;
        private TextBox txtPricePaid;
    }
}