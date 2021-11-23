using BusinessLayer;
using BusinessLayer.DoctorBusiness;
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

namespace Patient_Manager.FormDoctor
{
    public partial class FrmNewDoctor : Form
    {
        public DoctorService _service;

        public FrmNewDoctor()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new DoctorService(connection);
        }

        #region "Events"

        private void BtnLoadPhoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void FrmNewDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void FrmNewDoctor_Load(object sender, EventArgs e)
        {
            if (MainRepository.Instance.DoctorIndex != null)
            {
                LoadEdit();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.DoctorIndex >= 0)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmDoctor newForm = new FrmDoctor();
            newForm.Show();
            this.Hide();
        }

        public void CloseForm()
        {
            FrmDoctor newForm = new FrmDoctor();
            newForm.Show();
        }

        public void Add()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text)
                || string.IsNullOrWhiteSpace(TxbMail.Text) || !MtbCard.MaskCompleted || !MtbPhone.MaskCompleted || PtbPhotoD.ImageLocation == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else 
                {

                    DataDoctor doctors = new DataDoctor()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Mail = TxbMail.Text,
                        Card = MtbCard.Text,
                        Phone = MtbPhone.Text,
                    };

                    bool result = _service.Add(doctors);

                    if (result)
                    {
                        SavePhoto();
                    }

                    MessageBox.Show("The doctor was added successfully", "Notification");
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

            if (MainRepository.Instance.DoctorIndex != null)
            {
                DataDoctor Doctor = _service.GetById(MainRepository.Instance.DoctorIndex.Value);
                TxbName.Text = Doctor.Name;
                TxbLastName.Text = Doctor.LastName;
                TxbMail.Text = Doctor.Mail;
                MtbCard.Text = Doctor.Card;
                MtbPhone.Text = Doctor.Phone;
                Doctor.Id = MainRepository.Instance.DoctorIndex.Value;
                PtbPhotoD.ImageLocation = Doctor.Photo;
            }
        }

        public void Edit()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text)
                || string.IsNullOrWhiteSpace(TxbMail.Text) || !MtbCard.MaskCompleted || !MtbPhone.MaskCompleted || PtbPhotoD.ImageLocation == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else 
                {
                    DataDoctor doctor = new DataDoctor()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Mail = TxbMail.Text,
                        Phone = MtbPhone.Text,
                        Card = MtbCard.Text,
                        Id = MainRepository.Instance.DoctorIndex.Value
                    };

                    _service.Edit(doctor);

                    SavePhoto();

                    MessageBox.Show("Doctor edited successfully", "Notification");
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
                MainRepository.Instance.fileName = PhotoDialog.FileName;

                if (PhotoDialog.FileName.EndsWith(".png") || PhotoDialog.FileName.EndsWith(".jpg"))
                {
                    PtbPhotoD.ImageLocation = MainRepository.Instance.fileName;
                }
                else
                {
                    MessageBox.Show("You can only upload images .png or .jpg", "Error");
                }
            }
        }

        private void SavePhoto() 
        {
            if(!string.IsNullOrWhiteSpace(MainRepository.Instance.fileName))
            {
                int id = MainRepository.Instance.DoctorIndex != null ? (int)MainRepository.Instance.DoctorIndex.Value : _service.GetLastId();

                string directory = $@"Images\Doctor\{id}\";
                CreateDirectory(directory);

                string[] fileNameSplit = MainRepository.Instance.fileName.Split("\\");
                string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                MainRepository.Instance.destinationD = directory + filename;

                File.Copy(MainRepository.Instance.fileName, MainRepository.Instance.destinationD, true);

                _service.SavePhoto(id, MainRepository.Instance.destinationD);
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
            TxbMail.Clear();
            MtbCard.Clear();
            MtbPhone.Clear();
            TxbName.Clear();
            PtbPhotoD.ImageLocation = null;
        }

        #endregion
    }
}
