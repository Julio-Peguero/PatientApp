using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database.Repositorys
{
    public class DataPatientRepository
    {

        private SqlConnection _connection;

        public DataPatientRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool Add(DataPatient item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Patients(Name,LastName,Phone,Address,Card,Date_Birth,Smoker,Allergies) VALUES(@name,@lastname,@phone,@address,@card,@date_birth,@smoker,@allergies)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@address", item.Address);
            command.Parameters.AddWithValue("@card", item.Card);
            command.Parameters.AddWithValue("@date_birth", item.DateBirth);
            command.Parameters.AddWithValue("@smoker", item.Smoker);
            command.Parameters.AddWithValue("@allergies", item.Allergies);

            return ExecuteDml(command);
        }

        public bool SavePhoto(int id, string path)
        {
            SqlCommand command = new SqlCommand("UPDATE Patients SET Photo=@photo WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@photo", path);
            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public bool Edit(DataPatient item)
        {
            SqlCommand command = new SqlCommand("UPDATE Patients set Name=@name,LastName=@lastname,Mail=@mail,Phone=@phone,Card=@card WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@address", item.Address);
            command.Parameters.AddWithValue("@card", item.Card);
            command.Parameters.AddWithValue("@date_birth", item.DateBirth);
            command.Parameters.AddWithValue("@smoker", item.Smoker);
            command.Parameters.AddWithValue("@allergies", item.Allergies);

            return ExecuteDml(command);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name,LastName,Phone,Address,Card,Date_Birth as Date,Smoker,Allergies FROM Patients", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Patients WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataPatient GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id as Code,Name,LastName,Phone,Address,Card,Date_Birth as Date,Smoker,Allergies,Photo FROM Patients WHERE Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                DataPatient data = new DataPatient();

                while (reader.Read())
                {
                    
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Phone = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Address = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Card = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.DateBirth = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
                    data.Smoker = reader.IsDBNull(7) ? false : reader.GetBoolean(7);
                    data.Allergies = reader.IsDBNull(8) ? "" : reader.GetString(8);

                    
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

                SqlCommand command = new SqlCommand("SELECT MAX(Id) as Id FROM Patients", _connection);

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
