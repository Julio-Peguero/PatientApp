
namespace Patient_Manager.FormsHome
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnMedical = new System.Windows.Forms.Button();
            this.BtnTestLab = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnKeep = new System.Windows.Forms.Button();
            this.BtnTestResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.909465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.79836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.292181F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.00624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99376F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 415);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.60164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.79191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.60645F));
            this.tableLayoutPanel2.Controls.Add(this.BtnUser, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnMedical, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnTestLab, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnPatient, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnKeep, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnTestResult, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8439F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.87492F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.13517F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.14602F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 256);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.Honeydew;
            this.BtnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUser.Location = new System.Drawing.Point(3, 41);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(180, 55);
            this.BtnUser.TabIndex = 0;
            this.BtnUser.Text = "User maintenance";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnMedical
            // 
            this.BtnMedical.BackColor = System.Drawing.Color.Honeydew;
            this.BtnMedical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMedical.FlatAppearance.BorderSize = 0;
            this.BtnMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedical.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMedical.Location = new System.Drawing.Point(189, 41);
            this.BtnMedical.Name = "BtnMedical";
            this.BtnMedical.Size = new System.Drawing.Size(211, 55);
            this.BtnMedical.TabIndex = 1;
            this.BtnMedical.Text = "Medical maintenance";
            this.BtnMedical.UseVisualStyleBackColor = false;
            this.BtnMedical.Click += new System.EventHandler(this.BtnMedical_Click);
            // 
            // BtnTestLab
            // 
            this.BtnTestLab.BackColor = System.Drawing.Color.Honeydew;
            this.BtnTestLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestLab.FlatAppearance.BorderSize = 0;
            this.BtnTestLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestLab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTestLab.Location = new System.Drawing.Point(406, 41);
            this.BtnTestLab.Name = "BtnTestLab";
            this.BtnTestLab.Size = new System.Drawing.Size(182, 55);
            this.BtnTestLab.TabIndex = 2;
            this.BtnTestLab.Text = "Laboratory Test maintenance";
            this.BtnTestLab.UseVisualStyleBackColor = false;
            this.BtnTestLab.Click += new System.EventHandler(this.BtnTestLab_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.Color.Honeydew;
            this.BtnPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPatient.Location = new System.Drawing.Point(3, 102);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(180, 48);
            this.BtnPatient.TabIndex = 3;
            this.BtnPatient.Text = "Patient maintenance";
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnKeep
            // 
            this.BtnKeep.BackColor = System.Drawing.Color.Honeydew;
            this.BtnKeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnKeep.FlatAppearance.BorderSize = 0;
            this.BtnKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKeep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKeep.Location = new System.Drawing.Point(189, 102);
            this.BtnKeep.Name = "BtnKeep";
            this.BtnKeep.Size = new System.Drawing.Size(211, 48);
            this.BtnKeep.TabIndex = 4;
            this.BtnKeep.Text = "Keeping maintenance";
            this.BtnKeep.UseVisualStyleBackColor = false;
            this.BtnKeep.Click += new System.EventHandler(this.BtnKeep_Click);
            // 
            // BtnTestResult
            // 
            this.BtnTestResult.BackColor = System.Drawing.Color.Honeydew;
            this.BtnTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestResult.FlatAppearance.BorderSize = 0;
            this.BtnTestResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTestResult.Location = new System.Drawing.Point(406, 102);
            this.BtnTestResult.Name = "BtnTestResult";
            this.BtnTestResult.Size = new System.Drawing.Size(182, 48);
            this.BtnTestResult.TabIndex = 5;
            this.BtnTestResult.Text = "Maintaining laboratory test results";
            this.BtnTestResult.UseVisualStyleBackColor = false;
            this.BtnTestResult.Click += new System.EventHandler(this.BtnTestResult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singOffToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // singOffToolStripMenuItem
            // 
            this.singOffToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.singOffToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
            this.singOffToolStripMenuItem.Name = "singOffToolStripMenuItem";
            this.singOffToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.singOffToolStripMenuItem.Text = "Sing Off";
            this.singOffToolStripMenuItem.Click += new System.EventHandler(this.singOffToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnMedical;
        private System.Windows.Forms.Button BtnTestLab;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnKeep;
        private System.Windows.Forms.Button BtnTestResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singOffToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}