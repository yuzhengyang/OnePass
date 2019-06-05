using Azylee.WinformSkin.FormUI.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Commons
{
    public static partial class R
    {
        public static class Toast
        {
            /// <summary>
            /// 用户手动触发提示框
            /// </summary>
            /// <param name="title"></param>
            /// <param name="text"></param>
            /// <param name="type"></param>
            /// <param name="time"></param>
            public static void Show(string title, string text, char type = 'i', int time = 5000, Action clickAction = null)
            {
                try
                {
                    MainUI.Invoke(new Action(() =>
                    {
                        //ToolTipIcon icon = ToolTipIcon.Info;
                        //if (type == 'e') icon = ToolTipIcon.Error;
                        //if (type == 'w') icon = ToolTipIcon.Warning;
                        //NIMainNotify.ShowBalloonTip(time, title, text, icon);

                        ToastForm.Display(title, text, type, time, clickAction);
                    }));
                    R.Log.V($"弹出Tost：{title}，持续：{time} ms");
                }
                catch { }
            }
        }
    }
}
