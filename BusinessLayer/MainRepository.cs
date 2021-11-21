using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class MainRepository
    {

        public static MainRepository Instance { get; } = new MainRepository();

        public int? UserIdex = null;

        private MainRepository()
        {

        }
    }
}
