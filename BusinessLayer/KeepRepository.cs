using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class KeepRepository
    {
        public static KeepRepository Instance { get; } = new KeepRepository();

        public int? AppointmentIndex = null;

        public int? IdPatient = null;

        public int? IdDoctor = null;

        public int? IdLab = null;

        private KeepRepository()
        {

        }
    }
}
