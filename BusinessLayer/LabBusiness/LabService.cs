using Database.Models;
using Database.Repositorys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer.LabBusiness
{
    public class LabService
    {
        private DataLabRepository repository;

        public LabService(SqlConnection connection)
        {
            repository = new DataLabRepository(connection);
        }


        #region "Methods"

        public bool Add(DataLab item)
        {
            return repository.Add(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public bool Edit(DataLab item)
        {
            return repository.Edit(item);
        }

        public DataTable GatAll()
        {
            return repository.GetAll();
        }

        public DataLab GetById(int id)
        {
            return repository.GetById(id);
        }


        #endregion

    }
}
