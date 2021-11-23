using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class DataPatient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Card { get; set; }

        public DateTime DateBirth { get; set; }

        public bool Smoker { get; set; }

        public bool Allergies { get; set; }

        public string Photo { get; set; }

    }
}
