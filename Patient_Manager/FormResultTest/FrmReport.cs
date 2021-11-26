using BusinessLayer;
using BusinessLayer.ResultBusiness;
using Database.Models;
using Patient_Manager.FormKeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormResultTest
{
    public partial class FrmReport : Form
    {
        public ResultService _result;

        public FrmReport()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _result = new ResultService(connection);
        }

        #region "Events"

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Finish();
        }

        #endregion

        #region "Methods"

        public void Back()
        {
            FrmLabResults newForm = new FrmLabResults();
            newForm.Show();
            this.Hide();
        }

        public void Finish()
        {

            if (string.IsNullOrWhiteSpace(TxbResult.Text))
            {
                MessageBox.Show("You must complete the data", "Warning");
            }
            else
            {
                DataResult result = new DataResult()
                {
                    Result = TxbResult.Text,
                    IdStatus = 3,
                    Id = MainRepository.Instance.ResultIndex.Value
                };

                MessageBox.Show("Result validated successfully", "Notification");

                _result.Edit(result);

                Back();
            }
        }

        #endregion
    }
}
