using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database.Repositorys
{
    public class DataLabRepository
    {

        private SqlConnection _connection;

        public DataLabRepository(SqlConnection connection)
        {
            _connection = connection;
        }


        #region "Methods"

        public bool Add(DataLab item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TestLab (Name) VALUES(@name)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);

            return ExecuteDml(command);
        }

        public bool Edit(DataLab item)
        {
            SqlCommand command = new SqlCommand("UPDATE TestLab set Name=@name WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Code,Name FROM TestLab Id", _connection);

            return LoadData(query);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("DELETE TestLab WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataLab GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id as Code,Name FROM TestLab WHERE Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                DataLab data = new DataLab();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
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
