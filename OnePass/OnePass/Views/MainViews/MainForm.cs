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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();

            if (UserHelper.IsLogin(R.Data))
            {
                Text = $"OnePass - {R.Data.User.Email}";
            }
            else
            {
                Exit();
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
