using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.IOUtils.TxtUtils;
using OnePass.Commons;
using OnePass.Models.UserModels;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            R.User.Email = TbxEmail.Text;
            R.User.Passcode = TbxPassword.Text;
            if (Str.Ok(R.User.Email, R.User.Passcode))
            {
                R.User.Passcode = AesTool.Encrypt(MD5Tool.Encrypt(R.User.Passcode), R.User.Email);
                if (UserHelper.Login(R.User.Email, R.User.Passcode))
                {
                    R.Toast.Show("登录", "登陆成功");
                    Close();
                }
                else
                {
                    R.Toast.Show("登录", "登陆失败", 'e');
                }
            }
        }

        private void LbCreateAccount_Click(object sender, EventArgs e)
        {
            new InitForm().ShowDialog();
        }
    }
}
