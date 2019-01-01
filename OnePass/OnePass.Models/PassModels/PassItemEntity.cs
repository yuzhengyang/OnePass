using OnePass.Models.PassTypeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassModels
{
    public class PassItemEntity
    {
        public string Type { get; set; }
        public PassBaseTypeEntity Data { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
