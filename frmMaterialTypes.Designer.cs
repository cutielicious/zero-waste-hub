namespace Group20_Project
{
    partial class frmMaterialTypes
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
            gbxConfirmAdd = new GroupBox();
            cbxAddConfirm = new CheckBox();
            btnAddClear = new Button();
            pictureBox1 = new PictureBox();
            dgvAddMaterialType = new DataGridView();
            btnAddMaterialType = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtAddMaterialType = new TextBox();
            txtSellingPrice = new TextBox();
            txtQtyHand = new TextBox();
            txtPricekg = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            tabPage2 = new TabPage();
            btnTypeUpdateClear = new Button();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            cbxConfirmUpdate = new CheckBox();
            groupBox3 = new GroupBox();
            txtUpdateQtyHand = new TextBox();
            txtUpdateSellingPrice = new TextBox();
            txtUpdatePricePkg = new TextBox();
            txtUpdateMaterialName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cmbMaterialID = new ComboBox();
            groupBox2 = new GroupBox();
            cbxQtyHand = new CheckBox();
            cbxSellingPrice = new CheckBox();
            cbxPricePkg = new CheckBox();
            cbxMaterialName = new CheckBox();
            btnUpdateMaterialType = new Button();
            dgvUpdateMaterials = new DataGridView();
            linkLabel1 = new LinkLabel();
            tabPage3 = new TabPage();
            label16 = new Label();
            groupBox6 = new GroupBox();
            cbxDeleteConfirm = new CheckBox();
            btnClear = new Button();
            dgvDeleteMaterial = new DataGridView();
            btnDeleteMaterial = new Button();
            label17 = new Label();
            groupBox5 = new GroupBox();
            cmbDeleteMaterial = new ComboBox();
            label14 = new Label();
            txtDeleteMaterialName = new TextBox();
            label15 = new Label();
            linkLabel3 = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbxConfirmAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddMaterialType).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateMaterials).BeginInit();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteMaterial).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(8, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1095, 742);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gbxConfirmAdd);
            tabPage1.Controls.Add(btnAddClear);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(dgvAddMaterialType);
            tabPage1.Controls.Add(btnAddMaterialType);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(linkLabel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1087, 709);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxConfirmAdd
            // 
            gbxConfirmAdd.Controls.Add(cbxAddConfirm);
            gbxConfirmAdd.Location = new Point(396, 126);
            gbxConfirmAdd.Name = "gbxConfirmAdd";
            gbxConfirmAdd.Size = new Size(267, 125);
            gbxConfirmAdd.TabIndex = 19;
            gbxConfirmAdd.TabStop = false;
            gbxConfirmAdd.Text = "* Section 2: Confirm Changes";
            // 
            // cbxAddConfirm
            // 
            cbxAddConfirm.Location = new Point(22, 31);
            cbxAddConfirm.Name = "cbxAddConfirm";
            cbxAddConfirm.Size = new Size(245, 63);
            cbxAddConfirm.TabIndex = 0;
            cbxAddConfirm.Text = "I confirm that the information provided is correct.";
            cbxAddConfirm.UseVisualStyleBackColor = true;
            // 
            // btnAddClear
            // 
            btnAddClear.Location = new Point(465, 338);
            btnAddClear.Name = "btnAddClear";
            btnAddClear.Size = new Size(130, 58);
            btnAddClear.TabIndex = 18;
            btnAddClear.Text = "Clear";
            btnAddClear.UseVisualStyleBackColor = true;
            btnAddClear.Click += btnAddClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(685, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dgvAddMaterialType
            // 
            dgvAddMaterialType.BackgroundColor = Color.LightGreen;
            dgvAddMaterialType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddMaterialType.Location = new Point(29, 418);
            dgvAddMaterialType.Name = "dgvAddMaterialType";
            dgvAddMaterialType.RowHeadersWidth = 51;
            dgvAddMaterialType.Size = new Size(662, 188);
            dgvAddMaterialType.TabIndex = 12;
            // 
            // btnAddMaterialType
            // 
            btnAddMaterialType.Location = new Point(465, 262);
            btnAddMaterialType.Name = "btnAddMaterialType";
            btnAddMaterialType.Size = new Size(130, 58);
            btnAddMaterialType.TabIndex = 4;
            btnAddMaterialType.Text = "Add";
            btnAddMaterialType.UseVisualStyleBackColor = true;
            btnAddMaterialType.Click += btnAddMaterialType_Click;
            // 
            // label2
            // 
            label2.Location = new Point(29, 56);
            label2.Name = "label2";
            label2.Size = new Size(327, 62);
            label2.TabIndex = 11;
            label2.Text = "Complete this form to add a Material Type in the business. Fielda marked with * are required.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 10;
            label1.Text = "Add Material Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddMaterialType);
            groupBox1.Controls.Add(txtSellingPrice);
            groupBox1.Controls.Add(txtQtyHand);
            groupBox1.Controls.Add(txtPricekg);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 247);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Section 1: Add Material Type";
            // 
            // txtAddMaterialType
            // 
            txtAddMaterialType.Location = new Point(179, 48);
            txtAddMaterialType.Name = "txtAddMaterialType";
            txtAddMaterialType.Size = new Size(125, 27);
            txtAddMaterialType.TabIndex = 9;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(179, 172);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(125, 27);
            txtSellingPrice.TabIndex = 8;
            // 
            // txtQtyHand
            // 
            txtQtyHand.Location = new Point(179, 94);
            txtQtyHand.Name = "txtQtyHand";
            txtQtyHand.Size = new Size(125, 27);
            txtQtyHand.TabIndex = 7;
            // 
            // txtPricekg
            // 
            txtPricekg.Location = new Point(179, 134);
            txtPricekg.Name = "txtPricekg";
            txtPricekg.Size = new Size(125, 27);
            txtPricekg.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 175);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 3;
            label6.Text = "Selling Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 97);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 2;
            label5.Text = "Quantity on Hand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 134);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "Price p/kg:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 48);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 0;
            label3.Text = "Material Name:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(870, 665);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnTypeUpdateClear);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(btnUpdateMaterialType);
            tabPage2.Controls.Add(dgvUpdateMaterials);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1087, 709);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTypeUpdateClear
            // 
            btnTypeUpdateClear.Location = new Point(761, 341);
            btnTypeUpdateClear.Name = "btnTypeUpdateClear";
            btnTypeUpdateClear.Size = new Size(130, 58);
            btnTypeUpdateClear.TabIndex = 18;
            btnTypeUpdateClear.Text = "Clear";
            btnTypeUpdateClear.UseVisualStyleBackColor = true;
            btnTypeUpdateClear.Click += btnTypeUpdateClear_Click;
            // 
            // label8
            // 
            label8.Location = new Point(53, 44);
            label8.Name = "label8";
            label8.Size = new Size(489, 51);
            label8.TabIndex = 15;
            label8.Text = "Please select the information you would like to update. Fields you do not change will remain the same. Fields marked with * are required.\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(53, 13);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 14;
            label7.Text = "Update Material Type";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxConfirmUpdate);
            groupBox4.Location = new Point(677, 131);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(287, 115);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "* Section 3: Confirm Changes";
            // 
            // cbxConfirmUpdate
            // 
            cbxConfirmUpdate.Location = new Point(20, 26);
            cbxConfirmUpdate.Name = "cbxConfirmUpdate";
            cbxConfirmUpdate.Size = new Size(241, 77);
            cbxConfirmUpdate.TabIndex = 0;
            cbxConfirmUpdate.Text = "I confirm that the information provided is correct.";
            cbxConfirmUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtUpdateQtyHand);
            groupBox3.Controls.Add(txtUpdateSellingPrice);
            groupBox3.Controls.Add(txtUpdatePricePkg);
            groupBox3.Controls.Add(txtUpdateMaterialName);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbMaterialID);
            groupBox3.Location = new Point(341, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 255);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "* Section 2: Search && Update information";
            // 
            // txtUpdateQtyHand
            // 
            txtUpdateQtyHand.Location = new Point(161, 133);
            txtUpdateQtyHand.Name = "txtUpdateQtyHand";
            txtUpdateQtyHand.ReadOnly = true;
            txtUpdateQtyHand.Size = new Size(125, 27);
            txtUpdateQtyHand.TabIndex = 9;
            // 
            // txtUpdateSellingPrice
            // 
            txtUpdateSellingPrice.Location = new Point(161, 214);
            txtUpdateSellingPrice.Name = "txtUpdateSellingPrice";
            txtUpdateSellingPrice.ReadOnly = true;
            txtUpdateSellingPrice.Size = new Size(125, 27);
            txtUpdateSellingPrice.TabIndex = 8;
            // 
            // txtUpdatePricePkg
            // 
            txtUpdatePricePkg.Location = new Point(161, 174);
            txtUpdatePricePkg.Name = "txtUpdatePricePkg";
            txtUpdatePricePkg.ReadOnly = true;
            txtUpdatePricePkg.Size = new Size(125, 27);
            txtUpdatePricePkg.TabIndex = 7;
            // 
            // txtUpdateMaterialName
            // 
            txtUpdateMaterialName.Location = new Point(163, 88);
            txtUpdateMaterialName.Name = "txtUpdateMaterialName";
            txtUpdateMaterialName.ReadOnly = true;
            txtUpdateMaterialName.Size = new Size(125, 27);
            txtUpdateMaterialName.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 217);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 5;
            label13.Text = "Selling Price:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 136);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 4;
            label12.Text = "Quantity on Hand:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 177);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 3;
            label11.Text = "Price p/kg:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 91);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 2;
            label10.Text = "Material Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 43);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 1;
            label9.Text = "Material Type ID:";
            // 
            // cmbMaterialID
            // 
            cmbMaterialID.FormattingEnabled = true;
            cmbMaterialID.Location = new Point(161, 38);
            cmbMaterialID.Name = "cmbMaterialID";
            cmbMaterialID.Size = new Size(106, 28);
            cmbMaterialID.TabIndex = 0;
            cmbMaterialID.SelectedIndexChanged += cmbMaterialID_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxQtyHand);
            groupBox2.Controls.Add(cbxSellingPrice);
            groupBox2.Controls.Add(cbxPricePkg);
            groupBox2.Controls.Add(cbxMaterialName);
            groupBox2.Location = new Point(53, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 255);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "* Section 1: Choose what to update";
            // 
            // cbxQtyHand
            // 
            cbxQtyHand.AutoSize = true;
            cbxQtyHand.Location = new Point(28, 195);
            cbxQtyHand.Name = "cbxQtyHand";
            cbxQtyHand.Size = new Size(148, 24);
            cbxQtyHand.TabIndex = 3;
            cbxQtyHand.Text = "Quantity on Hand";
            cbxQtyHand.UseVisualStyleBackColor = true;
            cbxQtyHand.CheckedChanged += cbxQtyHand_CheckedChanged;
            // 
            // cbxSellingPrice
            // 
            cbxSellingPrice.AutoSize = true;
            cbxSellingPrice.Location = new Point(28, 145);
            cbxSellingPrice.Name = "cbxSellingPrice";
            cbxSellingPrice.Size = new Size(112, 24);
            cbxSellingPrice.TabIndex = 2;
            cbxSellingPrice.Text = "Selling Price";
            cbxSellingPrice.UseVisualStyleBackColor = true;
            cbxSellingPrice.CheckedChanged += cbxSellingPrice_CheckedChanged;
            // 
            // cbxPricePkg
            // 
            cbxPricePkg.AutoSize = true;
            cbxPricePkg.Location = new Point(27, 95);
            cbxPricePkg.Name = "cbxPricePkg";
            cbxPricePkg.Size = new Size(98, 24);
            cbxPricePkg.TabIndex = 1;
            cbxPricePkg.Text = "Price p/kg";
            cbxPricePkg.UseVisualStyleBackColor = true;
            cbxPricePkg.CheckedChanged += cbxPricePkg_CheckedChanged;
            // 
            // cbxMaterialName
            // 
            cbxMaterialName.AutoSize = true;
            cbxMaterialName.Location = new Point(28, 42);
            cbxMaterialName.Name = "cbxMaterialName";
            cbxMaterialName.Size = new Size(130, 24);
            cbxMaterialName.TabIndex = 0;
            cbxMaterialName.Text = "Material Name";
            cbxMaterialName.UseVisualStyleBackColor = true;
            cbxMaterialName.CheckedChanged += cbxMaterialName_CheckedChanged;
            // 
            // btnUpdateMaterialType
            // 
            btnUpdateMaterialType.Location = new Point(761, 263);
            btnUpdateMaterialType.Name = "btnUpdateMaterialType";
            btnUpdateMaterialType.Size = new Size(130, 58);
            btnUpdateMaterialType.TabIndex = 10;
            btnUpdateMaterialType.Text = "Update";
            btnUpdateMaterialType.UseVisualStyleBackColor = true;
            btnUpdateMaterialType.Click += btnUpdateMaterialType_Click;
            // 
            // dgvUpdateMaterials
            // 
            dgvUpdateMaterials.BackgroundColor = Color.LightGreen;
            dgvUpdateMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateMaterials.Location = new Point(38, 443);
            dgvUpdateMaterials.Name = "dgvUpdateMaterials";
            dgvUpdateMaterials.RowHeadersWidth = 51;
            dgvUpdateMaterials.Size = new Size(640, 192);
            dgvUpdateMaterials.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(965, 564);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(btnClear);
            tabPage3.Controls.Add(dgvDeleteMaterial);
            tabPage3.Controls.Add(btnDeleteMaterial);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Controls.Add(linkLabel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1087, 709);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.Location = new Point(47, 65);
            label16.Name = "label16";
            label16.Size = new Size(489, 51);
            label16.TabIndex = 22;
            label16.Text = "Please select the information you would like to delete. Fields marked with * are required.\r\n";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cbxDeleteConfirm);
            groupBox6.Location = new Point(421, 137);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(287, 152);
            groupBox6.TabIndex = 21;
            groupBox6.TabStop = false;
            groupBox6.Text = "* Section 2: Confirm Changes";
            // 
            // cbxDeleteConfirm
            // 
            cbxDeleteConfirm.Location = new Point(25, 42);
            cbxDeleteConfirm.Name = "cbxDeleteConfirm";
            cbxDeleteConfirm.Size = new Size(241, 77);
            cbxDeleteConfirm.TabIndex = 0;
            cbxDeleteConfirm.Text = "I confirm that the information provided is correct.";
            cbxDeleteConfirm.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(769, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvDeleteMaterial
            // 
            dgvDeleteMaterial.BackgroundColor = Color.LightGreen;
            dgvDeleteMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteMaterial.Location = new Point(47, 335);
            dgvDeleteMaterial.Name = "dgvDeleteMaterial";
            dgvDeleteMaterial.RowHeadersWidth = 51;
            dgvDeleteMaterial.Size = new Size(661, 190);
            dgvDeleteMaterial.TabIndex = 19;
            // 
            // btnDeleteMaterial
            // 
            btnDeleteMaterial.Location = new Point(769, 137);
            btnDeleteMaterial.Name = "btnDeleteMaterial";
            btnDeleteMaterial.Size = new Size(130, 58);
            btnDeleteMaterial.TabIndex = 6;
            btnDeleteMaterial.Text = "Delete";
            btnDeleteMaterial.UseVisualStyleBackColor = true;
            btnDeleteMaterial.Click += btnDeleteMaterial_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(47, 33);
            label17.Name = "label17";
            label17.Size = new Size(153, 20);
            label17.TabIndex = 11;
            label17.Text = "Delete Material Type";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cmbDeleteMaterial);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtDeleteMaterialName);
            groupBox5.Controls.Add(label15);
            groupBox5.Location = new Point(47, 137);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(346, 158);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "* Section 1: Delete Material Type";
            // 
            // cmbDeleteMaterial
            // 
            cmbDeleteMaterial.FormattingEnabled = true;
            cmbDeleteMaterial.Location = new Point(176, 53);
            cmbDeleteMaterial.Name = "cmbDeleteMaterial";
            cmbDeleteMaterial.Size = new Size(67, 28);
            cmbDeleteMaterial.TabIndex = 0;
            cmbDeleteMaterial.SelectedIndexChanged += cmbDeleteMaterial_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 61);
            label14.Name = "label14";
            label14.Size = new Size(121, 20);
            label14.TabIndex = 1;
            label14.Text = "Material Type ID:";
            // 
            // txtDeleteMaterialName
            // 
            txtDeleteMaterialName.Location = new Point(176, 108);
            txtDeleteMaterialName.Name = "txtDeleteMaterialName";
            txtDeleteMaterialName.ReadOnly = true;
            txtDeleteMaterialName.Size = new Size(125, 27);
            txtDeleteMaterialName.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 108);
            label15.Name = "label15";
            label15.Size = new Size(111, 20);
            label15.TabIndex = 4;
            label15.Text = "Material Name:";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(924, 617);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(123, 20);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Go to HomePage";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMaterialTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 785);
            Controls.Add(tabControl1);
            Name = "frmMaterialTypes";
            Text = "frmMaterialTypes";
            WindowState = FormWindowState.Maximized;
            Load += frmMaterialTypes_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gbxConfirmAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddMaterialType).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateMaterials).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeleteMaterial).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private TabPage tabPage3;
        private LinkLabel linkLabel3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSellingPrice;
        private TextBox txtQtyHand;
        private TextBox txtPricekg;
        private Button btnAddMaterialType;
        private DataGridView dgvAddMaterialType;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnUpdateMaterialType;
        private DataGridView dgvUpdateMaterials;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private CheckBox cbxConfirmUpdate;
        private CheckBox cbxMaterialName;
        private CheckBox cbxQtyHand;
        private CheckBox cbxSellingPrice;
        private CheckBox cbxPricePkg;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cmbMaterialID;
        private Label label13;
        private TextBox txtUpdateQtyHand;
        private TextBox txtUpdateSellingPrice;
        private TextBox txtUpdatePricePkg;
        private TextBox txtUpdateMaterialName;
        private GroupBox groupBox5;
        private ComboBox cmbDeleteMaterial;
        private Label label14;
        private Button btnDeleteMaterial;
        private TextBox txtDeleteMaterialName;
        private Label label15;
        private Label label17;
        private Button btnAddClear;
        private Button btnTypeUpdateClear;
        private DataGridView dgvDeleteMaterial;
        private GroupBox gbxConfirmAdd;
        private CheckBox cbxAddConfirm;
        private Button btnClear;
        private Label label16;
        private GroupBox groupBox6;
        private CheckBox cbxDeleteConfirm;
        protected Button button1;
        private TextBox txtAddMaterialType;
        private ErrorProvider errorProvider1;
    }
}