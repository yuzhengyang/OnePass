using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassTypeModels
{
    public class PassBaseTypeEntity
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
    }
}
