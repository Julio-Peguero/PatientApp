using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
using BusinessLayer.ResultBusiness;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormKeep
{
    public partial class FrmSee : Form
    {
        public ResultService _result;

        public AppointmentService _keep;

        public FrmSee()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _keep = new AppointmentService(connection);

            _result = new ResultService(connection);
        }

        #region "Events"

        private void FrmSee_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void FrmSee_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        #endregion


        #region "Methods"

        public void CloseForm()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
        }

        public void Back()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        public void LoadForm()
        {
            DgvConsult.ClearSelection();

            DgvConsult.DataSource = _result.GetResult((int)KeepRepository.Instance.AppointmentIndex);

        }

        #endregion
    }
}
