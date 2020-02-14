using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{
    public partial class AddFile : Form
    {
        //声明参数
        private readonly AndLua _andlua;
        //工程路径
        string ProjectPath = "";
        public AddFile()
        {
            InitializeComponent();

        }
        //接收参数
        public AddFile(AndLua andlua, string file) : this()
        {
            _andlua = andlua;
            ProjectPath = file;
        }
        private void no_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        //新建文件
        private void ok_BtnClick(object sender, EventArgs e)
        {
            if (FileName.Text != "")
            {
                if (File.Exists(ProjectPath + "/" + FileName.Text))
                {
                    MessageBox.Show("该文件已存在，你必须重新输入一个有效的文件名称，以继续创建你的项目文件。", "提示");
                }
                else
                {
                    FileStream fs = new FileStream(ProjectPath + "/" + FileName.Text, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(Properties.Resources.Main);
                    sw.Close();
                    _andlua.OpenFile(ProjectPath + "/" + FileName.Text);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
