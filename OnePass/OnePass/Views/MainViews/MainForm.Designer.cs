namespace OnePass.Views.MainViews
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SsMain = new System.Windows.Forms.StatusStrip();
            this.CmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MsMain = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.技术支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐私声明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于OnePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNMain = new System.Windows.Forms.Panel();
            this.PNDetail = new System.Windows.Forms.Panel();
            this.PNItem = new System.Windows.Forms.Panel();
            this.PNType = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.打开主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsMain.SuspendLayout();
            this.MsMain.SuspendLayout();
            this.PNMain.SuspendLayout();
            this.PNType.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsMain
            // 
            this.SsMain.Location = new System.Drawing.Point(0, 375);
            this.SsMain.Name = "SsMain";
            this.SsMain.Size = new System.Drawing.Size(704, 22);
            this.SsMain.TabIndex = 0;
            this.SsMain.Text = "statusStrip1";
            // 
            // CmsMain
            // 
            this.CmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开主界面ToolStripMenuItem,
            this.锁定ToolStripMenuItem,
            this.toolStripSeparator3,
            this.退出ToolStripMenuItem});
            this.CmsMain.Name = "contextMenuStrip1";
            this.CmsMain.Size = new System.Drawing.Size(113, 76);
            // 
            // MsMain
            // 
            this.MsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MsMain.Location = new System.Drawing.Point(0, 0);
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(704, 25);
            this.MsMain.TabIndex = 2;
            this.MsMain.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.切换ToolStripMenuItem,
            this.备份ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送反馈ToolStripMenuItem,
            this.toolStripSeparator1,
            this.技术支持ToolStripMenuItem,
            this.隐私声明ToolStripMenuItem,
            this.toolStripSeparator2,
            this.关于OnePassToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // 技术支持ToolStripMenuItem
            // 
            this.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem";
            this.技术支持ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.技术支持ToolStripMenuItem.Text = "技术支持";
            // 
            // 隐私声明ToolStripMenuItem
            // 
            this.隐私声明ToolStripMenuItem.Name = "隐私声明ToolStripMenuItem";
            this.隐私声明ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.隐私声明ToolStripMenuItem.Text = "隐私声明";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // 关于OnePassToolStripMenuItem
            // 
            this.关于OnePassToolStripMenuItem.Name = "关于OnePassToolStripMenuItem";
            this.关于OnePassToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.关于OnePassToolStripMenuItem.Text = "关于 OnePass";
            // 
            // PNMain
            // 
            this.PNMain.Controls.Add(this.PNDetail);
            this.PNMain.Controls.Add(this.PNItem);
            this.PNMain.Controls.Add(this.PNType);
            this.PNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNMain.Location = new System.Drawing.Point(0, 25);
            this.PNMain.Name = "PNMain";
            this.PNMain.Size = new System.Drawing.Size(704, 350);
            this.PNMain.TabIndex = 3;
            // 
            // PNDetail
            // 
            this.PNDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.PNDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNDetail.Location = new System.Drawing.Point(340, 0);
            this.PNDetail.Name = "PNDetail";
            this.PNDetail.Size = new System.Drawing.Size(364, 350);
            this.PNDetail.TabIndex = 2;
            // 
            // PNItem
            // 
            this.PNItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PNItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNItem.Location = new System.Drawing.Point(120, 0);
            this.PNItem.Name = "PNItem";
            this.PNItem.Size = new System.Drawing.Size(220, 350);
            this.PNItem.TabIndex = 1;
            // 
            // PNType
            // 
            this.PNType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.PNType.Controls.Add(this.label1);
            this.PNType.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNType.Location = new System.Drawing.Point(0, 0);
            this.PNType.Name = "PNType";
            this.PNType.Size = new System.Drawing.Size(120, 350);
            this.PNType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "全部";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NiMain
            // 
            this.NiMain.ContextMenuStrip = this.CmsMain;
            this.NiMain.Text = "notifyIcon1";
            this.NiMain.Visible = true;
            // 
            // 打开主界面ToolStripMenuItem
            // 
            this.打开主界面ToolStripMenuItem.Name = "打开主界面ToolStripMenuItem";
            this.打开主界面ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开主界面ToolStripMenuItem.Text = "主界面";
            // 
            // 锁定ToolStripMenuItem
            // 
            this.锁定ToolStripMenuItem.Name = "锁定ToolStripMenuItem";
            this.锁定ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.锁定ToolStripMenuItem.Text = "锁定";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(109, 6);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // 切换ToolStripMenuItem
            // 
            this.切换ToolStripMenuItem.Name = "切换ToolStripMenuItem";
            this.切换ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切换ToolStripMenuItem.Text = "切换";
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份ToolStripMenuItem.Text = "备份";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 397);
            this.Controls.Add(this.PNMain);
            this.Controls.Add(this.SsMain);
            this.Controls.Add(this.MsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MsMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePass";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CmsMain.ResumeLayout(false);
            this.MsMain.ResumeLayout(false);
            this.MsMain.PerformLayout();
            this.PNMain.ResumeLayout(false);
            this.PNType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SsMain;
        private System.Windows.Forms.ContextMenuStrip CmsMain;
        private System.Windows.Forms.MenuStrip MsMain;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.Panel PNMain;
        private System.Windows.Forms.Panel PNDetail;
        private System.Windows.Forms.Panel PNItem;
        private System.Windows.Forms.Panel PNType;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 技术支持ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐私声明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 关于OnePassToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NiMain;
        private System.Windows.Forms.ToolStripMenuItem 打开主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
    }
}