
namespace Patient_Manager
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PtbLogin = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLoginInit = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblLoginNick = new System.Windows.Forms.Label();
            this.LblLoginPassword = new System.Windows.Forms.Label();
            this.TxbLoginNick = new System.Windows.Forms.TextBox();
            this.TxbLoginPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogin)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.60335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19664F));
            this.tableLayoutPanel1.Controls.Add(this.PtbLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.34426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.073359F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 403);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PtbLogin
            // 
            this.PtbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tableLayoutPanel1.SetColumnSpan(this.PtbLogin, 3);
            this.PtbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogin.Image")));
            this.PtbLogin.Location = new System.Drawing.Point(3, 3);
            this.PtbLogin.Name = "PtbLogin";
            this.PtbLogin.Size = new System.Drawing.Size(425, 153);
            this.PtbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbLogin.TabIndex = 0;
            this.PtbLogin.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.47826F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.13044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.39131F));
            this.tableLayoutPanel2.Controls.Add(this.BtnLoginInit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(72, 369);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 31);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnLoginInit
            // 
            this.BtnLoginInit.BackColor = System.Drawing.Color.Honeydew;
            this.BtnLoginInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoginInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoginInit.FlatAppearance.BorderSize = 0;
            this.BtnLoginInit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.BtnLoginInit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnLoginInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginInit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLoginInit.Location = new System.Drawing.Point(55, 3);
            this.BtnLoginInit.Name = "BtnLoginInit";
            this.BtnLoginInit.Size = new System.Drawing.Size(176, 25);
            this.BtnLoginInit.TabIndex = 0;
            this.BtnLoginInit.Text = "Login";
            this.BtnLoginInit.UseVisualStyleBackColor = false;
            this.BtnLoginInit.Click += new System.EventHandler(this.BtnLoginInit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LblLoginNick, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblLoginPassword, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxbLoginNick, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxbLoginPassword, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(72, 162);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.28856F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.71144F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(285, 201);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LblLoginNick
            // 
            this.LblLoginNick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoginNick.AutoSize = true;
            this.LblLoginNick.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoginNick.ForeColor = System.Drawing.Color.White;
            this.LblLoginNick.Location = new System.Drawing.Point(94, 0);
            this.LblLoginNick.Name = "LblLoginNick";
            this.LblLoginNick.Size = new System.Drawing.Size(45, 20);
            this.LblLoginNick.TabIndex = 0;
            this.LblLoginNick.Text = "User:";
            // 
            // LblLoginPassword
            // 
            this.LblLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoginPassword.AutoSize = true;
            this.LblLoginPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoginPassword.ForeColor = System.Drawing.Color.White;
            this.LblLoginPassword.Location = new System.Drawing.Point(62, 85);
            this.LblLoginPassword.Name = "LblLoginPassword";
            this.LblLoginPassword.Size = new System.Drawing.Size(77, 20);
            this.LblLoginPassword.TabIndex = 1;
            this.LblLoginPassword.Text = "Password:";
            // 
            // TxbLoginNick
            // 
            this.TxbLoginNick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLoginNick.Location = new System.Drawing.Point(145, 3);
            this.TxbLoginNick.Name = "TxbLoginNick";
            this.TxbLoginNick.Size = new System.Drawing.Size(137, 23);
            this.TxbLoginNick.TabIndex = 2;
            // 
            // TxbLoginPassword
            // 
            this.TxbLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLoginPassword.Location = new System.Drawing.Point(145, 88);
            this.TxbLoginPassword.Name = "TxbLoginPassword";
            this.TxbLoginPassword.Size = new System.Drawing.Size(137, 23);
            this.TxbLoginPassword.TabIndex = 3;
            this.TxbLoginPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogin)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PtbLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnLoginInit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblLoginNick;
        private System.Windows.Forms.Label LblLoginPassword;
        private System.Windows.Forms.TextBox TxbLoginNick;
        private System.Windows.Forms.TextBox TxbLoginPassword;
    }
}

