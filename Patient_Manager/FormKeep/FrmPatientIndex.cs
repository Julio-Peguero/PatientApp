using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
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
    public partial class FrmPatientIndex : Form
    {
        public AppointmentService _service;

        public FrmPatientIndex()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new AppointmentService(connection);
        }

        #region "Events"

        private void FrmPatientIndex_Load(object sender, EventArgs e)
        {
            LoadData();
            Deselect();
        }

        private void FrmPatientIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Card();
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void DgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KeepRepository.Instance.IdPatient = Convert.ToInt32(DgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnDeselect.Visible = true;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        #endregion

        #region "Methods"

        public void Add()
        {
            if (KeepRepository.Instance.IdPatient != null)
            {
                FrmDoctorIndex newForm = new FrmDoctorIndex();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must select the patient", "Warning");                
            }
        }

        public void Card()
        {
            if (!MtbCard.MaskCompleted)
            {
                LoadData();
            }
            else
            {
                DgvPatients.DataSource = _service.SearchPatient(MtbCard.Text);

                DgvPatients.ClearSelection();
            }
        }

        private void LoadData()
        {
            DgvPatients.DataSource = _service.GetAllPatient();

            DgvPatients.ClearSelection();
        }

        public void CloseForm()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
        }

        public void Deselect()
        {
            DgvPatients.ClearSelection();

            BtnDeselect.Visible = false;

            KeepRepository.Instance.IdPatient = null;
        }

        public void Back()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        #endregion
    }
}
