using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ResultBusiness
{
    public sealed class ResultLabRepository
    {

        public static ResultLabRepository Instance { get; } = new ResultLabRepository();

        public List<ResultLab> Results { get; set; } = new List<ResultLab>();

        private ResultLabRepository()
        {

        }
    }
}
