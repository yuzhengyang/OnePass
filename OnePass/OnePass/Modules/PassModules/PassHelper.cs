using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Jsons;
using OnePass.Models.StorageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Modules.PassModules
{
    public static class PassHelper
    {
        public static string EnPasscode(string email, string password)
        {
            return AesTool.Encrypt(MD5Tool.Encrypt(password), email);
        }
        public static string DePasscode(string email, string passcode)
        {
            return AesTool.Decrypt(passcode, email);
        }
        public static string EnData(DataEntity data)
        {
            return Json.Object2String(data);
        }
        public static DataEntity DeData(string s, string email, string passcode)
        {
            DataEntity result = null;
            result = Json.String2Object<DataEntity>(s);
            return result;
        }
    }
}
