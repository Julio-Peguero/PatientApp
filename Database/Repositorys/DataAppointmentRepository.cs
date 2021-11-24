using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database.Repositorys
{
    public class DataAppointmentRepository
    {

        private SqlConnection _connection;

        public DataAppointmentRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"


        public bool Add(DataAppointment item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Keep(IdPatients,IdDoctor,Date,Reason,State) VALUES(@patients,@doctor,@date,@reason,@state)", _connection);

            command.Parameters.AddWithValue("@patients", item.IdPatient);
            command.Parameters.AddWithValue("@doctor", item.IdDoctor);
            command.Parameters.AddWithValue("@date", item.Date);
            command.Parameters.AddWithValue("@reason", item.Reason);
            command.Parameters.AddWithValue("@state", item.State);

            return ExecuteDml(command);
        }

        public DataTable GetAllDoctor()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name,LastName,Mail,Phone,Card FROM Doctors", _connection);

            return LoadData(query);
        }

        public DataTable GetAllPatient()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name,LastName,Phone,Address,Card,Date_Birth as Date,Smoker,Allergies FROM Patients", _connection);

            return LoadData(query);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,IdPatients AS Patients,IdDoctor AS Doctor,Date,Reason,State FROM Keep", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Keep WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataDoctor GetByIdDoctor(int id)
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

        public DataPatient GetByIdPatient(int id)
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
                    data.Photo = reader.IsDBNull(9) ? "" : reader.GetString(9);
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
