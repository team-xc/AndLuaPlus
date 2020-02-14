using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AndLuaPlus
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        //关闭窗口
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        //重写横向居中方法
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int x;
            int y;
            //Logo
            x = (int)(0.5 * (this.Width - pictureBox1.Width));
            y = pictureBox1.Location.Y;
            pictureBox1.Location = new System.Drawing.Point(x, y);
            //软件名称Logo
            x = (int)(0.5 * (this.Width - label2.Width));
            y = label2.Location.Y;
            label2.Location = new System.Drawing.Point(x, y);
            //软件说明
            x = (int)(0.5 * (this.Width - label1.Width));
            y = label1.Location.Y;
            label1.Location = new System.Drawing.Point(x, y);
        }
    }
}
