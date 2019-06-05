using Azylee.Core.IOUtils.DirUtils;
using Azylee.Core.LogUtils.SimpleLogUtils;
using OnePass.Models.StorageModels;
using OnePass.Models.UserModels;
using OnePass.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Commons
{
    public static partial class R
    {
        internal static string AppName = "OnePass.201812221503.qingdao.sifang";
        internal static string SharePassKey = "OnePass.920528.share.key";
        internal static MainForm MainUI;
        internal static Log Log = new Log(LogLevel.All, LogLevel.All);

        internal static DataEntity Data = new DataEntity() { User = new UserEntity() };
    }
}
