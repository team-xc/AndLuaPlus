using CCWin.SkinControl;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{
    public partial class Project : Form
    {
        //工程路径
        public static string ProjectPath = Properties.Settings.Default.InstallationPath + "/project";
        //工程配置文件
        private static string ProjectConfig = "";
        //统计项目数量
        public static int ProjectNum = 0;
        //载入事件
        public Project()
        {
            InitializeComponent();
        }
        //窗口第一次显示时事件
        private void Project_Shown(object sender, EventArgs e)
        {
            //设置标题
            this.Text = "Welcome to AndLua+ (" + System.Environment.UserName + ")";
            LoadProject();
        }
        //加载工程
        public void LoadProject()
        {
            //清空工程列表
            ProjectList.Items.Clear();
            ProjectNum = 0;
            //一些没用的东西
            ChatListItem item = new ChatListItem("My Project");
            //工程数据
            DirectoryInfo[] di = new DirectoryInfo(ProjectPath).GetDirectories();
            for (int i = 0; i < di.Length; i++)
            {
                ProjectConfig = di[i].FullName + "/init.config";
                //判断文件是否存在
                if (File.Exists(ProjectConfig))
                {
                    ChatListSubItem sub = new ChatListSubItem();
                    //判断工程配置文件是否读取错误
                    if (GetConfig("Name") == "Project Config File Error")
                    {
                        //配置文件损坏 工程名称标红
                        sub.IsVip = true;
                    }
                    //判断图标文件是否存在
                    if (File.Exists(di[i].FullName + "/icon.png"))
                    {
                        //存在 使用工程图标
                        sub.HeadImage = new Bitmap(di[i].FullName + "/icon.png");
                    }
                    else
                    {
                        //不存在 使用默认图标
                        sub.HeadImage = Properties.Resources.icon;
                    }
                    sub.NicName = GetConfig("Var");
                    sub.DisplayName = GetConfig("Name");
                    sub.PersonalMsg = di[i].FullName;
                    item.SubItems.Add(sub);
                    ProjectList.Items.Add(item);
                    ProjectNum += 1;
                }
            }
            //展开工程
            ProjectList.ExpandAll();
            //设置统计
            label1.Text = "My project (" + ProjectNum + ")";
        }
        //读取配置文件
        private string GetConfig(string key)
        {
            if (System.IO.File.Exists(ProjectConfig))
            {
                ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
                ecf.ExeConfigFilename = ProjectConfig;
                Configuration config = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
                var keys = config.AppSettings.Settings.AllKeys.ToList();
                if (keys == null || keys.Count == 0)
                {
                    return "Project Config File Error";
                }
                if (keys.Contains(key))
                {
                    return config.AppSettings.Settings[key].Value.ToString();
                }
            }
            return "Project Config File Error";
        }
        //新建工程
        private void NewProject_BtnClick(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject(this);
            newProject.ShowDialog();
        }
        //右键菜单##########################################################
        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转工程目录
            System.Diagnostics.Process.Start("explorer.exe", this.ProjectList.SelectSubItem.PersonalMsg);
        }

        private void 打开工程toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AndLua andlua = new AndLua(this.ProjectList.SelectSubItem.PersonalMsg);
            this.Hide();
            andlua.ShowDialog();
            Application.ExitThread();
        }

        private void 删除工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.Delete(this.ProjectList.SelectSubItem.PersonalMsg, true);
            //刷新工程
            LoadProject();
        }

        //双击打开工程
        private void ProjectList_DoubleClick(object sender, EventArgs e)
        {
            AndLua andlua = new AndLua(this.ProjectList.SelectSubItem.PersonalMsg);
            this.Hide();
            andlua.ShowDialog();
            Application.ExitThread();
        }
        //###############################################################
    }
}
