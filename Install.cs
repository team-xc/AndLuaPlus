using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{
    public partial class Install : Form
    {
        //安装路径
        public static string InstallationPath = Properties.Settings.Default.InstallationPath;
        //实例化FastZip
        public static FastZip fz = new FastZip();
        public Install()
        {
            InitializeComponent();
        }
        //重写横向居中方法
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int x;
            int y;
            //步骤条
            x = (int)(0.5 * (this.Width - ucStep1.Width));
            y = ucStep1.Location.Y;
            ucStep1.Location = new System.Drawing.Point(x, y);
            //Logo图片
            x = (int)(0.5 * (this.Width - pictureBox1.Width));
            y = pictureBox1.Location.Y;
            pictureBox1.Location = new System.Drawing.Point(x, y);
            //进度条
            x = (int)(0.5 * (this.Width - ucProcessLine1.Width));
            y = ucProcessLine1.Location.Y;
            ucProcessLine1.Location = new System.Drawing.Point(x, y);
            //软件名称Logo
            x = (int)(0.5 * (this.Width - label1.Width));
            y = label1.Location.Y;
            label1.Location = new System.Drawing.Point(x, y);
        }
        //进度条监听
        private void ucProcessLine1_ValueChanged(object sender, EventArgs e)
        {
            if (ucProcessLine1.Value == 26)
            {
                this.ucStep1.StepIndex = 2;
            }
            else if (ucProcessLine1.Value == 51)
            {
                this.ucStep1.StepIndex = 3;
            }
            else if (ucProcessLine1.Value == 76)
            {
                this.ucStep1.StepIndex = 4;
            }
            else if (ucProcessLine1.Value == 100)
            {
                System.Diagnostics.Process.Start(InstallationPath + "/AndLua+.exe");
                System.Environment.Exit(0);
            }
        }
        //窗口显示时事件  
        private void install_Shown(object sender, EventArgs e)
        {
            //开始安装

            //创建相关文件和文件夹
            //创建安装目录
            if (!Directory.Exists(InstallationPath))
            {
                Directory.CreateDirectory(InstallationPath);
                for (int i = 0; i < 6; i++) { Delay(50); ucProcessLine1.Value = i; } // 5
            }
            //创建配置文件
            for (int i = 5; i < 11; i++) { Delay(50); ucProcessLine1.Value = i; } // 10
            string config = @"<?xml version=""1.0"" encoding=""utf-8"" ?><configuration><appSettings><add key = ""var"" value = """ + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + @"""></add></appSettings></configuration> ";
            FileStream fs = new FileStream(InstallationPath + "/andlua.config", FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(config);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
            //创建lua文件库目录
            if (!Directory.Exists(InstallationPath + "/lua"))
            {
                Directory.CreateDirectory(InstallationPath + "/lua");
                for (int i = 10; i < 16; i++) { Delay(50); ucProcessLine1.Value = i; } // 15
            }
            //创建dll文件库目录
            if (!Directory.Exists(InstallationPath + "/libs"))
            {
                Directory.CreateDirectory(InstallationPath + "/libs");
                for (int i = 15; i < 21; i++) { Delay(50); ucProcessLine1.Value = i; } // 20
            }
            //创建工程文件目录
            if (!Directory.Exists(InstallationPath + "/project"))
            {
                Directory.CreateDirectory(InstallationPath + "/project");
                for (int i = 20; i < 26; i++) { Delay(50); ucProcessLine1.Value = i; } // 25
            }

            //解压Dll资源包
            ucProcessLine1.Value = 26;
            deszip("libs", InstallationPath + "/libs.zip");
            if (Compress(InstallationPath + "/libs", InstallationPath + "/libs.zip", null) != "Success")
            {
                MessageBox.Show("安装错误！", "提示");
            }
            for (int i = 26; i < 41; i++) { Delay(50); ucProcessLine1.Value = i; } // 40
            //解压Lua资源包
            deszip("lua", InstallationPath + "/lua.zip");
            if (Compress(InstallationPath + "/lua", InstallationPath + "/lua.zip", null) != "Success")
            {
                MessageBox.Show("安装错误！", "提示");
            }
            for (int i = 40; i < 51; i++) { Delay(50); ucProcessLine1.Value = i; } // 50

            //安装程序
            ucProcessLine1.Value = 51;
            //创建执行文件
            System.IO.File.Copy(System.Windows.Forms.Application.ExecutablePath, InstallationPath + "/AndLua+.exe", true);
            for (int i = 51; i < 61; i++) { Delay(50); ucProcessLine1.Value = i; } // 60
            //创建配置文件
            FileStream fs1 = new FileStream(InstallationPath + "/AndLua+.exe.config", FileMode.Create);
            byte[] data1 = System.Text.Encoding.Default.GetBytes(Properties.Resources.AndLuaConfig);
            fs1.Write(data1, 0, data1.Length);
            fs1.Flush();
            fs1.Close();
            //修改安装路径
            string config2 = System.IO.File.ReadAllText(InstallationPath + "/AndLua+.exe.config", Encoding.Default);
            config2 = config2.Replace(@"C:/Program Files (x86)/AndLuaPlus", InstallationPath);
            FileStream fs3 = new FileStream(InstallationPath + "/AndLua+.exe.config", FileMode.Create);
            byte[] data3 = System.Text.Encoding.Default.GetBytes(config2);
            fs3.Write(data3, 0, data3.Length);
            fs3.Flush();
            fs3.Close();
            //创建快捷方式
            String shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "AndLuaPlus.lnk");
            if (!System.IO.File.Exists(shortcutPath))
            {
                String exePath = InstallationPath + "/AndLua+.exe";
                IWshShell shell = new WshShell();
                foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "*.lnk"))
                {
                    WshShortcut tempShortcut = (WshShortcut)shell.CreateShortcut(item);
                    if (tempShortcut.TargetPath == exePath)
                    {
                        return;
                    }
                }
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.Arguments = "";
                shortcut.Description = "Developer Alone";
                shortcut.WorkingDirectory = InstallationPath;
                shortcut.IconLocation = exePath;
                shortcut.WindowStyle = 1;
                shortcut.Save();
            }
            for (int i = 60; i < 76; i++) { Delay(50); ucProcessLine1.Value = i; } // 75

            //释放资源
            ucProcessLine1.Value = 76;
            DeleteFile(InstallationPath + "/libs.zip");
            DeleteFile(AppDomain.CurrentDomain.BaseDirectory + "/libs1.zip");
            DeleteFile(AppDomain.CurrentDomain.BaseDirectory + @"/HZH_Controls.dll");
            for (int i = 76; i < 86; i++) { Delay(50); ucProcessLine1.Value = i; } // 85
            DeleteFile(InstallationPath + "/lua.zip");

            for (int i = 85; i < 100; i++) { Delay(50); ucProcessLine1.Value = i; } // 99

            //安装完成
            Delay(1000);
            ucProcessLine1.Value = 100;
        }
        //删除文件
        public bool DeleteFile(string path1)
        {
            try
            {
                if (System.IO.File.Exists(path1))
                {
                    System.IO.File.Delete(path1);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //解压Zip
        public static string Compress(string DirPath, string ZipPath, string ZipPWD)
        {
            string state = "Fail...";
            try
            {
                fz.Password = ZipPWD;
                fz.ExtractZip(ZipPath, DirPath, null);
                state = "Success";
            }
            catch (Exception ex)
            {
                state += "," + ex.Message;
            }
            return state;
        }
        //读取Resource文件并保存到指定路径
        public void deszip(string filename, string path)
        {
            System.Resources.ResourceManager rm = Properties.Resources.ResourceManager;
            FileStream Stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bin = new BinaryFormatter();
            try
            {
                bin.Serialize(Stream, rm.GetObject(filename, null));
                Stream.Close();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
        //延迟代码
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
