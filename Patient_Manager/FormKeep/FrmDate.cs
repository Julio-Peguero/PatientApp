using BusinessLayer;
using BusinessLayer.AppointmentBusiness;
using BusinessLayer.DoctorBusiness;
using BusinessLayer.PatientsBusiness;
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
    public partial class FrmDate : Form
    {
        public AppointmentService _service;

        public PatientService _patient;

        public DoctorService _doctor;

        public FrmDate()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new AppointmentService(connection);

            _patient = new PatientService(connection);

            _doctor = new DoctorService(connection);
        }

        #region "Events"

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment();
        }

        private void FrmDate_Load(object sender, EventArgs e)
        {
            LoadBox();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        #endregion


        #region "Methods"

        public void LoadBox()
        {
            DataPatient patient = _patient.GetById((int)KeepRepository.Instance.IdPatient);
            TxbPatient.Text = patient.Name;

            DataDoctor doctor = _doctor.GetById((int)KeepRepository.Instance.IdDoctor);
            TxbDoctor.Text = doctor.Name;
        }

        public void Next()
        {
            if(string.IsNullOrWhiteSpace(TxbReason.Text) || string.IsNullOrWhiteSpace(TxbDoctor.Text) 
                || string.IsNullOrWhiteSpace(TxbPatient.Text))
            {
                MessageBox.Show("You must complete all the information", "Warning");
            }
            else
            {
                DataAppointment appointment = new DataAppointment()
                {

                    IdPatient = KeepRepository.Instance.IdPatient.Value,
                    IdDoctor = KeepRepository.Instance.IdDoctor.Value,
                    Date = DtpDate.Value.Date + DtpHour.Value.TimeOfDay,                    
                    Reason = TxbReason.Text,
                    State = 1

                };

                _service.Add(appointment);
                Appointment();
            }
        }

        public void Appointment()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        public void Back()
        {
            FrmDoctorIndex newForm = new FrmDoctorIndex();
            newForm.Show();
            this.Hide();
        }

        #endregion     
    }
}
