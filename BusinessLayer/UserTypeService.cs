using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer
{
    public class UserTypeService
    {


        private UserTypeRepository _repository;

        public UserTypeService(SqlConnection connection)
        {
            _repository = new UserTypeRepository(connection);
        }

        public List<UserType> GetList()
        {
           return _repository.GetList();
        }

    }
}
