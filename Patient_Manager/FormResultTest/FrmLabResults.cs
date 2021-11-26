using BusinessLayer;
using BusinessLayer.ResultBusiness;
using Patient_Manager.FormResultTest;
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
    public partial class FrmLabResults : Form
    {
        public ResultService _result;

        public FrmLabResults()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _result = new ResultService(connection);
        }

        #region "Events"

        private void DgvResultLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.ResultIndex = Convert.ToInt32(DgvResultLab.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnDeselect.Visible = true;

                BtnReport.Visible = true;
            }
        }

        private void FrmLabResults_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void FrmLabResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        #endregion

        #region "Methods"

        public void LoadData()
        {
            DgvResultLab.DataSource = _result.GetAll();

            Deselect();
        }

        public void Deselect()
        {
            DgvResultLab.ClearSelection();

            BtnDeselect.Visible = false;

            BtnReport.Visible = false;
        }

        public void Search()
        {
            if (!MtbCard.MaskCompleted)
            {
                LoadData();
            }
            else
            {
                DgvResultLab.DataSource = _result.Search(MtbCard.Text);

                DgvResultLab.ClearSelection();
            }
        }

        public void Report()
        {
            FrmReport newForm = new FrmReport();
            newForm.Show();
            this.Hide();
        }

        public void CloseForm()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
        }

        public void Home()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
            this.Hide();
        }

        #endregion        
    }
}
