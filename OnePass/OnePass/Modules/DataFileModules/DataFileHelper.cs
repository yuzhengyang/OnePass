﻿using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.IOUtils.FileUtils;
using Azylee.Core.IOUtils.TxtUtils;
using OnePass.Commons;
using OnePass.Models.StorageModels;
using OnePass.Modules.PassModules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OnePass.Modules.DataFileModules
{
    public static class DataFileHelper
    {
        public static bool Create(DataEntity data)
        {
            if (data != null && data.User != null && Str.Ok(data.User.Email, data.User.Passcode))
            {
                string file = R.Files.GetUserDataFile(data.User.Email);
                string cache = R.Files.GetUserDataCacheFile(data.User.Email);
                if (!File.Exists(file) && !File.Exists(cache))
                {
                    return Write(data);
                }
            }
            return false;
        }
        public static bool Write(DataEntity data)
        {
            if (data != null && data.User != null && Str.Ok(data.User.Email, data.User.Passcode))
            {
                string s = PassHelper.EnData(data);
                string file = R.Files.GetUserDataFile(data.User.Email);
                string cache = R.Files.GetUserDataCacheFile(data.User.Email);
                bool f1 = TxtTool.Create(cache, s);
                if (f1)
                {
                    bool f2 = FileTool.Copy(cache, file, true);
                    return f2;
                }
            }
            return false;
        }
        public static DataEntity Read(string email, string passcode)
        {
            DataEntity result = null;
            if (Str.Ok(email, passcode))
            {
                string file = R.Files.GetUserDataFile(email);
                string cache = R.Files.GetUserDataCacheFile(email);
                string s = TxtTool.Read(file);
                string s_c = TxtTool.Read(cache);
                DataEntity d = PassHelper.DeData(s, email, passcode);
                DataEntity d_s = PassHelper.DeData(s, email, passcode);
                if (d != null && d_s == null) result = d;
                if (d == null && d_s != null) result = d_s;
                if (d != null && d_s != null)
                {
                    if (d.UpdateTime > d_s.UpdateTime) result = d;
                    else result = d_s;
                }
                if (result != null) R.Data = result;
            }
            return result;
        }
    }
}
