namespace Group20_Project
{
    partial class frmCustomers
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox6 = new GroupBox();
            cbxConfirmAdd = new CheckBox();
            btnAddClear = new Button();
            btnAddCustomer = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cbxCustomerAgreement = new CheckBox();
            txtCustomerEmail = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            dgvAddCustomers = new DataGridView();
            tabPage2 = new TabPage();
            btnUpdateClear = new Button();
            dgvUpdateCustomer = new DataGridView();
            linkLabel2 = new LinkLabel();
            btnUpdateCustomer = new Button();
            groupBox4 = new GroupBox();
            cbxCustomerConfirmUpdate = new CheckBox();
            groupBox3 = new GroupBox();
            mtbUpdateCellNumber = new MaskedTextBox();
            label13 = new Label();
            cmbCustomer = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtUpdateCustomerEmail = new TextBox();
            txtUpdateCustomerName = new TextBox();
            groupBox2 = new GroupBox();
            cbxCellNumber = new CheckBox();
            cbxCustomerEmailAddress = new CheckBox();
            cbxCustomerName = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            tabPage3 = new TabPage();
            label4 = new Label();
            btnDeleteClear = new Button();
            groupBox7 = new GroupBox();
            cbxConfirmDelete = new CheckBox();
            dgvDeleteCustomer = new DataGridView();
            linkLabel3 = new LinkLabel();
            groupBox5 = new GroupBox();
            cmbDeleteCustomer = new ComboBox();
            label14 = new Label();
            txtDeleteCustomerName = new TextBox();
            label15 = new Label();
            btnDeleteCustomer = new Button();
            label17 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddCustomers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateCustomer).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteCustomer).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1321, 761);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(btnAddClear);
            tabPage1.Controls.Add(btnAddCustomer);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvAddCustomers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1313, 728);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cbxConfirmAdd);
            groupBox6.Location = new Point(473, 141);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(366, 125);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "* Section 2: Confirm Changes";
            // 
            // cbxConfirmAdd
            // 
            cbxConfirmAdd.Location = new Point(22, 31);
            cbxConfirmAdd.Name = "cbxConfirmAdd";
            cbxConfirmAdd.Size = new Size(245, 63);
            cbxConfirmAdd.TabIndex = 0;
            cbxConfirmAdd.Text = "I confirm that the information provided is correct.";
            cbxConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddClear
            // 
            btnAddClear.Location = new Point(538, 364);
            btnAddClear.Name = "btnAddClear";
            btnAddClear.Size = new Size(130, 58);
            btnAddClear.TabIndex = 17;
            btnAddClear.Text = "Clear";
            btnAddClear.UseVisualStyleBackColor = true;
            btnAddClear.Click += btnAddClear_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(538, 286);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(130, 58);
            btnAddCustomer.TabIndex = 3;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(909, 689);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Location = new Point(40, 67);
            label2.Name = "label2";
            label2.Size = new Size(503, 59);
            label2.TabIndex = 5;
            label2.Text = "Complete this form to add a customer to the database. Their details will be valuable for future transactions. Fields marked with * are required.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 4;
            label1.Text = "Sign Up Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(768, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxCustomerAgreement);
            groupBox1.Controls.Add(txtCustomerEmail);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(40, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Section 1: Add customer to database";
            // 
            // cbxCustomerAgreement
            // 
            cbxCustomerAgreement.Font = new Font("Segoe UI", 7F);
            cbxCustomerAgreement.Location = new Point(37, 221);
            cbxCustomerAgreement.Name = "cbxCustomerAgreement";
            cbxCustomerAgreement.Size = new Size(313, 61);
            cbxCustomerAgreement.TabIndex = 8;
            cbxCustomerAgreement.Text = "The customer agreed to the terms and conditions including the processing of their personal data.";
            cbxCustomerAgreement.UseVisualStyleBackColor = true;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(175, 99);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(175, 27);
            txtCustomerEmail.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(175, 41);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(175, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(175, 159);
            txtCustomerPhone.Mask = "0#########";
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(175, 27);
            txtCustomerPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 166);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 3;
            label6.Text = "Cell Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 99);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 41);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // dgvAddCustomers
            // 
            dgvAddCustomers.BackgroundColor = Color.LightGreen;
            dgvAddCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddCustomers.Location = new Point(40, 498);
            dgvAddCustomers.Name = "dgvAddCustomers";
            dgvAddCustomers.RowHeadersWidth = 51;
            dgvAddCustomers.Size = new Size(712, 177);
            dgvAddCustomers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnUpdateClear);
            tabPage2.Controls.Add(dgvUpdateCustomer);
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(btnUpdateCustomer);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1313, 728);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClear
            // 
            btnUpdateClear.Location = new Point(787, 397);
            btnUpdateClear.Name = "btnUpdateClear";
            btnUpdateClear.Size = new Size(130, 58);
            btnUpdateClear.TabIndex = 17;
            btnUpdateClear.Text = "Clear";
            btnUpdateClear.UseVisualStyleBackColor = true;
            btnUpdateClear.Click += btnUpdateClear_Click;
            // 
            // dgvUpdateCustomer
            // 
            dgvUpdateCustomer.BackgroundColor = Color.LightGreen;
            dgvUpdateCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateCustomer.Location = new Point(54, 397);
            dgvUpdateCustomer.Name = "dgvUpdateCustomer";
            dgvUpdateCustomer.RowHeadersWidth = 51;
            dgvUpdateCustomer.Size = new Size(640, 167);
            dgvUpdateCustomer.TabIndex = 9;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(884, 582);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(787, 305);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(130, 58);
            btnUpdateCustomer.TabIndex = 5;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxCustomerConfirmUpdate);
            groupBox4.Location = new Point(740, 146);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(267, 125);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "* Section 3: Confirm Changes";
            // 
            // cbxCustomerConfirmUpdate
            // 
            cbxCustomerConfirmUpdate.Location = new Point(22, 31);
            cbxCustomerConfirmUpdate.Name = "cbxCustomerConfirmUpdate";
            cbxCustomerConfirmUpdate.Size = new Size(245, 63);
            cbxCustomerConfirmUpdate.TabIndex = 0;
            cbxCustomerConfirmUpdate.Text = "I confirm that the information provided is correct.";
            cbxCustomerConfirmUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(mtbUpdateCellNumber);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cmbCustomer);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtUpdateCustomerEmail);
            groupBox3.Controls.Add(txtUpdateCustomerName);
            groupBox3.Location = new Point(354, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 230);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "* Section 2: Search && Update information";
            // 
            // mtbUpdateCellNumber
            // 
            mtbUpdateCellNumber.Location = new Point(175, 159);
            mtbUpdateCellNumber.Mask = "0#########";
            mtbUpdateCellNumber.Name = "mtbUpdateCellNumber";
            mtbUpdateCellNumber.ReadOnly = true;
            mtbUpdateCellNumber.Size = new Size(149, 27);
            mtbUpdateCellNumber.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 34);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 9;
            label13.Text = "Search Customer:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(171, 26);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(98, 28);
            cmbCustomer.TabIndex = 8;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 166);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 7;
            label12.Text = "Cell Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 117);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 6;
            label11.Text = "Email Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 104);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 70);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 4;
            label9.Text = "Name:";
            // 
            // txtUpdateCustomerEmail
            // 
            txtUpdateCustomerEmail.Location = new Point(173, 114);
            txtUpdateCustomerEmail.Name = "txtUpdateCustomerEmail";
            txtUpdateCustomerEmail.ReadOnly = true;
            txtUpdateCustomerEmail.Size = new Size(151, 27);
            txtUpdateCustomerEmail.TabIndex = 2;
            // 
            // txtUpdateCustomerName
            // 
            txtUpdateCustomerName.Location = new Point(171, 67);
            txtUpdateCustomerName.Name = "txtUpdateCustomerName";
            txtUpdateCustomerName.ReadOnly = true;
            txtUpdateCustomerName.Size = new Size(151, 27);
            txtUpdateCustomerName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxCellNumber);
            groupBox2.Controls.Add(cbxCustomerEmailAddress);
            groupBox2.Controls.Add(cbxCustomerName);
            groupBox2.Location = new Point(22, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 230);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "* Section 1: Choose what details to update";
            // 
            // cbxCellNumber
            // 
            cbxCellNumber.AutoSize = true;
            cbxCellNumber.Location = new Point(25, 144);
            cbxCellNumber.Name = "cbxCellNumber";
            cbxCellNumber.Size = new Size(114, 24);
            cbxCellNumber.TabIndex = 3;
            cbxCellNumber.Text = "Cell Number";
            cbxCellNumber.UseVisualStyleBackColor = true;
            cbxCellNumber.CheckedChanged += cbxCellNumber_CheckedChanged;
            // 
            // cbxCustomerEmailAddress
            // 
            cbxCustomerEmailAddress.AutoSize = true;
            cbxCustomerEmailAddress.Location = new Point(25, 90);
            cbxCustomerEmailAddress.Name = "cbxCustomerEmailAddress";
            cbxCustomerEmailAddress.Size = new Size(125, 24);
            cbxCustomerEmailAddress.TabIndex = 2;
            cbxCustomerEmailAddress.Text = "Email Address";
            cbxCustomerEmailAddress.UseVisualStyleBackColor = true;
            cbxCustomerEmailAddress.CheckedChanged += cbxCustomerEmailAddress_CheckedChanged;
            // 
            // cbxCustomerName
            // 
            cbxCustomerName.AutoSize = true;
            cbxCustomerName.Location = new Point(25, 38);
            cbxCustomerName.Name = "cbxCustomerName";
            cbxCustomerName.Size = new Size(71, 24);
            cbxCustomerName.TabIndex = 0;
            cbxCustomerName.Text = "Name";
            cbxCustomerName.UseVisualStyleBackColor = true;
            cbxCustomerName.CheckedChanged += cbxCustomerName_CheckedChanged;
            // 
            // label8
            // 
            label8.Location = new Point(22, 51);
            label8.Name = "label8";
            label8.Size = new Size(477, 78);
            label8.TabIndex = 1;
            label8.Text = "Please select the information you would like to update. Fields you do not change will remain the same. Fields marked with * are required.\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(22, 22);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 0;
            label7.Text = "Update Customer";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(btnDeleteClear);
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Controls.Add(dgvDeleteCustomer);
            tabPage3.Controls.Add(linkLabel3);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Controls.Add(btnDeleteCustomer);
            tabPage3.Controls.Add(label17);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1313, 728);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(41, 63);
            label4.Name = "label4";
            label4.Size = new Size(503, 45);
            label4.TabIndex = 20;
            label4.Text = "Complete this form to delete a customer from the database. Fields marked with * are required.";
            // 
            // btnDeleteClear
            // 
            btnDeleteClear.Location = new Point(780, 382);
            btnDeleteClear.Name = "btnDeleteClear";
            btnDeleteClear.Size = new Size(130, 58);
            btnDeleteClear.TabIndex = 17;
            btnDeleteClear.Text = "Clear";
            btnDeleteClear.UseVisualStyleBackColor = true;
            btnDeleteClear.Click += btnDeleteClear_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbxConfirmDelete);
            groupBox7.Location = new Point(411, 141);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(372, 125);
            groupBox7.TabIndex = 19;
            groupBox7.TabStop = false;
            groupBox7.Text = "* Section 2: Confirm Changes";
            // 
            // cbxConfirmDelete
            // 
            cbxConfirmDelete.Location = new Point(22, 31);
            cbxConfirmDelete.Name = "cbxConfirmDelete";
            cbxConfirmDelete.Size = new Size(245, 63);
            cbxConfirmDelete.TabIndex = 0;
            cbxConfirmDelete.Text = "I confirm that the information provided is correct.";
            cbxConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // dgvDeleteCustomer
            // 
            dgvDeleteCustomer.BackgroundColor = Color.LightGreen;
            dgvDeleteCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteCustomer.Location = new Point(41, 308);
            dgvDeleteCustomer.Name = "dgvDeleteCustomer";
            dgvDeleteCustomer.RowHeadersWidth = 51;
            dgvDeleteCustomer.Size = new Size(710, 229);
            dgvDeleteCustomer.TabIndex = 18;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(810, 636);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(123, 20);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Go to HomePage";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cmbDeleteCustomer);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtDeleteCustomerName);
            groupBox5.Controls.Add(label15);
            groupBox5.Location = new Point(41, 132);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(344, 134);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "* Section 1: Delete Customer from database";
            // 
            // cmbDeleteCustomer
            // 
            cmbDeleteCustomer.FormattingEnabled = true;
            cmbDeleteCustomer.Location = new Point(176, 42);
            cmbDeleteCustomer.Name = "cmbDeleteCustomer";
            cmbDeleteCustomer.Size = new Size(67, 28);
            cmbDeleteCustomer.TabIndex = 0;
            cmbDeleteCustomer.SelectedIndexChanged += cmbDeleteCustomer_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 50);
            label14.Name = "label14";
            label14.Size = new Size(123, 20);
            label14.TabIndex = 1;
            label14.Text = "Search Customer:";
            // 
            // txtDeleteCustomerName
            // 
            txtDeleteCustomerName.Location = new Point(176, 84);
            txtDeleteCustomerName.Name = "txtDeleteCustomerName";
            txtDeleteCustomerName.ReadOnly = true;
            txtDeleteCustomerName.Size = new Size(125, 27);
            txtDeleteCustomerName.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 87);
            label15.Name = "label15";
            label15.Size = new Size(52, 20);
            label15.TabIndex = 4;
            label15.Text = "Name:";
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(780, 308);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(130, 58);
            btnDeleteCustomer.TabIndex = 6;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(41, 24);
            label17.Name = "label17";
            label17.Size = new Size(126, 20);
            label17.TabIndex = 7;
            label17.Text = "Delete Customer";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 785);
            Controls.Add(tabControl1);
            Name = "frmCustomers";
            Text = "Customers";
            WindowState = FormWindowState.Maximized;
            Load += frmCustomers_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddCustomers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateCustomer).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeleteCustomer).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private CheckBox cbxCustomerAgreement;
        private TextBox txtCustomerEmail;
        private Button btnAddCustomer;
        private TextBox txtCustomerName;
        private MaskedTextBox txtCustomerPhone;
        private Label label6;
        private Label label5;
        private Label label3;
        private DataGridView dgvAddCustomers;
        private TabPage tabPage2;
        private Button btnUpdateCustomer;
        private GroupBox groupBox4;
        private CheckBox cbxCustomerConfirmUpdate;
        private GroupBox groupBox3;
        private MaskedTextBox mtbUpdateCellNumber;
        private Label label13;
        private ComboBox cmbCustomer;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtUpdateCustomerEmail;
        private TextBox txtUpdateCustomerName;
        private GroupBox groupBox2;
        private CheckBox cbxCellNumber;
        private CheckBox cbxCustomerEmailAddress;
        private CheckBox cbxCustomerName;
        private Label label8;
        private Label label7;
        private TabPage tabPage3;
        private GroupBox groupBox5;
        private ComboBox cmbDeleteCustomer;
        private Label label14;
        private Button btnDeleteCustomer;
        private TextBox txtDeleteCustomerName;
        private Label label15;
        private Label label17;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private DataGridView dgvUpdateCustomer;
        private Button btnAddClear;
        private Button btnUpdateClear;
        private Button btnDeleteClear;
        private DataGridView dgvDeleteCustomer;
        private GroupBox groupBox6;
        private CheckBox cbxConfirmAdd;
        private GroupBox groupBox7;
        private CheckBox cbxConfirmDelete;
        private Label label4;
        private ErrorProvider errorProvider1;
    }
}