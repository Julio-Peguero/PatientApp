using Database.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class DataUserRepository
    {
        private SqlConnection _connection;

        public DataUserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool Add(DataUser item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Users(Name,LastName,Mail,UserName,Password,TypeUser) VALUES(@name,@lastname,@mail,@username,@password,@typeuser)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@mail", item.Mail);
            command.Parameters.AddWithValue("@username", item.UserName);
            command.Parameters.AddWithValue("@password", item.Password);
            command.Parameters.AddWithValue("@typeuser", item.Type);

            return ExecuteDml(command);
        }

        public bool Edit(DataUser item)
        {
            SqlCommand command = new SqlCommand("UPDATE Users set Name=@name,LastName=@lastname,Mail=@mail,UserName=@username,Password=@password,TypeUser=@typeuser WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@mail", item.Mail);
            command.Parameters.AddWithValue("@username", item.UserName);
            command.Parameters.AddWithValue("@password", item.Password);
            command.Parameters.AddWithValue("@typeuser", item.Type);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public string CheckUser(string username)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT UserName FROM Users WHERE UserName = @username", _connection);

                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                string data = "";

                while (reader.Read())
                {
                    data = reader.IsDBNull(0) ? "" : reader.GetString(0);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataUser Login(string username, string password)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id,Name,LastName,Mail,UserName,Password,TypeUser FROM Users WHERE UserName = @username and Password = @password", _connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                DataUser data = new DataUser();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Mail = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.UserName = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Password = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Type = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name,LastName,Mail,UserName,TypeUser FROM Users", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Users WHERE Id=@id",_connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataUser GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id,Name,LastName,Mail,UserName,TypeUser,Password FROM Users WHERE Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                DataUser data = new DataUser();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Mail = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.UserName = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Type = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                    data.Password = reader.IsDBNull(6) ? "" : reader.GetString(6);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region "Main Methods"

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

    }
}
