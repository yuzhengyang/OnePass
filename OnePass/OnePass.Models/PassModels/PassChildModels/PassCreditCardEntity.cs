using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassModels.PassChildModels
{
    public class PassCreditCardEntity : PassEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
