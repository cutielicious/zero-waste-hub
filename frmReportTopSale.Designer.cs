namespace Group20_Project
{
    partial class frmReportTopSale
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
            lblReportHeading = new Label();
            lblStart = new Label();
            lblEndDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            gbxSort = new GroupBox();
            rdoQuantitySoldAsc = new RadioButton();
            rdoMaterialTypeArrZA = new RadioButton();
            rdoQuantityArr = new RadioButton();
            rdoMaterialTypeName = new RadioButton();
            lblShow = new Button();
            dgvSoldMaterialType = new DataGridView();
            groupBox1 = new GroupBox();
            rdoBarChart = new RadioButton();
            rdoPieChart = new RadioButton();
            btnShow1 = new Button();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoldMaterialType).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblReportHeading
            // 
            lblReportHeading.AutoSize = true;
            lblReportHeading.Font = new Font("Segoe UI", 15F);
            lblReportHeading.Location = new Point(403, 9);
            lblReportHeading.Name = "lblReportHeading";
            lblReportHeading.Size = new Size(425, 35);
            lblReportHeading.TabIndex = 0;
            lblReportHeading.Text = "Top 10 Sold Material Type per period";
            lblReportHeading.Click += label1_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(12, 74);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(79, 20);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start Date:";
            lblStart.Click += label1_Click_1;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(12, 114);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "End Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(91, 109);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // gbxSort
            // 
            gbxSort.Controls.Add(rdoQuantitySoldAsc);
            gbxSort.Controls.Add(rdoMaterialTypeArrZA);
            gbxSort.Controls.Add(rdoQuantityArr);
            gbxSort.Controls.Add(rdoMaterialTypeName);
            gbxSort.Location = new Point(12, 169);
            gbxSort.Name = "gbxSort";
            gbxSort.Size = new Size(329, 162);
            gbxSort.TabIndex = 5;
            gbxSort.TabStop = false;
            gbxSort.Text = "* Sort by:";
            // 
            // rdoQuantitySoldAsc
            // 
            rdoQuantitySoldAsc.AutoSize = true;
            rdoQuantitySoldAsc.Location = new Point(6, 91);
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
            rdoMaterialTypeArrZA.Location = new Point(6, 53);
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
            rdoMaterialTypeName.Location = new Point(6, 23);
            rdoMaterialTypeName.Name = "rdoMaterialTypeName";
            rdoMaterialTypeName.Size = new Size(195, 24);
            rdoMaterialTypeName.TabIndex = 0;
            rdoMaterialTypeName.TabStop = true;
            rdoMaterialTypeName.Text = "MaterialType Name(A-Z)";
            rdoMaterialTypeName.UseVisualStyleBackColor = true;
            // 
            // lblShow
            // 
            lblShow.Location = new Point(117, 337);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(94, 29);
            lblShow.TabIndex = 6;
            lblShow.Text = "Show";
            lblShow.UseVisualStyleBackColor = true;
            // 
            // dgvSoldMaterialType
            // 
            dgvSoldMaterialType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoldMaterialType.Location = new Point(380, 69);
            dgvSoldMaterialType.Name = "dgvSoldMaterialType";
            dgvSoldMaterialType.RowHeadersWidth = 51;
            dgvSoldMaterialType.Size = new Size(929, 262);
            dgvSoldMaterialType.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBarChart);
            groupBox1.Controls.Add(rdoPieChart);
            groupBox1.Location = new Point(18, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 106);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose chart type:";
            // 
            // rdoBarChart
            // 
            rdoBarChart.AutoSize = true;
            rdoBarChart.Location = new Point(6, 69);
            rdoBarChart.Name = "rdoBarChart";
            rdoBarChart.Size = new Size(91, 24);
            rdoBarChart.TabIndex = 1;
            rdoBarChart.TabStop = true;
            rdoBarChart.Text = "Bar Chart";
            rdoBarChart.UseVisualStyleBackColor = true;
            // 
            // rdoPieChart
            // 
            rdoPieChart.AutoSize = true;
            rdoPieChart.Location = new Point(3, 23);
            rdoPieChart.Name = "rdoPieChart";
            rdoPieChart.Size = new Size(89, 24);
            rdoPieChart.TabIndex = 0;
            rdoPieChart.TabStop = true;
            rdoPieChart.Text = "Pie Chart";
            rdoPieChart.UseVisualStyleBackColor = true;
            // 
            // btnShow1
            // 
            btnShow1.Location = new Point(117, 514);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(94, 29);
            btnShow1.TabIndex = 9;
            btnShow1.Text = "Show";
            btnShow1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(380, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 236);
            panel1.TabIndex = 10;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(1159, 619);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // frmReportTopSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 661);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            Controls.Add(btnShow1);
            Controls.Add(groupBox1);
            Controls.Add(dgvSoldMaterialType);
            Controls.Add(lblShow);
            Controls.Add(gbxSort);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEndDate);
            Controls.Add(lblStart);
            Controls.Add(lblReportHeading);
            Name = "frmReportTopSale";
            Text = "frmReportTopSale";
            Load += frmReportTopSale_Load;
            gbxSort.ResumeLayout(false);
            gbxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoldMaterialType).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportHeading;
        private Label lblStart;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox gbxSort;
        private RadioButton rdoQuantityArr;
        private RadioButton rdoMaterialTypeName;
        private RadioButton rdoQuantitySoldAsc;
        private RadioButton rdoMaterialTypeArrZA;
        private Button lblShow;
        private DataGridView dgvSoldMaterialType;
        private GroupBox groupBox1;
        private RadioButton rdoBarChart;
        private RadioButton rdoPieChart;
        private Button btnShow1;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}