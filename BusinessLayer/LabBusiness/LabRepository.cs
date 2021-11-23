using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.LabBusiness
{
    public sealed class LabRepository
    {

        public static LabRepository Instance { get; } = new LabRepository();

        public List<Lab> Users { get; set; } = new List<Lab>();

        private LabRepository()
        {

        }


    }
}
