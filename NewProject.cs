using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class NewProject : Form
    {
        //声明参数
        private readonly Project _project;
        //工程路径
        public static string ProjectPath = Properties.Settings.Default.InstallationPath + "/project";
        //启动事件
        public NewProject()
        {
            InitializeComponent();
            //默认工程路径
            textBox2.Text = ProjectPath + "/" + textBox1.Text.Replace(" ", "");
        }
        //接收参数
        public NewProject(Project project) : this()
        {
            _project = project;
        }
        //创建工程
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            //判断工程文件夹是否存在
            if (!Directory.Exists(textBox2.Text))
            {
                //不存在 创建工程
                Directory.CreateDirectory(textBox2.Text);
                //创建工程首文件
                FileStream fs1 = new FileStream(textBox2.Text + "/init.config", FileMode.Create);
                byte[] data1 = System.Text.Encoding.Default.GetBytes(Properties.Resources.LuaConfig);
                fs1.Write(data1, 0, data1.Length);
                fs1.Flush();
                fs1.Close();
                FileStream fs2 = new FileStream(textBox2.Text + "/Main.lua", FileMode.Create);
                byte[] data2 = System.Text.Encoding.Default.GetBytes(Properties.Resources.Main);
                fs2.Write(data2, 0, data2.Length);
                fs2.Flush();
                fs2.Close();
                string config2 = System.IO.File.ReadAllText(textBox2.Text + "/init.config", Encoding.Default);
                config2 = config2.Replace(@"AndLuaPlus", textBox1.Text);
                FileStream fs3 = new FileStream(textBox2.Text + "/init.config", FileMode.Create);
                byte[] data3 = System.Text.Encoding.Default.GetBytes(config2);
                fs3.Write(data3, 0, data3.Length);
                fs3.Flush();
                fs3.Close();
                //刷新工程
                _project.LoadProject();
                //关闭窗口
                this.Close();
            }
            else
            {
                //存在
                MessageBox.Show("该文件夹已被占用，你必须重新选择一个有效的文件夹，以继续创建你的应用程序。", "提示");
            }
        }
        //取消
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //实时更新工程路径 并且去除工程文件夹包含的空格
            textBox2.Text = ProjectPath + "/" + textBox1.Text.Replace(" ", "");
        }
    }
}
