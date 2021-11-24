﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AppointmentBusiness
{
    public class Appointment
    {

        public int IdPatient { get; set; }

        public int IdDoctor { get; set; }

        public DateTime Date { get; set; }

        public string Reason { get; set; }

        public int State { get; set; }
    }
}
