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

        public DataDoctor GetByIdDoctor(int id)
        {
            return repository.GetByIdDoctor(id);
        }

        public DataPatient GetByIdPatient(int id)
        {
            return repository.GetByIdPatient(id);
        }

        #endregion
    }
}
