namespace Group20_Project
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox7 = new GroupBox();
            cbxConfirmAdd = new CheckBox();
            btnClear = new Button();
            btnAddSupplier = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cbxAgreement = new CheckBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSupplierPhone = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvAddSupplier = new DataGridView();
            tabPage2 = new TabPage();
            btnSuppliersClear = new Button();
            dgvUpdateSupplier = new DataGridView();
            linkLabel2 = new LinkLabel();
            btnUpdate = new Button();
            groupBox4 = new GroupBox();
            cbxConfirmUpdate = new CheckBox();
            groupBox3 = new GroupBox();
            mtbPhoneNumber = new MaskedTextBox();
            label13 = new Label();
            cmbUpdateSupplier = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtUpdateEmail = new TextBox();
            txtUpdateLastName = new TextBox();
            txtUpdateName = new TextBox();
            groupBox2 = new GroupBox();
            cbxPhoneNumber = new CheckBox();
            cbxEmailAddress = new CheckBox();
            cbxLastName = new CheckBox();
            cbxName = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            tabPage3 = new TabPage();
            groupBox6 = new GroupBox();
            cbxConfirmDelete = new CheckBox();
            label18 = new Label();
            btnDeleteSupplier = new Button();
            dgvDeleteSupplier = new DataGridView();
            btnDeleteClear = new Button();
            linkLabel3 = new LinkLabel();
            groupBox5 = new GroupBox();
            cmbDeleteSupplier = new ComboBox();
            label14 = new Label();
            txtDeleteName = new TextBox();
            txtDeleteLastName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label17 = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddSupplier).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateSupplier).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteSupplier).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1324, 766);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnAddSupplier);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvAddSupplier);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1316, 733);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbxConfirmAdd);
            groupBox7.Location = new Point(483, 135);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(346, 125);
            groupBox7.TabIndex = 18;
            groupBox7.TabStop = false;
            groupBox7.Text = "* Section 2: Confirm Changes";
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
            // btnClear
            // 
            btnClear.Location = new Point(539, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(539, 276);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(130, 58);
            btnAddSupplier.TabIndex = 3;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(936, 693);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Location = new Point(40, 53);
            label2.Name = "label2";
            label2.Size = new Size(517, 59);
            label2.TabIndex = 5;
            label2.Text = "Complete this form to add a supplier to the database. Their details will be valuable for future transactions. Fields marked with * are required.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 4;
            label1.Text = "Sign Up Supplier";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1031, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 149);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxAgreement);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtSupplierPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(40, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Section 1: Add supplier to database";
            // 
            // cbxAgreement
            // 
            cbxAgreement.Font = new Font("Segoe UI", 7F);
            cbxAgreement.Location = new Point(37, 263);
            cbxAgreement.Name = "cbxAgreement";
            cbxAgreement.Size = new Size(313, 61);
            cbxAgreement.TabIndex = 8;
            cbxAgreement.Text = "The supplier agreed to the terms and conditions including the processing of their personal data.";
            cbxAgreement.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(175, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Window;
            txtFirstName.Location = new Point(175, 41);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(175, 178);
            txtSupplierPhone.Mask = "0#########";
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(175, 27);
            txtSupplierPhone.TabIndex = 4;
            txtSupplierPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtSupplierPhone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            txtSupplierPhone.TextChanged += txtSupplierPhone_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 181);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 3;
            label6.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 130);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 87);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 1;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 41);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "First Name:";
            // 
            // dgvAddSupplier
            // 
            dgvAddSupplier.BackgroundColor = Color.LightGreen;
            dgvAddSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddSupplier.Location = new Point(40, 507);
            dgvAddSupplier.Name = "dgvAddSupplier";
            dgvAddSupplier.RowHeadersWidth = 51;
            dgvAddSupplier.Size = new Size(718, 188);
            dgvAddSupplier.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSuppliersClear);
            tabPage2.Controls.Add(dgvUpdateSupplier);
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(btnUpdate);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1316, 733);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSuppliersClear
            // 
            btnSuppliersClear.Location = new Point(791, 387);
            btnSuppliersClear.Name = "btnSuppliersClear";
            btnSuppliersClear.Size = new Size(130, 58);
            btnSuppliersClear.TabIndex = 17;
            btnSuppliersClear.Text = "Clear";
            btnSuppliersClear.UseVisualStyleBackColor = true;
            btnSuppliersClear.Click += btnSuppliersClear_Click;
            // 
            // dgvUpdateSupplier
            // 
            dgvUpdateSupplier.BackgroundColor = Color.LightGreen;
            dgvUpdateSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateSupplier.Location = new Point(54, 372);
            dgvUpdateSupplier.Name = "dgvUpdateSupplier";
            dgvUpdateSupplier.RowHeadersWidth = 51;
            dgvUpdateSupplier.Size = new Size(640, 167);
            dgvUpdateSupplier.TabIndex = 8;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(935, 496);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(791, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 58);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxConfirmUpdate);
            groupBox4.Location = new Point(742, 131);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(332, 125);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "* Section 3: Confirm Changes";
            // 
            // cbxConfirmUpdate
            // 
            cbxConfirmUpdate.Location = new Point(22, 31);
            cbxConfirmUpdate.Name = "cbxConfirmUpdate";
            cbxConfirmUpdate.Size = new Size(245, 63);
            cbxConfirmUpdate.TabIndex = 0;
            cbxConfirmUpdate.Text = "I confirm that the information provided is correct.";
            cbxConfirmUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(mtbPhoneNumber);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cmbUpdateSupplier);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtUpdateEmail);
            groupBox3.Controls.Add(txtUpdateLastName);
            groupBox3.Controls.Add(txtUpdateName);
            groupBox3.Location = new Point(354, 124);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 230);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "* Section 2: Search && Update information";
            // 
            // mtbPhoneNumber
            // 
            mtbPhoneNumber.Location = new Point(173, 184);
            mtbPhoneNumber.Mask = "0#########";
            mtbPhoneNumber.Name = "mtbPhoneNumber";
            mtbPhoneNumber.ReadOnly = true;
            mtbPhoneNumber.Size = new Size(149, 27);
            mtbPhoneNumber.TabIndex = 10;
            mtbPhoneNumber.MaskInputRejected += mtbPhoneNumber_MaskInputRejected;
            mtbPhoneNumber.TextChanged += mtbPhoneNumber_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 39);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 9;
            label13.Text = "Search Supplier:";
            // 
            // cmbUpdateSupplier
            // 
            cmbUpdateSupplier.FormattingEnabled = true;
            cmbUpdateSupplier.Location = new Point(171, 26);
            cmbUpdateSupplier.Name = "cmbUpdateSupplier";
            cmbUpdateSupplier.Size = new Size(67, 28);
            cmbUpdateSupplier.TabIndex = 8;
            cmbUpdateSupplier.SelectedIndexChanged += cmbUpdateSupplier_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 182);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 7;
            label12.Text = "Phone Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 145);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 6;
            label11.Text = "Email Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 67);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 5;
            label10.Text = "Last Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 112);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 4;
            label9.Text = "First Name:";
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(171, 145);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.ReadOnly = true;
            txtUpdateEmail.Size = new Size(151, 27);
            txtUpdateEmail.TabIndex = 2;
            // 
            // txtUpdateLastName
            // 
            txtUpdateLastName.Location = new Point(171, 60);
            txtUpdateLastName.Name = "txtUpdateLastName";
            txtUpdateLastName.ReadOnly = true;
            txtUpdateLastName.Size = new Size(151, 27);
            txtUpdateLastName.TabIndex = 1;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(171, 105);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.ReadOnly = true;
            txtUpdateName.Size = new Size(151, 27);
            txtUpdateName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxPhoneNumber);
            groupBox2.Controls.Add(cbxEmailAddress);
            groupBox2.Controls.Add(cbxLastName);
            groupBox2.Controls.Add(cbxName);
            groupBox2.Location = new Point(54, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 211);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "* Section 1: Choose what to update";
            // 
            // cbxPhoneNumber
            // 
            cbxPhoneNumber.AutoSize = true;
            cbxPhoneNumber.Location = new Point(25, 167);
            cbxPhoneNumber.Name = "cbxPhoneNumber";
            cbxPhoneNumber.Size = new Size(130, 24);
            cbxPhoneNumber.TabIndex = 3;
            cbxPhoneNumber.Text = "Phone Number";
            cbxPhoneNumber.UseVisualStyleBackColor = true;
            cbxPhoneNumber.CheckedChanged += cbxPhoneNumber_CheckedChanged;
            // 
            // cbxEmailAddress
            // 
            cbxEmailAddress.AutoSize = true;
            cbxEmailAddress.Location = new Point(25, 122);
            cbxEmailAddress.Name = "cbxEmailAddress";
            cbxEmailAddress.Size = new Size(125, 24);
            cbxEmailAddress.TabIndex = 2;
            cbxEmailAddress.Text = "Email Address";
            cbxEmailAddress.UseVisualStyleBackColor = true;
            cbxEmailAddress.CheckedChanged += cbxEmailAddress_CheckedChanged;
            // 
            // cbxLastName
            // 
            cbxLastName.AutoSize = true;
            cbxLastName.Location = new Point(25, 79);
            cbxLastName.Name = "cbxLastName";
            cbxLastName.Size = new Size(97, 24);
            cbxLastName.TabIndex = 1;
            cbxLastName.Text = "LastName";
            cbxLastName.UseVisualStyleBackColor = true;
            cbxLastName.CheckedChanged += cbxLastName_CheckedChanged;
            // 
            // cbxName
            // 
            cbxName.AutoSize = true;
            cbxName.Location = new Point(25, 38);
            cbxName.Name = "cbxName";
            cbxName.Size = new Size(71, 24);
            cbxName.TabIndex = 0;
            cbxName.Text = "Name";
            cbxName.UseVisualStyleBackColor = true;
            cbxName.CheckedChanged += cbxName_CheckedChanged;
            // 
            // label8
            // 
            label8.Location = new Point(54, 62);
            label8.Name = "label8";
            label8.Size = new Size(723, 66);
            label8.TabIndex = 1;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(54, 21);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 0;
            label7.Text = "Update Supplier";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(btnDeleteSupplier);
            tabPage3.Controls.Add(dgvDeleteSupplier);
            tabPage3.Controls.Add(btnDeleteClear);
            tabPage3.Controls.Add(linkLabel3);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Controls.Add(label17);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1316, 733);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cbxConfirmDelete);
            groupBox6.Location = new Point(419, 155);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(331, 125);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "* Section 2: Confirm Changes";
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
            // label18
            // 
            label18.Location = new Point(37, 63);
            label18.Name = "label18";
            label18.Size = new Size(413, 48);
            label18.TabIndex = 19;
            label18.Text = "Please search for the supplier you wish to delete from databse. Fields marked with * are required.";
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(441, 304);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(130, 58);
            btnDeleteSupplier.TabIndex = 6;
            btnDeleteSupplier.Text = "Delete";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // dgvDeleteSupplier
            // 
            dgvDeleteSupplier.BackgroundColor = Color.LightGreen;
            dgvDeleteSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteSupplier.Location = new Point(37, 431);
            dgvDeleteSupplier.Name = "dgvDeleteSupplier";
            dgvDeleteSupplier.RowHeadersWidth = 51;
            dgvDeleteSupplier.Size = new Size(649, 207);
            dgvDeleteSupplier.TabIndex = 18;
            // 
            // btnDeleteClear
            // 
            btnDeleteClear.Location = new Point(441, 368);
            btnDeleteClear.Name = "btnDeleteClear";
            btnDeleteClear.Size = new Size(130, 58);
            btnDeleteClear.TabIndex = 17;
            btnDeleteClear.Text = "Clear";
            btnDeleteClear.UseVisualStyleBackColor = true;
            btnDeleteClear.Click += btnDeleteClear_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(986, 688);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(123, 20);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Go to HomePage";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cmbDeleteSupplier);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtDeleteName);
            groupBox5.Controls.Add(txtDeleteLastName);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Location = new Point(37, 144);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(344, 187);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "* Section 1: Delete Supplier from database";
            // 
            // cmbDeleteSupplier
            // 
            cmbDeleteSupplier.FormattingEnabled = true;
            cmbDeleteSupplier.Location = new Point(176, 42);
            cmbDeleteSupplier.Name = "cmbDeleteSupplier";
            cmbDeleteSupplier.Size = new Size(67, 28);
            cmbDeleteSupplier.TabIndex = 0;
            cmbDeleteSupplier.SelectedIndexChanged += cmbDeleteSupplier_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 50);
            label14.Name = "label14";
            label14.Size = new Size(115, 20);
            label14.TabIndex = 1;
            label14.Text = "Search Supplier:";
            // 
            // txtDeleteName
            // 
            txtDeleteName.Enabled = false;
            txtDeleteName.Location = new Point(176, 84);
            txtDeleteName.Name = "txtDeleteName";
            txtDeleteName.Size = new Size(125, 27);
            txtDeleteName.TabIndex = 2;
            // 
            // txtDeleteLastName
            // 
            txtDeleteLastName.Enabled = false;
            txtDeleteLastName.Location = new Point(176, 123);
            txtDeleteLastName.Name = "txtDeleteLastName";
            txtDeleteLastName.Size = new Size(125, 27);
            txtDeleteLastName.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 126);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 5;
            label16.Text = "Last Name:";
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(42, 26);
            label17.Name = "label17";
            label17.Size = new Size(115, 20);
            label17.TabIndex = 7;
            label17.Text = "Delete Supplier";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 785);
            Controls.Add(tabControl1);
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            WindowState = FormWindowState.Maximized;
            Load += frmSuppliers_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddSupplier).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateSupplier).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeleteSupplier).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private Button btnAddSupplier;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dgvAddSupplier;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckBox cbxAgreement;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private MaskedTextBox txtSupplierPhone;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ToolTip toolTip1;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox cbxPhoneNumber;
        private CheckBox cbxEmailAddress;
        private CheckBox cbxLastName;
        private CheckBox cbxName;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdateLastName;
        private TextBox txtUpdateName;
        private Label label13;
        private ComboBox cmbUpdateSupplier;
        private Button btnUpdate;
        private GroupBox groupBox4;
        private CheckBox cbxConfirmUpdate;
        private MaskedTextBox mtbPhoneNumber;
        private Button btnDeleteSupplier;
        private Label label16;
        private Label label15;
        private TextBox txtDeleteLastName;
        private TextBox txtDeleteName;
        private Label label14;
        private ComboBox cmbDeleteSupplier;
        private GroupBox groupBox5;
        private Label label17;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private DataGridView dgvUpdateSupplier;
        private Button btnClear;
        private Button btnSuppliersClear;
        private DataGridView dgvDeleteSupplier;
        private Button btnDeleteClear;
        private Label label18;
        private GroupBox groupBox6;
        private CheckBox cbxConfirmDelete;
        private GroupBox groupBox7;
        private CheckBox cbxConfirmAdd;
        private ErrorProvider errorProvider1;
    }
}