using BusinessLayer;
using BusinessLayer.LabBusiness;
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
    public partial class FrmConsult : Form
    {
        public LabService _dataLab;

        public FrmConsult()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _dataLab = new LabService(connection);
        }

        #region "Events"

        private void FrmConsult_Load(object sender, EventArgs e)
        {
            Deselect();
            LoadData();
        }

        private void DgvConsult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KeepRepository.Instance.IdLab = Convert.ToInt32(DgvConsult.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;

                BtnTest.Visible = true;
            }
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmKeep newForm = new FrmKeep();
            newForm.Show();
            this.Hide();
        }

        public void Deselect()
        {
            DgvConsult.ClearSelection();

            BtnDeselect.Visible = false;

            BtnTest.Visible = false;
        }

        public void LoadData()
        {

            DgvConsult.DataSource = _dataLab.GatAll();

            DgvConsult.ClearSelection();
        }

        public void Test()
        {



        }

        #endregion
    }
}
