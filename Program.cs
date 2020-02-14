using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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
    static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/libs") == false)
            {
                deszip("libs1", AppDomain.CurrentDomain.BaseDirectory + "/libs1.zip");
                if (Compress(AppDomain.CurrentDomain.BaseDirectory + "/", AppDomain.CurrentDomain.BaseDirectory + "/libs1.zip", null) != "Success")
                {
                    MessageBox.Show("初始化错误！", "提示");
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
        }
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        {
            string _resName = "AndLuaPlus.libs." + new AssemblyName(e.Name).Name + ".dll";
            using (var _stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_resName))
            {
                byte[] _data = new byte[_stream.Length];
                _stream.Read(_data, 0, _data.Length);
                return Assembly.Load(_data);
            }
        }
        public static string Compress(string DirPath, string ZipPath, string ZipPWD)
        {
            FastZip fz = new FastZip();
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
        public static void deszip(string filename, string path)
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
    }
}
