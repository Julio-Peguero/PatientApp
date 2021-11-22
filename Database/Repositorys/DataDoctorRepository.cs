using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class DataDoctorRepository
    {
        private SqlConnection _connection;

        public DataDoctorRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool Add(DataDoctor item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Doctors(Name,LastName,Mail,Phone,Card,Photo) VALUES(@name,@lastname,@mail,@phone,@card,@photo)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@mail", item.Mail);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@card", item.Card);
            command.Parameters.AddWithValue("@photo", item.Photo);

            return ExecuteDml(command);
        }

        public bool SavePhoto(int id, string path)
        {
            SqlCommand command = new SqlCommand("UPDATE Doctors SET Photo=@photo WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@photo", path);
            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public bool Edit(DataDoctor item)
        {
            SqlCommand command = new SqlCommand("UPDATE Doctors set Name=@name,LastName=@lastname,Mail=@mail,Phone=@phone,Card=@card,Photo=@photo WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@mail", item.Mail);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@card", item.Card);
            command.Parameters.AddWithValue("@photo", item.Photo);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name,LastName,Mail,Phone,Card FROM Doctors", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Doctors WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataDoctor GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id as Code,Name,LastName,Mail,Phone,Card,Photo FROM Doctors WHERE Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                DataDoctor data = new DataDoctor();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Mail = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Phone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Card = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Photo = reader.IsDBNull(6) ? "" : reader.GetString(6);
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

        public int GetLastId()
        {
            try
            {
                _connection.Open();

                int LastId = 0;

                SqlCommand command = new SqlCommand("SELECT MAX(Id) as Id FROM Doctors", _connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return LastId;
            }
            catch (Exception ex)
            {
                return 0;
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
