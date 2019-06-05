using Azylee.Core.IOUtils.DirUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnePass.Commons
{
    public static partial class R
    {
        public static class Files
        {
            public static string App = Application.ExecutablePath;

            public static string GetUserDataFile(string email)
            {
                return DirTool.Combine(Paths.Datas, email, $"{email}.opds");
            }
            public static string GetUserDataCacheFile(string email)
            {
                return DirTool.Combine(Paths.Datas, email, $"{email}.opds.cache");
            }
        }
    }
}
