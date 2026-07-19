namespace Group20_Project
{
    partial class frmHomepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomepage));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logOffToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            maintainsToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            materialTypeToolStripMenuItem = new ToolStripMenuItem();
            processToolStripMenuItem = new ToolStripMenuItem();
            sellToolStripMenuItem = new ToolStripMenuItem();
            buyToolStripMenuItem = new ToolStripMenuItem();
            materialReceivedToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            top10MaterialTypeSoldToolStripMenuItem = new ToolStripMenuItem();
            salesTransactionPerPeriodToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            lblWelcome = new Label();
            pbWelcome = new PictureBox();
            lblSlogan = new Label();
            lblMessage = new Label();
            lblSlog = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, maintainsToolStripMenuItem, processToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1534, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOffToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logOffToolStripMenuItem
            // 
            logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            logOffToolStripMenuItem.Size = new Size(140, 26);
            logOffToolStripMenuItem.Text = "Log off";
            logOffToolStripMenuItem.Click += logOffToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(140, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // maintainsToolStripMenuItem
            // 
            maintainsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem, customersToolStripMenuItem, materialTypeToolStripMenuItem });
            maintainsToolStripMenuItem.Name = "maintainsToolStripMenuItem";
            maintainsToolStripMenuItem.Size = new Size(87, 24);
            maintainsToolStripMenuItem.Text = "Maintains";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(182, 26);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(182, 26);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // materialTypeToolStripMenuItem
            // 
            materialTypeToolStripMenuItem.Name = "materialTypeToolStripMenuItem";
            materialTypeToolStripMenuItem.Size = new Size(182, 26);
            materialTypeToolStripMenuItem.Text = "Material Type";
            materialTypeToolStripMenuItem.Click += materialTypeToolStripMenuItem_Click;
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sellToolStripMenuItem, buyToolStripMenuItem, materialReceivedToolStripMenuItem });
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(72, 24);
            processToolStripMenuItem.Text = "Process";
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(211, 26);
            sellToolStripMenuItem.Text = "Sell";
            sellToolStripMenuItem.Click += sellToolStripMenuItem_Click;
            // 
            // buyToolStripMenuItem
            // 
            buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            buyToolStripMenuItem.Size = new Size(211, 26);
            buyToolStripMenuItem.Text = "Buy";
            buyToolStripMenuItem.Click += buyToolStripMenuItem_Click;
            // 
            // materialReceivedToolStripMenuItem
            // 
            materialReceivedToolStripMenuItem.Name = "materialReceivedToolStripMenuItem";
            materialReceivedToolStripMenuItem.Size = new Size(211, 26);
            materialReceivedToolStripMenuItem.Text = "Material Received";
            materialReceivedToolStripMenuItem.Click += materialReceivedToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { top10MaterialTypeSoldToolStripMenuItem, salesTransactionPerPeriodToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // top10MaterialTypeSoldToolStripMenuItem
            // 
            top10MaterialTypeSoldToolStripMenuItem.Name = "top10MaterialTypeSoldToolStripMenuItem";
            top10MaterialTypeSoldToolStripMenuItem.Size = new Size(277, 26);
            top10MaterialTypeSoldToolStripMenuItem.Text = "Top 10 material type sold";
            top10MaterialTypeSoldToolStripMenuItem.Click += top10MaterialTypeSoldToolStripMenuItem_Click;
            // 
            // salesTransactionPerPeriodToolStripMenuItem
            // 
            salesTransactionPerPeriodToolStripMenuItem.Name = "salesTransactionPerPeriodToolStripMenuItem";
            salesTransactionPerPeriodToolStripMenuItem.Size = new Size(277, 26);
            salesTransactionPerPeriodToolStripMenuItem.Text = "Sales transaction per period";
            salesTransactionPerPeriodToolStripMenuItem.Click += salesTransactionPerPeriodToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 15F);
            lblWelcome.Location = new Point(204, 39);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(381, 39);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Zero Waste Hub";
            // 
            // pbWelcome
            // 
            pbWelcome.Image = (Image)resources.GetObject("pbWelcome.Image");
            pbWelcome.Location = new Point(252, 81);
            pbWelcome.Name = "pbWelcome";
            pbWelcome.Size = new Size(222, 130);
            pbWelcome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWelcome.TabIndex = 2;
            pbWelcome.TabStop = false;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Location = new Point(403, 176);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(0, 20);
            lblSlogan.TabIndex = 3;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 11F);
            lblMessage.Location = new Point(84, 262);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(620, 106);
            lblMessage.TabIndex = 4;
            lblMessage.Text = resources.GetString("lblMessage.Text");
            // 
            // lblSlog
            // 
            lblSlog.AutoSize = true;
            lblSlog.Location = new Point(280, 223);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(175, 20);
            lblSlog.TabIndex = 5;
            lblSlog.Text = "Clean Earth, Green Future\r\n";
            // 
            // frmHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1534, 785);
            Controls.Add(lblSlog);
            Controls.Add(lblMessage);
            Controls.Add(lblSlogan);
            Controls.Add(pbWelcome);
            Controls.Add(lblWelcome);
            Controls.Add(menuStrip1);
            Name = "frmHomepage";
            Text = "Homepage";
            WindowState = FormWindowState.Maximized;
            Load += frmHomepage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logOffToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem maintainsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem materialTypeToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem sellToolStripMenuItem;
        private ToolStripMenuItem buyToolStripMenuItem;
        private ToolStripMenuItem top10MaterialTypeSoldToolStripMenuItem;
        private ToolStripMenuItem salesTransactionPerPeriodToolStripMenuItem;
        private Label lblWelcome;
        private PictureBox pbWelcome;
        private Label lblSlogan;
        private Label lblMessage;
        private Label lblSlog;
        private ToolStripMenuItem materialReceivedToolStripMenuItem;
    }
}
