
namespace Patient_Manager.FormsMedical
{
    partial class FrmNewPatient
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
            this.TblRegister = new System.Windows.Forms.TableLayoutPanel();
            this.PtbPatients = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLast = new System.Windows.Forms.Label();
            this.LblCard = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbLastName = new System.Windows.Forms.TextBox();
            this.MtbCard = new System.Windows.Forms.MaskedTextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblSmoker = new System.Windows.Forms.Label();
            this.LblAllergies = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.MtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxbAddress = new System.Windows.Forms.TextBox();
            this.MtbBirth = new System.Windows.Forms.MaskedTextBox();
            this.CbxSmoker = new System.Windows.Forms.ComboBox();
            this.TxbAllergies = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TblRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblRegister
            // 
            this.TblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TblRegister.ColumnCount = 3;
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70596F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58862F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70542F));
            this.TblRegister.Controls.Add(this.PtbPatients, 1, 0);
            this.TblRegister.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.TblRegister.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.TblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegister.Location = new System.Drawing.Point(0, 0);
            this.TblRegister.Name = "TblRegister";
            this.TblRegister.RowCount = 3;
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.53846F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.19231F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.269231F));
            this.TblRegister.Size = new System.Drawing.Size(486, 520);
            this.TblRegister.TabIndex = 5;
            // 
            // PtbPatients
            // 
            this.PtbPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PtbPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbPatients.Location = new System.Drawing.Point(74, 3);
            this.PtbPatients.Name = "PtbPatients";
            this.PtbPatients.Size = new System.Drawing.Size(337, 183);
            this.PtbPatients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbPatients.TabIndex = 0;
            this.PtbPatients.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.LblName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LblLast, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LblCard, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.TxbName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxbLastName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.MtbCard, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.LblPhone, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.LblDate, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.LblSmoker, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.LblAllergies, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.LblAddress, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.MtbPhone, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.TxbAddress, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.MtbBirth, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.CbxSmoker, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.TxbAllergies, 1, 7);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(74, 192);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 281);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.Honeydew;
            this.LblName.Location = new System.Drawing.Point(118, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // LblLast
            // 
            this.LblLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLast.AutoSize = true;
            this.LblLast.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLast.ForeColor = System.Drawing.Color.Honeydew;
            this.LblLast.Location = new System.Drawing.Point(90, 35);
            this.LblLast.Name = "LblLast";
            this.LblLast.Size = new System.Drawing.Size(75, 17);
            this.LblLast.TabIndex = 1;
            this.LblLast.Text = "Last Name:";
            // 
            // LblCard
            // 
            this.LblCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCard.AutoSize = true;
            this.LblCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCard.ForeColor = System.Drawing.Color.Honeydew;
            this.LblCard.Location = new System.Drawing.Point(43, 140);
            this.LblCard.Name = "LblCard";
            this.LblCard.Size = new System.Drawing.Size(122, 17);
            this.LblCard.TabIndex = 4;
            this.LblCard.Text = "Identification Card:";
            // 
            // TxbName
            // 
            this.TxbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbName.Location = new System.Drawing.Point(171, 3);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(163, 23);
            this.TxbName.TabIndex = 5;
            // 
            // TxbLastName
            // 
            this.TxbLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLastName.Location = new System.Drawing.Point(171, 38);
            this.TxbLastName.Name = "TxbLastName";
            this.TxbLastName.Size = new System.Drawing.Size(163, 23);
            this.TxbLastName.TabIndex = 6;
            // 
            // MtbCard
            // 
            this.MtbCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbCard.Location = new System.Drawing.Point(171, 143);
            this.MtbCard.Mask = "000-0000000-0";
            this.MtbCard.Name = "MtbCard";
            this.MtbCard.Size = new System.Drawing.Size(163, 23);
            this.MtbCard.TabIndex = 12;
            // 
            // LblPhone
            // 
            this.LblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhone.ForeColor = System.Drawing.Color.Honeydew;
            this.LblPhone.Location = new System.Drawing.Point(115, 70);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(50, 17);
            this.LblPhone.TabIndex = 13;
            this.LblPhone.Text = "Phone:";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDate.ForeColor = System.Drawing.Color.Honeydew;
            this.LblDate.Location = new System.Drawing.Point(77, 175);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(88, 17);
            this.LblDate.TabIndex = 14;
            this.LblDate.Text = "Date of birth:";
            // 
            // LblSmoker
            // 
            this.LblSmoker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSmoker.AutoSize = true;
            this.LblSmoker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSmoker.ForeColor = System.Drawing.Color.Honeydew;
            this.LblSmoker.Location = new System.Drawing.Point(107, 210);
            this.LblSmoker.Name = "LblSmoker";
            this.LblSmoker.Size = new System.Drawing.Size(58, 17);
            this.LblSmoker.TabIndex = 15;
            this.LblSmoker.Text = "Smoker:";
            // 
            // LblAllergies
            // 
            this.LblAllergies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAllergies.AutoSize = true;
            this.LblAllergies.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAllergies.ForeColor = System.Drawing.Color.Honeydew;
            this.LblAllergies.Location = new System.Drawing.Point(103, 245);
            this.LblAllergies.Name = "LblAllergies";
            this.LblAllergies.Size = new System.Drawing.Size(62, 17);
            this.LblAllergies.TabIndex = 16;
            this.LblAllergies.Text = "Allergies:";
            // 
            // LblAddress
            // 
            this.LblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddress.ForeColor = System.Drawing.Color.Honeydew;
            this.LblAddress.Location = new System.Drawing.Point(105, 105);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(60, 17);
            this.LblAddress.TabIndex = 18;
            this.LblAddress.Text = "Address:";
            // 
            // MtbPhone
            // 
            this.MtbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbPhone.Location = new System.Drawing.Point(171, 73);
            this.MtbPhone.Mask = "(999)-000-0000";
            this.MtbPhone.Name = "MtbPhone";
            this.MtbPhone.Size = new System.Drawing.Size(163, 23);
            this.MtbPhone.TabIndex = 19;
            // 
            // TxbAddress
            // 
            this.TxbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbAddress.Location = new System.Drawing.Point(171, 108);
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(163, 23);
            this.TxbAddress.TabIndex = 20;
            // 
            // MtbBirth
            // 
            this.MtbBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbBirth.Location = new System.Drawing.Point(171, 178);
            this.MtbBirth.Mask = "00/00/0000";
            this.MtbBirth.Name = "MtbBirth";
            this.MtbBirth.Size = new System.Drawing.Size(163, 23);
            this.MtbBirth.TabIndex = 21;
            this.MtbBirth.ValidatingType = typeof(System.DateTime);
            // 
            // CbxSmoker
            // 
            this.CbxSmoker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbxSmoker.FormattingEnabled = true;
            this.CbxSmoker.Location = new System.Drawing.Point(171, 213);
            this.CbxSmoker.Name = "CbxSmoker";
            this.CbxSmoker.Size = new System.Drawing.Size(163, 23);
            this.CbxSmoker.TabIndex = 22;
            // 
            // TxbAllergies
            // 
            this.TxbAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbAllergies.Location = new System.Drawing.Point(171, 248);
            this.TxbAllergies.Name = "TxbAllergies";
            this.TxbAllergies.Size = new System.Drawing.Size(163, 23);
            this.TxbAllergies.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnConfirm, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(74, 479);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(337, 38);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Honeydew;
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.Black;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(162, 32);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.Honeydew;
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirm.Location = new System.Drawing.Point(171, 3);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(163, 32);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "Add";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // FrmNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 520);
            this.Controls.Add(this.TblRegister);
            this.Name = "FrmNewPatient";
            this.Text = "Patient";
            this.TblRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblRegister;
        private System.Windows.Forms.PictureBox PtbPatients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLast;
        private System.Windows.Forms.Label LblCard;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbLastName;
        private System.Windows.Forms.MaskedTextBox MtbCard;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblSmoker;
        private System.Windows.Forms.Label LblAllergies;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.MaskedTextBox MtbPhone;
        private System.Windows.Forms.TextBox TxbAddress;
        private System.Windows.Forms.MaskedTextBox MtbBirth;
        private System.Windows.Forms.ComboBox CbxSmoker;
        private System.Windows.Forms.TextBox TxbAllergies;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnConfirm;
    }
}