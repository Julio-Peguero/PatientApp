using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PatientsBusiness
{
    public sealed class PatientRepository
    {

        public static PatientRepository Instance { get; } = new PatientRepository();

        public List<Patient> Patients { get; set; } = new List<Patient>();

        private PatientRepository()
        {

        }

    }
}
