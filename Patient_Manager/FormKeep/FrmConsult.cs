using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
using BusinessLayer.LabBusiness;
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
    public partial class FrmConsult : Form
    {
        public LabService _dataLab;

        public ResultService _result;

        public AppointmentService _keep;

        public FrmConsult()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _dataLab = new LabService(connection);

            _result = new ResultService(connection);

            _keep = new AppointmentService(connection);
        }

        #region "Events"

        private void FrmConsult_Load(object sender, EventArgs e)
        {
            Deselect();
            LoadData();
        }

        private void DgvConsult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow rows in DgvConsult.SelectedRows)
                {

                    KeepRepository.Instance.LabsTest.Add((int)rows.Cells[0].Value);
                }

                BtnDeselect.Visible = true;

                BtnTest.Visible = true;
            }
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Test();
        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        public void Deselect()
        {
            DgvConsult.ClearSelection();

            BtnDeselect.Visible = false;

            BtnTest.Visible = false;

            KeepRepository.Instance.LabsTest.Clear();
        }

        public void LoadData()
        {

            DgvConsult.DataSource = _dataLab.GatAll();

            DgvConsult.ClearSelection();
        }

        public void Test()
        {
            if (KeepRepository.Instance.LabsTest != null)
            {
                foreach (int id in KeepRepository.Instance.LabsTest)
                {
                    DataAppointment keep = _keep.GetById((int)KeepRepository.Instance.AppointmentIndex);

                    DataResult result = new DataResult();

                    result.IdPtient = keep.IdPatient;
                    result.IdAppointment = keep.Id;
                    result.IdTestLab = id;
                    result.IdDoctor = keep.IdDoctor;
                    result.IdStatus = 1;

                    _result.Add(result);

                    keep.Id = (int)KeepRepository.Instance.AppointmentIndex;
                    keep.State = 2;

                    _keep.Edit(keep);
                }
            }
            else
            {
                MessageBox.Show("You must select at least one test", "Error");
            }

            KeepRepository.Instance.LabsTest.Clear();

            Back();
        }

        #endregion
    }
}
