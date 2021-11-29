using BusinessLayer;
using BusinessLayer.LabBusiness;
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

namespace Patient_Manager.FormLab
{
    public partial class FrmLab : Form
    {
        public LabService service;

        public FrmLab()
        {
            InitializeComponent();

            Boleans();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new LabService(connection);
        }

        #region "Events"

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void DgvLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.LabIndex = Convert.ToInt32(DgvLab.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;
            }
        }

        private void FrmLab_Load(object sender, EventArgs e)
        {
            LoadData();
            Boleans();
        }

        private void FrmLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        #endregion

        #region "Methods"

        private void Home()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
            this.Hide();
        }

        private void Off()
        {
            FrmLogin.Instance.Show();
            this.Hide();
        }

        private void Deselect()
        {
            DgvLab.ClearSelection();

            BtnDeselect.Visible = false;

            MainRepository.Instance.LabIndex = null;
        }

        private void Add()
        {

            if (MainRepository.Instance.LabIndex != null)
            {
                MessageBox.Show("You must deselect the test", "Warning");
            }
            else
            {
                FrmNewLab newForm = new FrmNewLab();
                newForm.Show();
                this.Hide();
            }
        }

        private void Edit()
        {
            if (MainRepository.Instance.LabIndex == null)
            {
                MessageBox.Show("You must select the test", "Warning");
            }
            else
            {
                FrmNewLab newForm = new FrmNewLab();
                newForm.Show();
                this.Hide();
            }
        }

        private void LoadData()
        {
            DgvLab.DataSource = service.GatAll();

            DgvLab.ClearSelection();
        }

        private void Delete()
        {
            if (MainRepository.Instance.LabIndex == null)
            {
                MessageBox.Show("You must choose a Test", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Test?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    service.Delete(MainRepository.Instance.LabIndex.Value);
                    LoadData();
                    Deselect();
                    MessageBox.Show("Test Lab removed successfully", "Notification");
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Test Lab has not been deleted", "Notification");
                }
            }
        }

        public void Boleans()
        {
            BtnDeselect.Visible = false;
            MainRepository.Instance.LabIndex = null;

        }
        #endregion
    }
}
