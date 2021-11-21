using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class UserRepository
    {

        public static UserRepository Instance { get; } = new UserRepository();

        public List<User> Users { get; set; } = new List<User>();

        private UserRepository()
        {

        }

    }
}
