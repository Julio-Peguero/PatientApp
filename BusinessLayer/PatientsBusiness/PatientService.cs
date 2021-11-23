using Database.Models;
using Database.Repositorys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer.PatientsBusiness
{
    public class PatientService
    {

        private DataPatientRepository repository;

        public PatientService(SqlConnection connection)
        {
            repository = new DataPatientRepository(connection);
        }

        #region "Methods"

        public bool Add(DataPatient item)
        {
            return repository.Add(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public bool SavePhoto(int id, string path)
        {
            return repository.SavePhoto(id, path);
        }

        public bool Edit(DataPatient item)
        {
            return repository.Edit(item);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public DataPatient GetById(int id)
        {
            return repository.GetById(id);
        }

        public int GetLastId()
        {
            return repository.GetLastId();
        }

        #endregion
    }
}
