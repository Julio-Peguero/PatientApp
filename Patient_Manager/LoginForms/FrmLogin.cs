using BusinessLayer;
using Database.Models;
using Patient_Manager.FormsHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Manager
{
    public partial class FrmLogin : Form
    {
        private UserService service;

        public static FrmLogin Instance { get; } = new FrmLogin();
        public FrmLogin()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; //Connection SQL

            SqlConnection connection = new SqlConnection(connectionString);

            service = new UserService(connection);
        }

        #region "Events"

        private void BtnLoginInit_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region "Methods"

        public void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbLoginNick.Text) || string.IsNullOrWhiteSpace(TxbLoginPassword.Text))
                {
                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else
                {
                    DataUser data = service.Login(TxbLoginNick.Text, TxbLoginPassword.Text);

                    if (data.UserName == TxbLoginNick.Text && data.Password == TxbLoginPassword.Text)
                    {
                        MainRepository.Instance.UserType = data.Type;
                        FrmLogin.Instance.Hide();
                        FrmHome newForm = new FrmHome();
                        newForm.Show();
                        ClearTxb();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "Warning");
                        ClearTxb();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred", "Error");
                ClearTxb();
            }
        }

        public void ClearTxb()
        {
            TxbLoginNick.Clear();
            TxbLoginPassword.Clear();
            TxbLoginNick.Focus();
        }

        #endregion
    }
}
