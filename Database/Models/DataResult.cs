using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class DataResult
    {
        public int Id { get; set; }

        public int IdPtient { get; set; }

        public int IdAppointment { get; set; }

        public int IdTestLab { get; set; }

        public int IdDoctor { get; set; }

        public string Result { get; set; }

        public int IdStatus { get; set; }

    }
}
