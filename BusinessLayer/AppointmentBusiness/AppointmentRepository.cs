using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.AppointmentBusiness
{
    public sealed class AppointmentRepository
    {

        public static AppointmentRepository Instance { get; } = new AppointmentRepository();

        public List<Appointment> Doctors { get; set; } = new List<Appointment>();

        private AppointmentRepository()
        {

        }

    }
}
