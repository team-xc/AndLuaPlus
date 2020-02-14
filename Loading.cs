using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{
    public partial class Loading : Form
    {
        //配置文件路径
        private static string configPath = Properties.Settings.Default.InstallationPath + "/andlua.config";
        public Loading()
        {
            InitializeComponent();
        }
        //窗口显示时事件 检查是否安装
        private void Loading_Shown(object sender, EventArgs e)
        {
            //延迟一下防止BUG
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < 100)
            {
                Application.DoEvents();
            }
            //进度条
            for (int i = 1; i < 100; i++)
            {
                ucProcessLine1.Value = i;
            }
            //读取配置文件的安装版本
            if (GetConfig("var") == System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
            {
                //版本一致 跳转工程界面
                Form Project = new Project();
                this.Hide();
                Project.ShowDialog();
                Application.ExitThread();
            }
            else
            {
                //版本不一致 跳转安装界面
                Form welcome = new Welcome();
                this.Hide();
                welcome.ShowDialog();
                Application.ExitThread();
            }
        }
        //读取配置文件
        private string GetConfig(string key)
        {
            if (System.IO.File.Exists(configPath))
            {
                ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
                ecf.ExeConfigFilename = configPath;
                Configuration config = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
                var keys = config.AppSettings.Settings.AllKeys.ToList();
                if (keys == null || keys.Count == 0)
                {
                    return "";
                }
                if (keys.Contains(key))
                {
                    return config.AppSettings.Settings[key].Value.ToString();
                }
            }
            else
            {
                //配置文件不存在 跳转安装界面
                Form welcome = new Welcome();
                this.Hide();
                welcome.ShowDialog();
                Application.ExitThread();
            }
            return "";
        }
        //Delay function
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
    }
}

