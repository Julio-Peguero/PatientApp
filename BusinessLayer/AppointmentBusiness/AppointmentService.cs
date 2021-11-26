using Database.Models;
using Database.Repositorys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer.AppointmentBusiness
{
    public class AppointmentService
    {

        private DataAppointmentRepository repository;

        public AppointmentService(SqlConnection connection)
        {
            repository = new DataAppointmentRepository(connection);
        }

        #region "Methods"

        public bool Add(DataAppointment item)
        {
            return repository.Add(item);
        }

        public DataTable GetAllDoctor()
        {
            return repository.GetAllDoctor();
        }

        public DataTable GetAllPatient()
        {
            return repository.GetAllPatient();
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public DataTable SearchPatient(string card)
        {
            return repository.SearchPatient(card);
        }

        public DataTable SearchDoctor(string card)
        {
            return repository.SearchDoctor(card);
        }

        public DataAppointment GetById(int id)
        {
            return repository.GetById(id);
        }

        #endregion
    }
}
