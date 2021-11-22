using BusinessLayer;
using Database.Models;
using EmailHandler;
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
    public partial class FrmNewUser : Form
    {

        public UserService service;

        public UserTypeService _userTypeService;

        private EmailSender _emailSender;

        public FrmNewUser()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new UserService(connection);

            _userTypeService = new UserTypeService(connection);

            _emailSender = new EmailSender();
        }


        #region "Events"

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadEdit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.UserIdex == null)
            {
                Add();
            }
            else
            {
                Edit();
            }
        }

        private void FrmNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back();
        }

        #endregion


        #region "Methods"

        public void Back()
        {
            FrmUser newForm = new FrmUser();
            newForm.Show();
            this.Hide();
        }

        public void Add()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text)
                || string.IsNullOrWhiteSpace(TxbMail.Text) || string.IsNullOrWhiteSpace(TxbUser.Text)
                || string.IsNullOrWhiteSpace(TxbPasswordC.Text) || string.IsNullOrWhiteSpace(TxbPassword.Text) || CxbType == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (TxbPassword.Text != null && TxbPasswordC.Text != null && TxbPassword.Text == TxbPasswordC.Text)
                {
                    ComboBoxItem selectItem = CxbType.SelectedItem as ComboBoxItem;

                    DataUser users = new DataUser()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Mail = TxbMail.Text,
                        UserName = TxbUser.Text,
                        Password = TxbPasswordC.Text,
                        Type = (int)selectItem.Value
                    };

                    if (service.CheckUser(users.UserName) == users.UserName)
                    {
                        MessageBox.Show("This user is already registered", "Warning");
                    }
                    else
                    {
                        _emailSender.SendEmail(users.Mail, "The user was added successfully",
                            $"Your username is {users.UserName} and Password is {users.Password}");

                        service.Add(users);

                        MessageBox.Show("The user was added successfully", "Notification");
                        Back();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Error");
                    TxbPassword.Clear();
                    TxbPasswordC.Clear();
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

                if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbLastName.Text)
                || string.IsNullOrWhiteSpace(TxbMail.Text) || string.IsNullOrWhiteSpace(TxbUser.Text)
                || string.IsNullOrWhiteSpace(TxbPasswordC.Text) || string.IsNullOrWhiteSpace(TxbPassword.Text) || CxbType == null)
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (TxbPassword.Text != null && TxbPasswordC.Text != null && TxbPassword.Text == TxbPasswordC.Text)
                {
                    ComboBoxItem selectItem = CxbType.SelectedItem as ComboBoxItem;

                    DataUser users = new DataUser()
                    {
                        Name = TxbName.Text,
                        LastName = TxbLastName.Text,
                        Mail = TxbMail.Text,
                        UserName = TxbUser.Text,
                        Password = TxbPasswordC.Text,
                        Type = (int)selectItem.Value,
                        Id = MainRepository.Instance.UserIdex.Value
                    };

                    service.Edit(users);
                    MessageBox.Show("User edited successfully", "Notification");
                    Back();
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Error");
                    TxbPassword.Clear();
                    TxbPasswordC.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }

        public void LoadEdit()
        {
            TxbUser.Enabled = false;

            if (MainRepository.Instance.UserIdex != null)
            {
                ComboBoxItem selectItem = CxbType.SelectedItem as ComboBoxItem;

                DataUser editContact = service.GetById(MainRepository.Instance.UserIdex.Value);
                TxbName.Text = editContact.Name;
                TxbLastName.Text = editContact.LastName;
                TxbMail.Text = editContact.Mail;
                TxbUser.Text = editContact.UserName;
                TxbPassword.Text = editContact.Password;
                TxbPasswordC.Text = editContact.Password;
                editContact.Id = MainRepository.Instance.UserIdex.Value;
                CxbType.SelectedIndex = CxbType.FindStringExact(editContact.TypeUser);
            }
            else
            {
                TxbUser.Enabled = true;
            }
        }

        #endregion


        #region "ComboBox"

        private void LoadComboBox()
        {

            ComboBoxItem optionDefault = new ComboBoxItem()
            {
                Text = "Select an option",
                Value = null
            };

            CxbType.Items.Add(optionDefault);

            List<UserType> listType =  _userTypeService.GetList();

            foreach(UserType item in listType)
            {
                ComboBoxItem ComboItem = new ComboBoxItem()
                {
                    Text = item.Name,
                    Value = item.Id
                };
                CxbType.Items.Add(ComboItem);
            }

            CxbType.SelectedItem = optionDefault;
        }
        #endregion
    }
}
