using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DoctorBusiness
{
    public sealed class DoctorRepository
    {

        public static DoctorRepository Instance { get; } = new DoctorRepository();

        public List<Doctor> Users { get; set; } = new List<Doctor>();

        private DoctorRepository()
        {

        }
    }
}
