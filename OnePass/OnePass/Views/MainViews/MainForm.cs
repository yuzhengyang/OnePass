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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();

            R.User.Email = IniTool.GetString(R.Files.Settings, "User", "Email", "");
            R.User.PasswordCode = IniTool.GetString(R.Files.Settings, "User", "PasswordCode", "");
            if (Str.Ok(R.User.Email, R.User.PasswordCode)) R.User.Password = AesTool.Decrypt(R.User.PasswordCode, R.User.Email);

            if (Str.Ok(R.User.Email, R.User.Password, R.User.PasswordCode))
            {

            }
            else
            {
                new InitForm().ShowDialog();
                if (Str.Ok(R.User.Email, R.User.Password, R.User.PasswordCode))
                {
                    Close();
                }
                else
                {
                    Exit();
                }
            }
        }
        public void Exit()
        {
            Invoke(new Action(() =>
            {
                Close();
                Application.Exit();
            }));
        }
    }
}
