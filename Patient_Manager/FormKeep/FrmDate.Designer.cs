
namespace Patient_Manager.FormKeep
{
    partial class FrmDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDate));
            this.TblRegister = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblPatient = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblReason = new System.Windows.Forms.Label();
            this.TxbPatient = new System.Windows.Forms.TextBox();
            this.TxbDoctor = new System.Windows.Forms.TextBox();
            this.TxbReason = new System.Windows.Forms.TextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.DtpHour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TblRegister.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblRegister
            // 
            this.TblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TblRegister.ColumnCount = 3;
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70596F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58862F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70542F));
            this.TblRegister.Controls.Add(this.BtnNext, 1, 2);
            this.TblRegister.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.TblRegister.Controls.Add(this.label1, 0, 0);
            this.TblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegister.Location = new System.Drawing.Point(0, 24);
            this.TblRegister.Name = "TblRegister";
            this.TblRegister.RowCount = 3;
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.18548F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.34677F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.269231F));
            this.TblRegister.Size = new System.Drawing.Size(486, 496);
            this.TblRegister.TabIndex = 5;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNext.Location = new System.Drawing.Point(74, 457);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(337, 36);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Create Appointment";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblPatient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblDoctor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblHour, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblReason, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxbPatient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxbDoctor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxbReason, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DtpDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DtpHour, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 333);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblPatient
            // 
            this.LblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPatient.AutoSize = true;
            this.LblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatient.ForeColor = System.Drawing.Color.Honeydew;
            this.LblPatient.Location = new System.Drawing.Point(111, 0);
            this.LblPatient.Name = "LblPatient";
            this.LblPatient.Size = new System.Drawing.Size(54, 17);
            this.LblPatient.TabIndex = 0;
            this.LblPatient.Text = "Patient:";
            // 
            // LblDoctor
            // 
            this.LblDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDoctor.ForeColor = System.Drawing.Color.Honeydew;
            this.LblDoctor.Location = new System.Drawing.Point(112, 66);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(53, 17);
            this.LblDoctor.TabIndex = 1;
            this.LblDoctor.Text = "Doctor:";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDate.ForeColor = System.Drawing.Color.Honeydew;
            this.LblDate.Location = new System.Drawing.Point(126, 132);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(39, 17);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date:";
            // 
            // LblHour
            // 
            this.LblHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHour.AutoSize = true;
            this.LblHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHour.ForeColor = System.Drawing.Color.Honeydew;
            this.LblHour.Location = new System.Drawing.Point(122, 198);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(43, 17);
            this.LblHour.TabIndex = 3;
            this.LblHour.Text = "Hour:";
            // 
            // LblReason
            // 
            this.LblReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReason.AutoSize = true;
            this.LblReason.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReason.ForeColor = System.Drawing.Color.Honeydew;
            this.LblReason.Location = new System.Drawing.Point(110, 264);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(55, 17);
            this.LblReason.TabIndex = 4;
            this.LblReason.Text = "Reason:";
            // 
            // TxbPatient
            // 
            this.TxbPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbPatient.Enabled = false;
            this.TxbPatient.Location = new System.Drawing.Point(171, 3);
            this.TxbPatient.Name = "TxbPatient";
            this.TxbPatient.ReadOnly = true;
            this.TxbPatient.Size = new System.Drawing.Size(163, 23);
            this.TxbPatient.TabIndex = 5;
            // 
            // TxbDoctor
            // 
            this.TxbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbDoctor.Enabled = false;
            this.TxbDoctor.Location = new System.Drawing.Point(171, 69);
            this.TxbDoctor.Name = "TxbDoctor";
            this.TxbDoctor.ReadOnly = true;
            this.TxbDoctor.Size = new System.Drawing.Size(163, 23);
            this.TxbDoctor.TabIndex = 6;
            // 
            // TxbReason
            // 
            this.TxbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbReason.Location = new System.Drawing.Point(171, 267);
            this.TxbReason.Name = "TxbReason";
            this.TxbReason.Size = new System.Drawing.Size(163, 23);
            this.TxbReason.TabIndex = 9;
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "";
            this.DtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(171, 135);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(163, 23);
            this.DtpDate.TabIndex = 10;
            this.DtpDate.Value = new System.DateTime(2021, 11, 24, 18, 17, 2, 0);
            // 
            // DtpHour
            // 
            this.DtpHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHour.Location = new System.Drawing.Point(171, 201);
            this.DtpHour.Name = "DtpHour";
            this.DtpHour.ShowUpDown = true;
            this.DtpHour.Size = new System.Drawing.Size(163, 23);
            this.DtpHour.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TblRegister.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 115);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date of Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.backToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.appointmentToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // FrmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 520);
            this.Controls.Add(this.TblRegister);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDate";
            this.Text = "FrmDate";
            this.Load += new System.EventHandler(this.FrmDate_Load);
            this.TblRegister.ResumeLayout(false);
            this.TblRegister.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblRegister;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblReason;
        private System.Windows.Forms.TextBox TxbPatient;
        private System.Windows.Forms.TextBox TxbDoctor;
        private System.Windows.Forms.TextBox TxbReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.DateTimePicker DtpHour;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}