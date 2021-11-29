using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
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
    public partial class FrmDoctorIndex : Form
    {
        public AppointmentService _service;

        public FrmDoctorIndex()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new AppointmentService(connection);
        }

        #region "Events"

        private void FrmDoctorIndex_Load(object sender, EventArgs e)
        {
            LoadData();
            Deselect();
        }

        private void FrmDoctorIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Card();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void DgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KeepRepository.Instance.IdDoctor = Convert.ToInt32(DgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnDeselect.Visible = true;

                BtnNext.Visible = true;
            }
        }

        #endregion


        #region "Methods"

        public void Add()
        {
            if (KeepRepository.Instance.IdDoctor != null)
            {
                FrmDate newForm = new FrmDate();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must select the doctor", "Warning");
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
                DgvDoctor.DataSource = _service.SearchDoctor(MtbCard.Text);

                DgvDoctor.ClearSelection();
            }
        }

        private void LoadData()
        {
            DgvDoctor.DataSource = _service.GetAllDoctor();

            DgvDoctor.ClearSelection();
        }

        public void CloseForm()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
        }

        public void Deselect()
        {
            DgvDoctor.ClearSelection();

            BtnDeselect.Visible = false;

            BtnNext.Visible = false;

            KeepRepository.Instance.IdDoctor = null;
        }

        public void Back()
        {
            FrmPatientIndex newForm = new FrmPatientIndex();
            newForm.Show();
            this.Hide();
        }

        public void Init()
        {
            FrmKeep newForm = new FrmKeep();
            this.Hide();
            newForm.Show();
        }

        #endregion
    }
}
