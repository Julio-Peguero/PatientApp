using BusinessLayer;
using Database.Models;
using Patient_Manager.FormDoctor;
using Patient_Manager.FormKeep;
using Patient_Manager.FormLab;
using Patient_Manager.FormsMedical;
using Patient_Manager.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrmDoctor = Patient_Manager.FormDoctor.FrmDoctor;

namespace Patient_Manager.FormsHome
{
    public partial class FrmHome : Form
    {
        public UserService userService;

        public FrmHome()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            userService = new UserService(connection);
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

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Off();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            BtnAccess();
        }

        private void BtnMedical_Click(object sender, EventArgs e)
        {
            Doctor();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            Patient();
        }

        private void BtnTestLab_Click(object sender, EventArgs e)
        {
            TestLab();
        }

        private void BtnKeep_Click(object sender, EventArgs e)
        {
            Appointment();
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

        private void Doctor()
        {
            this.Hide();
            FrmDoctor newForm = new FrmDoctor();
            newForm.Show();
        }

        private void Patient()
        {
            this.Hide();
            FrmPatients newForm = new FrmPatients();
            newForm.Show();
        }

        public void TestLab()
        {
            this.Hide();
            FrmLab newForm = new FrmLab();
            newForm.Show();
        }

        public void Appointment()
        {
            this.Hide();
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
        }

        #endregion


        #region "Permissions"

        private void BtnAccess()
        {
            if (MainRepository.Instance.UserType == 1)
            {
                BtnKeep.Visible = true;
                BtnMedical.Visible = true;
                BtnPatient.Visible = true;
                BtnTestLab.Visible = true;
                BtnTestResult.Visible = true;
                BtnUser.Visible = true;
            }
            else if(MainRepository.Instance.UserType == 2)
            {
                BtnKeep.Visible = true;
                BtnMedical.Visible = false;
                BtnPatient.Visible = true;
                BtnTestLab.Visible = false;
                BtnTestResult.Visible = true;
                BtnUser.Visible = false;
            }
        }


        #endregion
    }
}
