using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.IOUtils.TxtUtils;
using OnePass.Commons;
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
            if (Str.Ok(TbxEmail.Text, TbxPassword.Text))
            {
                R.User.Email = TbxEmail.Text;
                R.User.Passcode = ;

                IniTool.Set(R.Files.Settings, "User", "Email", R.User.Email);
                IniTool.Set(R.Files.Settings, "User", "PasswordCode", R.User.PasswordCode);
                R.Toast.Show("创建账号",$"已为您创建账号：{R.User.Email}，请妥善保存密码，丢失无法恢复。");
                Close();
            }
        }
    }
}
