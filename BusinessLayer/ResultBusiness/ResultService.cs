using Database.Models;
using Database.Repositorys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer.ResultBusiness
{
    public class ResultService
    {
        private DataResultRepository repository;

        public ResultService(SqlConnection connection)
        {
            repository = new DataResultRepository(connection);
        }

        public bool Add(DataResult item)
        {
            return repository.Add(item);
        }

        public DataResult GetById(int id)
        {
            return repository.GetById(id);
        }

        public bool Edit(DataResult item)
        {
            return repository.Edit(item);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public DataTable Search(string card)
        {
            return repository.Search(card);
        }

    }
}
