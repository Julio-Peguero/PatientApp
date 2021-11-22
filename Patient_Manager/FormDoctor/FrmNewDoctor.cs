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

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Add();
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
                || string.IsNullOrWhiteSpace(TxbMail.Text) || !MtbCard.MaskCompleted || !MtbPhone.MaskCompleted || PtbPhotoD == null)
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
                        Photo = MainRepository.Instance.destination
                    };

                    _service.Add(doctors);

                    SavePhoto();

                    MessageBox.Show("The user was added successfully", "Notification");
                    //ClearAll();
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

                PtbPhotoD.ImageLocation = MainRepository.Instance.fileName;
            }
        }

        private void SavePhoto() //Ponerlo en despues de Add y Edit
        {
            if(!string.IsNullOrWhiteSpace(MainRepository.Instance.fileName))
            {
                int id = MainRepository.Instance.DoctorIndex != null ? (int)MainRepository.Instance.DoctorIndex.Value : _service.GetLastId();

                string directory = @"Images\Doctor\" + id + "\\"; //Images/Contact/10
                CreateDirectory(directory);

                string[] fileNameSplit = MainRepository.Instance.fileName.Split("\\");
                string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                MainRepository.Instance.destination = directory + filename;

                File.Copy(MainRepository.Instance.fileName, MainRepository.Instance.destination, true);

                _service.SavePhoto(id, MainRepository.Instance.destination);
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
