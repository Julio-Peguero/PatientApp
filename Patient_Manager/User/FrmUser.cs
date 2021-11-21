using BusinessLayer;
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

namespace Patient_Manager.User
{
    public partial class FrmUser : Form
    {
        public UserService service;

        public FrmUser()
        {
            InitializeComponent();

            Boleans();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new UserService(connection);
        }

        #region "Events"

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Off();
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.UserIdex = Convert.ToInt32(DgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
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
            DgvUsers.ClearSelection();

            BtnDeselect.Visible = false;

            MainRepository.Instance.UserIdex = null;
        }

        private void Add()
        {
            FrmNewUser newForm = new FrmNewUser();
            newForm.Show();
            this.Hide();
        }

        private void LoadData()
        {
            DgvUsers.DataSource = service.GatAll();

            DgvUsers.ClearSelection();
        }

        private void Delete()
        {
            if (MainRepository.Instance.UserIdex == null)
            {
                MessageBox.Show("You must choose a contact", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the user?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    service.Delete(MainRepository.Instance.UserIdex.Value);
                    LoadData();
                    Deselect();
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("User has not been deleted", "Notification");
                }
            }
        }

        public void Boleans()
        {
            BtnDeselect.Visible = false;
            MainRepository.Instance.UserIdex = null;

        }
        #endregion
    }
}
