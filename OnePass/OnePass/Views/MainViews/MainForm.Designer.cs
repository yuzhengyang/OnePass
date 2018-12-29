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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNMain = new System.Windows.Forms.Panel();
            this.PNDetail = new System.Windows.Forms.Panel();
            this.PNItem = new System.Windows.Forms.Panel();
            this.PNType = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.隐私声明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于OnePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMain.SuspendLayout();
            this.PNMain.SuspendLayout();
            this.PNType.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(704, 25);
            this.MSMain.TabIndex = 2;
            this.MSMain.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
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
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            // 
            // 技术支持ToolStripMenuItem
            // 
            this.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem";
            this.技术支持ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.技术支持ToolStripMenuItem.Text = "技术支持";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 397);
            this.Controls.Add(this.PNMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MSMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MSMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePass";
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.PNMain.ResumeLayout(false);
            this.PNType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip MSMain;
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
    }
}