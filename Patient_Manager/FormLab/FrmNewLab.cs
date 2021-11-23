using BusinessLayer;
using BusinessLayer.LabBusiness;
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

namespace Patient_Manager.FormLab
{
    public partial class FrmNewLab : Form
    {
        public LabService service;

        public FrmNewLab()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new LabService(connection);
        }

        #region "Events"

        private void FrmNewLab_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }

        private void FrmNewLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.LabIndex == null)
            {
                Add();
            }
            else
            {
                Edit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmLab newForm = new FrmLab();
            newForm.Show();
            this.Hide();
        }

        public void Add()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text))
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else
                {

                    DataLab lab = new DataLab()
                    {
                        Name = TxbName.Text,
                    };

                    service.Add(lab);

                    MessageBox.Show("The test was added successfully", "Notification");
                    Back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }

        public void Edit()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(TxbName.Text))
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else
                {

                    DataLab lab = new DataLab()
                    {
                        Name = TxbName.Text,
                        Id = MainRepository.Instance.LabIndex.Value
                    };

                    service.Edit(lab);
                    MessageBox.Show("Test edited successfully", "Notification");
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

            if (MainRepository.Instance.LabIndex != null)
            {

                DataLab editContact = service.GetById(MainRepository.Instance.LabIndex.Value);
                TxbName.Text = editContact.Name;
                editContact.Id = MainRepository.Instance.LabIndex.Value;
            }
        }

        #endregion
    }
}
