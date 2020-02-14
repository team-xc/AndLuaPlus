using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using LuaInterface;
using HZH_Controls;
using HZH_Controls.Forms;
using System.Configuration;
using System.Linq;

/*
 *AndLua+ v1.0
 * Copyright 2020-02-01
 * Author: Alone
 * My Blog:  http://ly250.cn/
 * Github: https://github.com/LingYang8/AndLuaPlus
 */

namespace AndLuaPlus
{

    //初始化窗口
    public partial class AndLua : Form
    {
        //声明当前窗口
        public static AndLua form1;
        //实例化Lua编辑器
        TextEditor LuaEditor = new TextEditor();
        // Lua解释器
        Lua lua = new Lua();
        //实例化功能库
        AndLuaFun andlua = new AndLuaFun();
        //当前打开的Lua文件路径
        string NowLuaFile = "‪";
        //工程配置文件
        public static string ProjectConfig = "";
        //工程路径
        public static string ProjectPath = "";
        //窗口载入事件
        public AndLua(string projectpath)
        {
            InitializeComponent();
            //接收参数
            this.NowLuaFile = projectpath + "/main.lua";
            ProjectConfig = projectpath + "/init.config";
            ProjectPath = projectpath;
            RefreshTitle();
            //把当前窗口赋值
            form1 = this;
            //行号
            LuaEditor.ShowLineNumbers = true;
            //边距
            LuaEditor.Padding = new System.Windows.Thickness(0);
            //字体
            LuaEditor.FontFamily = new System.Windows.Media.FontFamily("Console");
            LuaEditor.FontSize = 14;
            //Lua语法高亮
            LuaEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("Lua");
            //将Editor作为ElemetnHost的组件
            Editor.Child = LuaEditor;
            //实例化Lua核心库
            LuaFun luafun = new LuaFun();
            //注册核心库方法到Lua
            lua.RegisterFunction("print", luafun, luafun.GetType().GetMethod("print"));
        }
        //鼠标右键菜单
        /* -----------------------------------------------------------------------------------------*/
        /* -----------------------------------------------------------------------------------------*/
        //窗口第一次显示时执行
        private void Form1_Shown(object sender, EventArgs e)
        {
            //全屏
            // this.WindowState = FormWindowState.Maximized;
            //Lua语法高亮
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("AndLuaPlus.Resources.Lua.xshd"));
            var xshd = HighlightingLoader.LoadXshd(reader);
            LuaEditor.SyntaxHighlighting = HighlightingLoader.Load(xshd, HighlightingManager.Instance);
            //加载Lua文件
            LuaEditor.Text = andlua.readFile(NowLuaFile);
        }

        //日志组件自动滚动到底部
        private void outputText_TextChanged(object sender, EventArgs e)
        {
            OutPutText.SelectionStart = OutPutText.Text.Length;
            OutPutText.ScrollToCaret();
        }

        //菜单选项
        /* -----------------------------------------------------------------------------------------*/
        private void 运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //保存Lua代码
                andlua.writeFile(NowLuaFile, LuaEditor.Text);
                //运行Lua文件
                lua.DoFile(NowLuaFile);
            }
            catch (Exception ex)
            {
                //运行Lua文件错误处理
                andlua.outPut(ex.Message);
            }
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile addfile = new AddFile(this, ProjectPath);
            addfile.ShowDialog();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Filedialog = new OpenFileDialog();
            Filedialog.Multiselect = false;//禁止选择多个文件
            Filedialog.Title = "请选择一个文件";
            Filedialog.Filter = "所有文件(*.*)|*.*";
            Filedialog.InitialDirectory = ProjectPath;
            if (Filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenFile(Filedialog.FileName);
            }
        }
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.Delete(NowLuaFile);
            OpenFile(ProjectPath + "/main.lua");
        }
        /* -----------------------------------------------------------------------------------------*/
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
        //刷新标题
        public void RefreshTitle()
        {
            this.Text = "AndLua+ - " + GetConfig("Name") + " - [ " + NowLuaFile + " ]";
        }
        //打开文件
        public void OpenFile(string file)
        {
            if (File.Exists(file))
            {
                if (File.Exists(NowLuaFile))
                {
                    //保存Lua代码
                    andlua.writeFile(NowLuaFile, LuaEditor.Text);
                }
                this.LuaEditor.Text = andlua.readFile(file);
                NowLuaFile = file;
                RefreshTitle();
            }
        }
    }

    //Lua核心库
    public class LuaFun
    {
        //打印
        public void print(string str1, string str2 = null, string str3 = null, string str4 = null, string str5 = null, string str6 = null, string str7 = null, string str8 = null, string str9 = null, string str10 = null)
        {
            AndLuaFun obj = new AndLuaFun();
            obj.outPut(str1, str2, str3, str4, str5, str6, str7, str8, str9, str10);
        }
    }
    //AndLua+辅助库
    class AndLuaFun
    {
        //输出日志
        public void outPut(string str1, string str2 = null, string str3 = null, string str4 = null, string str5 = null, string str6 = null, string str7 = null, string str8 = null, string str9 = null, string str10 = null)
        {
            if (str2 != null)
            {
                str1 = str1 + "    " + str2;
            }
            if (str3 != null)
            {
                str1 = str1 + "    " + str3;
            }
            if (str4 != null)
            {
                str1 = str1 + "    " + str4;
            }
            if (str5 != null)
            {
                str1 = str1 + "    " + str5;
            }
            if (str6 != null)
            {
                str1 = str1 + "    " + str6;
            }
            if (str7 != null)
            {
                str1 = str1 + "    " + str7;
            }
            if (str8 != null)
            {
                str1 = str1 + "    " + str8;
            }
            if (str9 != null)
            {
                str1 = str1 + "    " + str9;
            }
            if (str10 != null)
            {
                str1 = str1 + "    " + str10;
            }
            AndLua.form1.OutPutText.Text = AndLua.form1.OutPutText.Text + Environment.NewLine + "[" + DateTime.Now.ToString("HH:mm:ss:fff") + "]" + "  " + str1;
        }
        //读取文件
        public string readFile(string path)
        {
            string filetext = File.ReadAllText(path, Encoding.Default);
            return filetext;
        }
        //写入文件
        public void writeFile(string path, string text)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(text);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }
    }
}