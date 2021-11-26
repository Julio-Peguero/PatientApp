using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database.Repositorys
{
    public class DataResultRepository
    {

        private SqlConnection _connection;

        public DataResultRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool Add(DataResult item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ResultLab(IdPatients,IdKeep,IdLabTest,IdDoctor,StateResult) VALUES(@idpatients,@idkeep,@idlab,@iddoctor,@statusresult)", _connection);

            command.Parameters.AddWithValue("@idpatients", item.IdPtient);
            command.Parameters.AddWithValue("@idkeep", item.IdAppointment);
            command.Parameters.AddWithValue("@idlab", item.IdTestLab);
            command.Parameters.AddWithValue("@iddoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@statusresult", item.IdStatus);

            return ExecuteDml(command);
        }


        public DataTable Search(string card)
        {
            SqlDataAdapter query = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT r.Id as Code,p.Name,p.LastName,p.Card,t.Name as Test FROM ResultLab r JOIN Patients p ON r.IdPatients = p.Id JOIN TestLab t ON r.IdLabTest = t.Id WHERE p.Card=@card", _connection);

            command.Parameters.AddWithValue("@card", card);
            query.SelectCommand = command;

            return LoadData(query);
        }


        public DataResult GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id as Code,IdPatients,IdKeep,IdLabTest,IdDoctor,ResltTest,StateResult WHERE Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                DataResult data = new DataResult();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.IdPtient = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.IdAppointment = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.IdTestLab = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    data.IdDoctor = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    data.Result = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.IdStatus = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
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

        public bool Edit(DataResult item)
        {
            SqlCommand command = new SqlCommand("UPDATE ResultLab set ResltTest=@result,StateResult=@status WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@result", item.Result);
            command.Parameters.AddWithValue("@status", item.IdStatus);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT r.Id as Code,p.Name,p.LastName,p.Card,t.Name as Test FROM ResultLab r JOIN Patients p ON r.IdPatients = p.Id JOIN TestLab t ON r.IdLabTest = t.Id", _connection);

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
