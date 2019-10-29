using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.IOUtils.TxtUtils;
using OnePass.Commons;
using OnePass.Models.UserModels;
using OnePass.Modules.PassModules;
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
            string email = TbxEmail.Text;
            string password = TbxPassword.Text;
            if (Str.Ok(email, password))
            {
                string passcode = PassHelper.EnPasscode(email, password);
                if (UserHelper.Login(email, passcode))
                {
                    R.Data.User.Email = email;
                    R.Data.User.Passcode = passcode;
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
