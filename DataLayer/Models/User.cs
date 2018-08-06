using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public string CreationDate { get; set; }

        public string RoleName { get; set; }
    }
}
