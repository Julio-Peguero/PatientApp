using BusinessLayer;
using BusinessLayer.DoctorBusiness;
using Patient_Manager.FormsHome;
using Patient_Manager.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Manager.FormDoctor
{
    public partial class FrmDoctor : Form
    {
        public DoctorService _service;

        public FrmDoctor()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new DoctorService(connection);
        }

        #region "Events"

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void DgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.DoctorIndex = Convert.ToInt32(DgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            Boleans();
            LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void FrmDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosedForm();
        }

        #endregion


        #region "Methods"

        public void Add()
        {
            if (MainRepository.Instance.DoctorIndex != null)
            {
                MessageBox.Show("You must deselect the Doctor", "Warning");
            }
            else
            {
                FrmNewDoctor newForm = new FrmNewDoctor();
                newForm.Show();
                this.Hide();
            }
        }

        public void Edit()
        {
            if (MainRepository.Instance.DoctorIndex == null)
            {
                MessageBox.Show("You must select the Doctor", "Warning");
            }
            else
            {
                FrmNewDoctor newForm = new FrmNewDoctor();
                newForm.Show();
                this.Hide();
            }
        }

        private void Delete()
        {
            if (MainRepository.Instance.DoctorIndex == null)
            {
                MessageBox.Show("You must choose a Doctor", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Doctor?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(MainRepository.Instance.DoctorIndex.Value);
                    LoadData();
                    Deselect();
                    MessageBox.Show("Doctor has been deleted", "Notification");
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Doctor has not been deleted", "Notification");
                }
            }
        }

        private void Deselect()
        {
            DgvDoctor.ClearSelection();

            BtnDeselect.Visible = false;

            MainRepository.Instance.DoctorIndex = null;
        }

        public void Boleans()
        {
            BtnDeselect.Visible = false;
            MainRepository.Instance.DoctorIndex = null;

        }

        private void Off()
        {
            FrmLogin.Instance.Show();
            this.Hide();
        }

        private void Home()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
            this.Hide();
        }

        private void LoadData()
        {
            DgvDoctor.DataSource = _service.GetAll();

            DgvDoctor.ClearSelection();
        }

        public void ClosedForm()
        {
            FrmHome newForm = new FrmHome();
            newForm.Show();
        }

        #endregion
    }
}
