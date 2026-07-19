namespace Group20_Project
{
    partial class frmSaleTransactionPerPeriod
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblStart = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblEndDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            gbxSort = new GroupBox();
            rdoQuantitySoldAsc = new RadioButton();
            rdoMaterialTypeArrZA = new RadioButton();
            rdoQuantityArr = new RadioButton();
            rdoMaterialTypeName = new RadioButton();
            lblHeading = new Label();
            btnShow = new Button();
            dgvSalePerPeriod = new DataGridView();
            linkLabel2 = new LinkLabel();
            gbxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalePerPeriod).BeginInit();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(14, 65);
            lblStart.Margin = new Padding(2, 0, 2, 0);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(79, 20);
            lblStart.TabIndex = 2;
            lblStart.Text = "Start Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 65);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(11, 120);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(97, 115);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // gbxSort
            // 
            gbxSort.Controls.Add(rdoQuantitySoldAsc);
            gbxSort.Controls.Add(rdoMaterialTypeArrZA);
            gbxSort.Controls.Add(rdoQuantityArr);
            gbxSort.Controls.Add(rdoMaterialTypeName);
            gbxSort.Location = new Point(18, 195);
            gbxSort.Margin = new Padding(2, 2, 2, 2);
            gbxSort.Name = "gbxSort";
            gbxSort.Padding = new Padding(2, 2, 2, 2);
            gbxSort.Size = new Size(329, 162);
            gbxSort.TabIndex = 7;
            gbxSort.TabStop = false;
            gbxSort.Text = "* Sort by:";
            // 
            // rdoQuantitySoldAsc
            // 
            rdoQuantitySoldAsc.AutoSize = true;
            rdoQuantitySoldAsc.Location = new Point(6, 91);
            rdoQuantitySoldAsc.Margin = new Padding(2, 2, 2, 2);
            rdoQuantitySoldAsc.Name = "rdoQuantitySoldAsc";
            rdoQuantitySoldAsc.Size = new Size(193, 24);
            rdoQuantitySoldAsc.TabIndex = 8;
            rdoQuantitySoldAsc.TabStop = true;
            rdoQuantitySoldAsc.Text = "Quantity Sold Ascending";
            rdoQuantitySoldAsc.UseVisualStyleBackColor = true;
            // 
            // rdoMaterialTypeArrZA
            // 
            rdoMaterialTypeArrZA.AutoSize = true;
            rdoMaterialTypeArrZA.Location = new Point(6, 63);
            rdoMaterialTypeArrZA.Margin = new Padding(2, 2, 2, 2);
            rdoMaterialTypeArrZA.Name = "rdoMaterialTypeArrZA";
            rdoMaterialTypeArrZA.Size = new Size(195, 24);
            rdoMaterialTypeArrZA.TabIndex = 9;
            rdoMaterialTypeArrZA.TabStop = true;
            rdoMaterialTypeArrZA.Text = "MaterialType Name(Z-A)";
            rdoMaterialTypeArrZA.UseVisualStyleBackColor = true;
            // 
            // rdoQuantityArr
            // 
            rdoQuantityArr.AutoSize = true;
            rdoQuantityArr.Location = new Point(6, 121);
            rdoQuantityArr.Margin = new Padding(2, 2, 2, 2);
            rdoQuantityArr.Name = "rdoQuantityArr";
            rdoQuantityArr.Size = new Size(202, 24);
            rdoQuantityArr.TabIndex = 1;
            rdoQuantityArr.TabStop = true;
            rdoQuantityArr.Text = "Quantity Sold Descending";
            rdoQuantityArr.UseVisualStyleBackColor = true;
            // 
            // rdoMaterialTypeName
            // 
            rdoMaterialTypeName.AutoSize = true;
            rdoMaterialTypeName.Location = new Point(6, 22);
            rdoMaterialTypeName.Margin = new Padding(2, 2, 2, 2);
            rdoMaterialTypeName.Name = "rdoMaterialTypeName";
            rdoMaterialTypeName.Size = new Size(195, 24);
            rdoMaterialTypeName.TabIndex = 0;
            rdoMaterialTypeName.TabStop = true;
            rdoMaterialTypeName.Text = "MaterialType Name(A-Z)";
            rdoMaterialTypeName.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            lblHeading.Font = new Font("Segoe UI", 15F);
            lblHeading.Location = new Point(380, 9);
            lblHeading.Margin = new Padding(2, 0, 2, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(435, 42);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Report On Sale Transcation Per Period";
            lblHeading.Click += lblHeading_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(112, 376);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvSalePerPeriod
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvSalePerPeriod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvSalePerPeriod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvSalePerPeriod.DefaultCellStyle = dataGridViewCellStyle11;
            dgvSalePerPeriod.Location = new Point(380, 65);
            dgvSalePerPeriod.Name = "dgvSalePerPeriod";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvSalePerPeriod.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvSalePerPeriod.RowHeadersWidth = 51;
            dgvSalePerPeriod.Size = new Size(634, 365);
            dgvSalePerPeriod.TabIndex = 10;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(964, 553);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // frmSaleTransactionPerPeriod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 598);
            Controls.Add(linkLabel2);
            Controls.Add(dgvSalePerPeriod);
            Controls.Add(btnShow);
            Controls.Add(lblHeading);
            Controls.Add(gbxSort);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblEndDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblStart);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmSaleTransactionPerPeriod";
            Text = "frmSaleTransactionPerPeriod";
            gbxSort.ResumeLayout(false);
            gbxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalePerPeriod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStart;
        private DateTimePicker dateTimePicker1;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker2;
        private GroupBox gbxSort;
        private RadioButton rdoQuantitySoldAsc;
        private RadioButton rdoMaterialTypeArrZA;
        private RadioButton rdoQuantityArr;
        private RadioButton rdoMaterialTypeName;
        private Label lblHeading;
        private Button btnShow;
        private DataGridView dgvSalePerPeriod;
        private LinkLabel linkLabel2;
    }
}