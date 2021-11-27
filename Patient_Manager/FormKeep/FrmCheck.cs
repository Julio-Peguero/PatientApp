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
    public partial class FrmCheck : Form
    {
        public ResultService _result;

        public AppointmentService _keep;

        public FrmCheck()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _result = new ResultService(connection);

            _keep = new AppointmentService(connection);
        }

        #region "Events"

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseResult();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            Complete();
        }

        private void FrmCheck_Load(object sender, EventArgs e)
        {
            LoadData();

            DgvLab.ClearSelection();
        }

        private void FrmCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        #endregion


        #region "Methods"

        public void LoadData()
        {
            DataAppointment keep = _keep.GetById((int)KeepRepository.Instance.AppointmentIndex);

            DgvLab.DataSource = _result.GetAllId(keep.Id);
        }

        public void CloseForm()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
        }

        public void Complete()
        {

            DataAppointment keep = new DataAppointment();
            keep.State = 3;
            keep.Id = (int)KeepRepository.Instance.AppointmentIndex;

            MessageBox.Show("The appointment has been completed", "Notification");

            _keep.Edit(keep);

            CloseResult();
        }

        public void CloseResult()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        #endregion        
    }
}
