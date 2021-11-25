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
            SqlDataAdapter query = new SqlDataAdapter("SELECT k.Id as Code,p.Name AS Patients,d.Name AS Doctor,k.Date,k.Reason,ks.Name as Status FROM Keep k JOIN KeepStatus ks ON k.State = ks.Id JOIN Patients p ON p.Id = k.IdPatients JOIN Doctors d ON d.Id = k.IdDoctor", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Keep WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataTable SearchPatient(string card)
        {
            SqlDataAdapter query = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Id as Code,Name,LastName,Phone,Address,Card,Date_Birth as Date,Smoker,Allergies FROM Patients WHERE Card=@card", _connection);

            command.Parameters.AddWithValue("@card", card);
            query.SelectCommand = command;

            return LoadData(query);
        }

        public DataTable SearchDoctor(string card)
        {
            SqlDataAdapter query = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Id as Code,Name,LastName,Mail,Phone,Card FROM Doctors WHERE Card=@card", _connection);

            command.Parameters.AddWithValue("@card", card);
            query.SelectCommand = command;

            return LoadData(query);
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
