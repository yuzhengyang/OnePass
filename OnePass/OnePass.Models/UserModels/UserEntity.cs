using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.UserModels
{
    public class UserEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string  PasswordCode { get; set; }
    }
}
