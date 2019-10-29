using Azylee.Core.DataUtils.StringUtils;
using OnePass.Commons;
using OnePass.Models.StorageModels;
using OnePass.Models.UserModels;
using OnePass.Modules.DataFileModules;
using OnePass.Modules.PassModules;
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
        public static bool IsLogin(DataEntity data)
        {
            if (data != null && data.User != null && Str.Ok(data.User.Email, data.User.Passcode))
            {
                return true;
            }
            return false;
        }
        public static bool Create(string email, string password)
        {
            DataEntity data = new DataEntity() { User = new UserEntity() };
            data.User.Email = email;
            data.User.Passcode = PassHelper.EnPasscode(email, password);
            return DataFileHelper.Create(data);
        }
    }
}
