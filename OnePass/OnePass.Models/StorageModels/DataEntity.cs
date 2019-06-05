using OnePass.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.StorageModels
{
    public class DataEntity
    {
        public UserEntity User { get; set; }
        public string PassDatas { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
