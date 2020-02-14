namespace AndLuaPlus
{
    partial class Project
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewProject = new HZH_Controls.Controls.UCBtnExt();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectList = new CCWin.SkinControl.ChatListBox();
            this.ProjectListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开工程toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.ProjectListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NewProject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 26);
            this.panel1.TabIndex = 1;
            // 
            // NewProject
            // 
            this.NewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewProject.BackColor = System.Drawing.Color.White;
            this.NewProject.BtnBackColor = System.Drawing.Color.White;
            this.NewProject.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewProject.BtnForeColor = System.Drawing.Color.White;
            this.NewProject.BtnText = "New Project";
            this.NewProject.CausesValidation = false;
            this.NewProject.ConerRadius = 6;
            this.NewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProject.EnabledMouseEffect = true;
            this.NewProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.NewProject.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.NewProject.IsRadius = true;
            this.NewProject.IsShowRect = false;
            this.NewProject.IsShowTips = false;
            this.NewProject.Location = new System.Drawing.Point(862, 0);
            this.NewProject.Margin = new System.Windows.Forms.Padding(2);
            this.NewProject.Name = "NewProject";
            this.NewProject.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.NewProject.RectWidth = 1;
            this.NewProject.Size = new System.Drawing.Size(99, 26);
            this.NewProject.TabIndex = 2;
            this.NewProject.TabStop = false;
            this.NewProject.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.NewProject.TipsText = "";
            this.NewProject.BtnClick += new System.EventHandler(this.NewProject_BtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "My project";
            // 
            // ProjectList
            // 
            this.ProjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectList.BackColor = System.Drawing.Color.White;
            this.ProjectList.CausesValidation = false;
            this.ProjectList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProjectList.ForeColor = System.Drawing.Color.Black;
            this.ProjectList.FriendsMobile = false;
            this.ProjectList.ItemColor = System.Drawing.Color.White;
            this.ProjectList.ItemMouseOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProjectList.ListSubItemMenu = this.ProjectListMenu;
            this.ProjectList.Location = new System.Drawing.Point(11, 12);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.SelectSubItem = null;
            this.ProjectList.Size = new System.Drawing.Size(963, 537);
            this.ProjectList.SubItemColor = System.Drawing.Color.White;
            this.ProjectList.SubItemMenu = null;
            this.ProjectList.SubItemMouseOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProjectList.SubItemSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProjectList.TabIndex = 2;
            this.ProjectList.TabStop = false;
            this.ProjectList.DoubleClick += new System.EventHandler(this.ProjectList_DoubleClick);
            // 
            // ProjectListMenu
            // 
            this.ProjectListMenu.BackColor = System.Drawing.Color.White;
            this.ProjectListMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProjectListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开工程toolStripMenuItem1,
            this.删除工程ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem});
            this.ProjectListMenu.Name = "ProjectListMenu";
            this.ProjectListMenu.ShowImageMargin = false;
            this.ProjectListMenu.Size = new System.Drawing.Size(112, 70);
            // 
            // 打开工程toolStripMenuItem1
            // 
            this.打开工程toolStripMenuItem1.Name = "打开工程toolStripMenuItem1";
            this.打开工程toolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.打开工程toolStripMenuItem1.Text = "打开工程";
            this.打开工程toolStripMenuItem1.Click += new System.EventHandler(this.打开工程toolStripMenuItem1_Click);
            // 
            // 删除工程ToolStripMenuItem
            // 
            this.删除工程ToolStripMenuItem.Name = "删除工程ToolStripMenuItem";
            this.删除工程ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.删除工程ToolStripMenuItem.Text = "删除工程";
            this.删除工程ToolStripMenuItem.Click += new System.EventHandler(this.删除工程ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // Project
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProjectList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Project";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to AndLua+ and My project(0)";
            this.Shown += new System.EventHandler(this.Project_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ProjectListMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt NewProject;
        public System.Windows.Forms.Label label1;
        public CCWin.SkinControl.ChatListBox ProjectList;
        private System.Windows.Forms.ContextMenuStrip ProjectListMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开工程toolStripMenuItem1;
    }
}
