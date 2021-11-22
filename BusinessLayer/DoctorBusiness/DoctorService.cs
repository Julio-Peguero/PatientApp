using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer.DoctorBusiness
{
    public class DoctorService
    {
        private DataDoctorRepository repository;

        public DoctorService(SqlConnection connection)
        {
            repository = new DataDoctorRepository(connection);
        }

        #region "Methods"

        public bool Add(DataDoctor item)
        {
            return repository.Add(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public bool SavePhoto(int id, string path)
        {
            return repository.SavePhoto(id,path);
        }

        public bool Edit(DataDoctor item)
        {
            return repository.Edit(item);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public DataDoctor GetById(int id)
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
