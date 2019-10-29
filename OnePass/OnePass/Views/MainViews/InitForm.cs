using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.IOUtils.TxtUtils;
using OnePass.Commons;
using OnePass.Modules.UserModules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnePass.Views.MainViews
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string email = TbxEmail.Text;
            string password = TbxPassword.Text;
            if (Str.Ok(email, password))
            {
                bool f1 = UserHelper.Create(email, password);
                if (f1)
                {
                    R.Toast.Show("创建账号", $"已为您创建账号：{email}，请妥善保存密码，丢失无法恢复。");
                    Close();
                }
                else
                {
                    R.Toast.Show("创建账号", $"创建账号：{email}失败。", 'e');
                }
            }
        }
    }
}
