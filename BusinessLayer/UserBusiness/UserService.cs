using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer
{
    public class UserService
    {
        private DataUserRepository repository;

        public UserService(SqlConnection connection)
        {
            repository = new DataUserRepository(connection);
        }

        #region "Methods"

        public bool Add(DataUser item)
        {
            return repository.Add(item);
        }

        public string CheckUser(string userName)
        {
            return repository.CheckUser(userName);

        }

        public DataUser Login(string username, string password)
        {
            return repository.Login(username, password);
        }


        #endregion

    }
}
