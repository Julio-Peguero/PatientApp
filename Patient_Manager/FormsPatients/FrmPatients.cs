using BusinessLayer;
using BusinessLayer.PatientsBusiness;
using Patient_Manager.FormsHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormsMedical
{
    public partial class FrmPatients : Form
    {
        public PatientService _service;

        public FrmPatients()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new PatientService(connection);
        }

        #region "Events"

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.PatientIndex = Convert.ToInt32(DgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;
            }
        }

        private void FrmPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosedForm();
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            LoadData();
            Boleans();
        }

        #endregion

        #region "Methods"

        public void Add()
        {
            if (MainRepository.Instance.PatientIndex != null)
            {
                MessageBox.Show("You must deselect the patient", "Warning");
            }
            else
            {
                FrmNewPatient newForm = new FrmNewPatient();
                newForm.Show();
                this.Hide();
            }
        }

        public void Edit()
        {
            if (MainRepository.Instance.PatientIndex == null)
            {
                MessageBox.Show("You must select the patient", "Warning");
            }
            else
            {
                FrmNewPatient newForm = new FrmNewPatient();
                newForm.Show();
                this.Hide();
            }
        }

        private void Delete()
        {
            if (MainRepository.Instance.PatientIndex == null)
            {
                MessageBox.Show("You must choose a patient", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the patient?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(MainRepository.Instance.PatientIndex.Value);
                    LoadData();
                    Deselect();
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Patient has not been deleted", "Notification");
                }
            }
        }

        private void Deselect()
        {
            DgvPatients.ClearSelection();

            BtnDeselect.Visible = false;

            MainRepository.Instance.PatientIndex = null;
        }

        public void Boleans()
        {
            BtnDeselect.Visible = false;
            MainRepository.Instance.PatientIndex = null;

        }

        private void Off()
        {
            FrmLogin.Instance.Show();
            this.Hide();
        }

        private void Home()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
            this.Hide();
        }

        private void LoadData()
        {
            DgvPatients.DataSource = _service.GetAll();

            DgvPatients.ClearSelection();
        }

        public void ClosedForm()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
        }



        #endregion

        
    }
}
