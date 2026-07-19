namespace Group20_Project
{
    partial class frmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
            tbcFAQ = new TabControl();
            tbcFAQs = new TabPage();
            linkLabel2 = new LinkLabel();
            FAQs = new ListBox();
            tbcAbout = new TabPage();
            linkLabel1 = new LinkLabel();
            txtAbout = new RichTextBox();
            tbUserGuide = new TabPage();
            tbcFAQ.SuspendLayout();
            tbcFAQs.SuspendLayout();
            tbcAbout.SuspendLayout();
            SuspendLayout();
            // 
            // tbcFAQ
            // 
            tbcFAQ.Controls.Add(tbcFAQs);
            tbcFAQ.Controls.Add(tbcAbout);
            tbcFAQ.Controls.Add(tbUserGuide);
            tbcFAQ.Location = new Point(12, 12);
            tbcFAQ.Name = "tbcFAQ";
            tbcFAQ.SelectedIndex = 0;
            tbcFAQ.Size = new Size(1395, 747);
            tbcFAQ.TabIndex = 1;
            // 
            // tbcFAQs
            // 
            tbcFAQs.Controls.Add(linkLabel2);
            tbcFAQs.Controls.Add(FAQs);
            tbcFAQs.Location = new Point(4, 29);
            tbcFAQs.Name = "tbcFAQs";
            tbcFAQs.Padding = new Padding(3);
            tbcFAQs.Size = new Size(1387, 714);
            tbcFAQs.TabIndex = 0;
            tbcFAQs.Text = "FAQs";
            tbcFAQs.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(897, 595);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 20);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to HomePage";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // FAQs
            // 
            FAQs.FormattingEnabled = true;
            FAQs.Items.AddRange(new object[] { "1. Does the system provide reports?", "Yes, the system generates comprehensive reports. It provides detailed insights ", "into sales transactions and produces summary reports highlighting the top 10 ", "material types sold. These reports help businesses track performance, identify ", "trends, and make informed decisions.", "", "2. How can I add a new recyclable material to the system?", "To add a new recyclable material, you must be logged in with the correct role (the ", "owner or assistant). Go to the section and select add material type. Enter the ", "required details, such as the material name and pricing information, then save ", "your changes. The material will immediately become available in the system for ", "transactions and reporting.", "", "3. Can I delete a material from the system if it is no longer recyclable?", "Yes, you can delete a material.", "", "4. How do I add a new supplier to the recycling system?", "To add a new supplier, log in with an account that has permission to manage ", "suppliers. Go to the suppliers section and select add supplier. You will be ", "prompted to provide the supplier’s name, surname, email address, and contact ", "number. Once all details are entered, save the information and the supplier will ", "be added to the system for future transactions and record keeping.", "", "5. Are there different login roles?", "Yes, the system includes different login roles to manage access and security. The ", "owner has full access to all system features. Regular users have limited access ", "and can perform only specific tasks. This setup ensures that sensitive functions ", "are restricted while allowing users to carry out their designated responsibilities ", "efficiently.", "", "6. Where can I find the user-guide?", "The user guide is available under the help form of the system. Simply navigate to ", "the Help form, where you can access the full guide with instructions on how to ", "use the system’s features.", "", "7. Who do I contact for technical support?", "The system owner", "", "8. Are there any restrictions on sharing the system?", "Yes, access to the system is restricted to authorized users only. Sharing login ", "credentials with unauthorized individuals is prohibited, as it can compromise ", "system security and data integrity. Each user should have a unique account, and ", "permissions are assigned based on their role to ensure that sensitive information ", "and system features are protected." });
            FAQs.Location = new Point(0, 0);
            FAQs.Name = "FAQs";
            FAQs.Size = new Size(746, 724);
            FAQs.TabIndex = 0;
            FAQs.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbcAbout
            // 
            tbcAbout.Controls.Add(linkLabel1);
            tbcAbout.Controls.Add(txtAbout);
            tbcAbout.Location = new Point(4, 29);
            tbcAbout.Name = "tbcAbout";
            tbcAbout.Padding = new Padding(3);
            tbcAbout.Size = new Size(1387, 714);
            tbcAbout.TabIndex = 1;
            tbcAbout.Text = "About";
            tbcAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1132, 526);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to HomePage";
            // 
            // txtAbout
            // 
            txtAbout.Location = new Point(6, 6);
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(1330, 561);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // tbUserGuide
            // 
            tbUserGuide.Location = new Point(4, 29);
            tbUserGuide.Name = "tbUserGuide";
            tbUserGuide.Size = new Size(1387, 714);
            tbUserGuide.TabIndex = 2;
            tbUserGuide.Text = "User guide";
            tbUserGuide.UseVisualStyleBackColor = true;
            // 
            // frmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 675);
            Controls.Add(tbcFAQ);
            Name = "frmView";
            Text = "Help form";
            tbcFAQ.ResumeLayout(false);
            tbcFAQs.ResumeLayout(false);
            tbcFAQs.PerformLayout();
            tbcAbout.ResumeLayout(false);
            tbcAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcFAQ;
        private TabPage tbcFAQs;
        private TabPage tbcAbout;
        private LinkLabel linkLabel1;
        private RichTextBox txtAbout;
        private TabPage tbUserGuide;
        private ListBox FAQs;
        private LinkLabel linkLabel2;
    }
}