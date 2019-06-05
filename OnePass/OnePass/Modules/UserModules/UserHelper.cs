using OnePass.Commons;
using OnePass.Models.StorageModels;
using OnePass.Models.UserModels;
using OnePass.Modules.DataFileModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Modules.UserModules
{
    public static class UserHelper
    {
        public static bool Login(string email, string passcode)
        {
            DataEntity data = DataFileHelper.Read(email, passcode);
            if (data != null)
            {
                R.Data = data;
                return true;
            }
            return false;
        }
    }
}
