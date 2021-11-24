using BusinessLayer;
using BusinessLayer.PatientsBusiness;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormsMedical
{
    public partial class FrmNewPatient : Form
    {
        public PatientService _service;

        public FrmNewPatient()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new PatientService(connection);
        }

        #region "Events"

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.PatientIndex >= 0)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        private void BtnLoadPhoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void FrmNewPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void FrmNewPatient_Load(object sender, EventArgs e)
        {
            if (MainRepository.Instance.PatientIndex != null)
            {
                LoadEdit();
            }
        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmPatients newForm = new FrmPatients();
            newForm.Show();
            this.Hide();
        }

        public void CloseForm()
        {
            FrmPatients newForm = new FrmPatients();
            newForm.Show();
        }

        public void Add()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text) 
                    || string.IsNullOrWhiteSpace(TxbAddress.Text) || string.IsNullOrWhiteSpace(TxbAllergies.Text) 
                    || !MtbCard.MaskCompleted || !MtbPhone.MaskCompleted || PtbPatients.ImageLocation == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (CbkYes.Checked == CbkNo.Checked)
                {
                    MessageBox.Show("You must have different answers in smoker or select one", "Notification");
                }
                else
                {

                    DataPatient patient = new DataPatient()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Card = MtbCard.Text,
                        Phone = MtbPhone.Text,
                        Address = TxbAddress.Text,
                        DateBirth = DtpBirth.Value.Date,
                        Allergies = TxbAllergies.Text,
                        Smoker = CbkNo.Checked ? false : CbkYes.Checked

                };

                    bool result = _service.Add(patient);

                    if (result)
                    {
                        SavePhoto();
                    }

                    MessageBox.Show("The patient was added successfully", "Notification");
                    ClearAll();
                    Back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }

        public void LoadEdit()
        {

            if (MainRepository.Instance.PatientIndex != null)
            {
                DataPatient patient = _service.GetById(MainRepository.Instance.PatientIndex.Value);
                TxbName.Text = patient.Name;
                TxbLastName.Text = patient.LastName;
                TxbAddress.Text = patient.Address;
                TxbAllergies.Text = patient.Allergies;
                MtbCard.Text = patient.Card;
                MtbPhone.Text = patient.Phone;
                patient.Id = MainRepository.Instance.PatientIndex.Value;
                PtbPatients.ImageLocation = patient.Photo;
                CbkYes.Checked = patient.Smoker;
                CbkNo.Checked = patient.Smoker == false ? true : false;
                DtpBirth.Value = patient.DateBirth;
            }
        }

        public void Edit()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text)
                    || string.IsNullOrWhiteSpace(TxbAddress.Text) || string.IsNullOrWhiteSpace(TxbAllergies.Text)
                    || !MtbCard.MaskCompleted || !MtbPhone.MaskCompleted || PtbPatients.ImageLocation == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (CbkYes.Checked == CbkNo.Checked)
                {
                    MessageBox.Show("You must have different answers in smoker or select one", "Notification");
                }
                else
                {

                    DataPatient patient = new DataPatient()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Card = MtbCard.Text,
                        Phone = MtbPhone.Text,
                        Address = TxbAddress.Text,
                        DateBirth = DtpBirth.Value.Date,
                        Allergies = TxbAllergies.Text,
                        Smoker = CbkNo.Checked ? false : CbkYes.Checked,
                        Id = MainRepository.Instance.PatientIndex.Value
                    };

                    bool result = _service.Edit(patient);

                    if (result)
                    {
                        SavePhoto();
                    }

                    MessageBox.Show("Patient edited successfully", "Notification");
                    Back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }

        #endregion


        #region "Private Methods"

        private void AddPhoto()
        {
            DialogResult result = PhotoDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainRepository.Instance.fileNameP = PhotoDialog.FileName;

                if (PhotoDialog.FileName.EndsWith(".png") || PhotoDialog.FileName.EndsWith(".jpg") || PhotoDialog.FileName.EndsWith(".jpeg"))
                {
                    PtbPatients.ImageLocation = MainRepository.Instance.fileNameP;
                }
                else
                {
                    MessageBox.Show("You can only upload images .png, .jpg or .jpeg", "Error");
                }
            }
        }

        private void SavePhoto()
        {
            if (!string.IsNullOrWhiteSpace(MainRepository.Instance.fileNameP))
            {
                int id = MainRepository.Instance.PatientIndex != null ? (int)MainRepository.Instance.PatientIndex.Value : _service.GetLastId();

                string directory = $@"Images\Patient\{id}\";
                CreateDirectory(directory);

                string[] fileNameSplit = MainRepository.Instance.fileNameP.Split("\\");
                string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                MainRepository.Instance.destinationP = directory + filename;

                File.Copy(MainRepository.Instance.fileNameP, MainRepository.Instance.destinationP, true);

                _service.SavePhoto(id, MainRepository.Instance.destinationP);
            }
        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public void ClearAll()
        {
            TxbName.Clear();
            TxbLastName.Clear();
            MtbCard.Clear();
            MtbPhone.Clear();
            TxbName.Clear();
            PtbPatients.ImageLocation = null;
        }

        #endregion
    }
}
