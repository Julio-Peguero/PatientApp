using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class MainRepository
    {

        public static MainRepository Instance { get; } = new MainRepository();

        public int? UserIdex = null;

        public int UserType = 0;

        private MainRepository()
        {

        }
    }
}
