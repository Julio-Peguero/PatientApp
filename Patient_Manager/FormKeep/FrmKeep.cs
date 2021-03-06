using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
using Database.Models;
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

namespace Patient_Manager.FormKeep
{
    public partial class FrmKeep : Form
    {
        public AppointmentService _service;

        public FrmKeep()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new AppointmentService(connection); 
        }

        #region "Events"

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void singOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {
            Consult();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void BtnSee_Click(object sender, EventArgs e)
        {
            See();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void DgvKeep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KeepRepository.Instance.AppointmentIndex = Convert.ToInt32(DgvKeep.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;

                Buttons();
            }
        }

        private void FrmKeep_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosedForm();
        }

        private void FrmKeep_Load(object sender, EventArgs e)
        {
            Boleans();
            LoadData();
        }

        #endregion


        #region "Methods"

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

        public void Add()
        {
            if (KeepRepository.Instance.AppointmentIndex != null)
            {
                MessageBox.Show("You must deselect the appointment", "Warning");
            }
            else
            {
                FrmPatientIndex newForm = new FrmPatientIndex();
                newForm.Show();
                this.Hide();
            }
        }

        private void Delete()
        {
            if (KeepRepository.Instance.AppointmentIndex == null)
            {
                MessageBox.Show("You must choose a appointment", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the appointment?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(KeepRepository.Instance.AppointmentIndex.Value);
                    LoadData();
                    Deselect();
                    MessageBox.Show("Appointment has been deleted", "Notification");
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Appointment has not been deleted", "Notification");
                }
            }
        }

        private void Deselect()
        {
            DgvKeep.ClearSelection();

            BtnDeselect.Visible = false;

            BtnCheck.Visible = false;

            BtnConsult.Visible = false;

            BtnSee.Visible = false;

            KeepRepository.Instance.AppointmentIndex = null;
        }

        public void Boleans()
        {
            BtnDeselect.Visible = false;

            BtnCheck.Visible = false;

            BtnConsult.Visible = false;

            BtnSee.Visible = false;

            KeepRepository.Instance.AppointmentIndex = null;
        }

        private void LoadData()
        {
            DgvKeep.DataSource = _service.GetAll();

            DgvKeep.ClearSelection();
        }

        public void ClosedForm()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
        }

        public void Buttons()
        {

            DataAppointment appointment =_service.GetById((int)KeepRepository.Instance.AppointmentIndex);
            switch (appointment.State)
            {
                case 1:
                    BtnCheck.Visible = false;
                    BtnConsult.Visible = true;
                    BtnSee.Visible = false;
                    break;
                case 2:
                    BtnCheck.Visible = true;
                    BtnConsult.Visible = false;
                    BtnSee.Visible = false;
                    break;
                case 3:
                    BtnCheck.Visible = false;
                    BtnConsult.Visible = false;
                    BtnSee.Visible = true;
                    break;
                default:
                    BtnCheck.Visible = false;
                    BtnConsult.Visible = false;
                    BtnSee.Visible = false;
                    break;
            }

        }

        public void Check()
        {
            FrmCheck newForm = new FrmCheck();
            newForm.Show();
            this.Hide();
        }

        public void See()
        {
            FrmSee newForm = new FrmSee();
            newForm.Show();
            this.Hide();
        }

        public void Consult()
        {
            FrmConsult newForm = new FrmConsult();
            newForm.Show();
            this.Hide();
        }

        #endregion        
    }
}
