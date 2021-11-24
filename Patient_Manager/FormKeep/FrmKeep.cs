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
    public partial class FrmKeep : Form
    {
        public AppointmentService service;

        public FrmKeep()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new AppointmentService(connection); 
        }

        #region "Events"

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void singOffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {

        }

        private void BtnSee_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {

        }

        private void DgvKeep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
    }
}
