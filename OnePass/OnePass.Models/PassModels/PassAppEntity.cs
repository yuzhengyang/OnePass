using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassModels
{
    public class PassAppEntity
    {
        public string Name { get; set; }
        public List<PassItemEntity> PassItemList { get; set; }
    }
}
