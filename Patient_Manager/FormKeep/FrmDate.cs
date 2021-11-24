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
    public partial class FrmDate : Form
    {
        public AppointmentService _service;

        public FrmDate()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new AppointmentService(connection);
        }

        #region "Events"

        private void BtnNext_Click(object sender, EventArgs e)
        {

        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region "Methods"

        public void Box()
        {
            
        }

        #endregion
    }
}
