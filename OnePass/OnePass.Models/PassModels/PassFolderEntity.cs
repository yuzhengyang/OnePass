using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassModels
{
    public class PassFolderEntity
    {
        public string  Name { get; set; }
        public List<PassAppEntity> PassAppList { get; set; }
    }
}
