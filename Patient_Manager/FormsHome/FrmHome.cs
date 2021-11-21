using Patient_Manager.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormsHome
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        #region "Events"

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Users();
        }

        private void singOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        #endregion


        #region "Methods"

        private void Off()
        {
            FrmLogin.Instance.Show();
            this.Hide();
        }

        private void Users()
        {
            this.Hide();
            FrmUser newForm = new FrmUser();
            newForm.Show();
        }

        #endregion
    }
}
