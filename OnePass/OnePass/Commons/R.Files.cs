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
            public static string Settings = DirTool.Combine(Paths.App, "Settings.ini");
            public static string Data = DirTool.Combine(Paths.App, "OnePassData.ops");
            public static string Cache = DirTool.Combine(Paths.App, "OnePassData.ops.cache");
        }
    }
}
