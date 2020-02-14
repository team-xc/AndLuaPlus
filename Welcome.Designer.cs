namespace AndLuaPlus
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.ucWave1 = new HZH_Controls.Controls.UCWave();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucBtnImg2 = new HZH_Controls.Controls.UCBtnImg();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucWave1
            // 
            this.ucWave1.Location = new System.Drawing.Point(-7, 367);
            this.ucWave1.Name = "ucWave1";
            this.ucWave1.Size = new System.Drawing.Size(799, 100);
            this.ucWave1.TabIndex = 0;
            this.ucWave1.Text = "ucWave1";
            this.ucWave1.WaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucWave1.WaveHeight = 20;
            this.ucWave1.WaveSleep = 30;
            this.ucWave1.WaveWidth = 270;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ucBtnExt1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 349);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(324, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "AndLua+";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucBtnImg2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(282, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 25);
            this.panel2.TabIndex = 2;
            // 
            // ucBtnImg2
            // 
            this.ucBtnImg2.BackColor = System.Drawing.Color.White;
            this.ucBtnImg2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImg2.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.ucBtnImg2.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg2.BtnText = "";
            this.ucBtnImg2.ConerRadius = 5;
            this.ucBtnImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImg2.EnabledMouseEffect = true;
            this.ucBtnImg2.FillColor = System.Drawing.Color.White;
            this.ucBtnImg2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg2.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg2.Image")));
            this.ucBtnImg2.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg2.ImageFontIcons = ((object)(resources.GetObject("ucBtnImg2.ImageFontIcons")));
            this.ucBtnImg2.IsRadius = false;
            this.ucBtnImg2.IsShowRect = false;
            this.ucBtnImg2.IsShowTips = false;
            this.ucBtnImg2.Location = new System.Drawing.Point(164, 0);
            this.ucBtnImg2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg2.Name = "ucBtnImg2";
            this.ucBtnImg2.RectColor = System.Drawing.Color.White;
            this.ucBtnImg2.RectWidth = 1;
            this.ucBtnImg2.Size = new System.Drawing.Size(36, 23);
            this.ucBtnImg2.TabIndex = 2;
            this.ucBtnImg2.TabStop = false;
            this.ucBtnImg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImg2.TipsText = "";
            this.ucBtnImg2.BtnClick += new System.EventHandler(this.ucBtnImg2_BtnClick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Program Files (x86)\\AndLuaPlus";
            this.textBox1.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "开始安装";
            this.ucBtnExt1.ConerRadius = 40;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = false;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(282, 200);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(200, 40);
            this.ucBtnExt1.TabIndex = 0;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // Welcome
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucWave1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AndLua+ v1.0 Powered By Alone";
            this.Shown += new System.EventHandler(this.Welcome_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCWave ucWave1;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private HZH_Controls.Controls.UCBtnImg ucBtnImg2;
        private System.Windows.Forms.Label label1;
    }
}
