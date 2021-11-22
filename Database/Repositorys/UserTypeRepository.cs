using Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class UserTypeRepository
    {
        private SqlConnection _connection;

        public UserTypeRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<UserType> GetList()
        {
            try
            {
                List<UserType> list = new List<UserType>();
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id,Name FROM UserType", _connection);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    list.Add(new UserType
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    });
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
