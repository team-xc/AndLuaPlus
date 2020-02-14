using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{
    public partial class Welcome : Form
    {
        //载入事件
        public Welcome()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.InstallationPath;
        }
        //窗口第一次显示事件
        private void Welcome_Shown(object sender, EventArgs e)
        {
        }
        //重写横向居中方法
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int x;
            int y;
            //开始安装按钮
            x = (int)(0.5 * (this.Width - ucBtnExt1.Width));
            y = ucBtnExt1.Location.Y;
            ucBtnExt1.Location = new System.Drawing.Point(x, y);
            //Logo图片
            x = (int)(0.5 * (this.Width - pictureBox1.Width));
            y = pictureBox1.Location.Y;
            pictureBox1.Location = new System.Drawing.Point(x, y);
            //安装路径文本
            x = (int)(0.5 * (this.Width - panel2.Width));
            y = panel2.Location.Y;
            panel2.Location = new System.Drawing.Point(x, y);
            //软件名称Logo
            x = (int)(0.5 * (this.Width - label1.Width));
            y = label1.Location.Y;
            label1.Location = new System.Drawing.Point(x, y);
        }
        //选择安装目录
        private void ucBtnImg2_BtnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.SelectedPath = this.textBox1.Text;
            path.Description = "请选择一个有效的AndLua+安装路径，相关的文件以及你创建的工程都会在此文件夹。";
            path.ShowDialog();
            this.textBox1.Text = path.SelectedPath;
        }
        //开始安装
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            //配置文件路径
            string configPath = textBox1.Text + "/andlua.config";
            //判断配置文件是否存在
            if (System.IO.File.Exists(configPath))
            {
                //存在 弹出是否重新安装
                if (MessageBox.Show("重新安装将会删除你所有的安装文件，包括你的Lua支持库，但这操作并不会删除你的Lua工程。", "检测到当前目录已存在安装文件，是否重新安装？", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //保存安装路径
                    Properties.Settings.Default["InstallationPath"] = textBox1.Text;
                    Properties.Settings.Default.Save();
                    //重新安装
                    Form install = new Install();
                    this.Hide();
                    install.ShowDialog();
                    Application.ExitThread();
                }
            }
            else
            {
                //保存安装路径
                Properties.Settings.Default["InstallationPath"] = textBox1.Text;
                Properties.Settings.Default.Save();
                //不存在 跳转安装
                Form install = new Install();
                this.Hide();
                install.ShowDialog();
                Application.ExitThread();
            }
        }
    }
}
