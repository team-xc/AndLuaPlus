namespace AndLuaPlus
{
    partial class AddFile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.no = new HZH_Controls.Controls.UCBtnExt();
            this.ok = new HZH_Controls.Controls.UCBtnExt();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 187);
            this.panel1.TabIndex = 1;
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.White;
            this.no.BtnBackColor = System.Drawing.Color.White;
            this.no.BtnFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.no.BtnForeColor = System.Drawing.Color.Black;
            this.no.BtnText = "取消";
            this.no.ConerRadius = 5;
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.EnabledMouseEffect = true;
            this.no.FillColor = System.Drawing.Color.White;
            this.no.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.no.IsRadius = true;
            this.no.IsShowRect = true;
            this.no.IsShowTips = false;
            this.no.Location = new System.Drawing.Point(310, 162);
            this.no.Margin = new System.Windows.Forms.Padding(0);
            this.no.Name = "no";
            this.no.RectColor = System.Drawing.Color.Silver;
            this.no.RectWidth = 1;
            this.no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.no.Size = new System.Drawing.Size(70, 25);
            this.no.TabIndex = 5;
            this.no.TabStop = false;
            this.no.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.no.TipsText = "";
            this.no.BtnClick += new System.EventHandler(this.no_BtnClick);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.White;
            this.ok.BtnBackColor = System.Drawing.Color.White;
            this.ok.BtnFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.ok.BtnForeColor = System.Drawing.Color.White;
            this.ok.BtnText = "创建";
            this.ok.ConerRadius = 5;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.EnabledMouseEffect = true;
            this.ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ok.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ok.IsRadius = true;
            this.ok.IsShowRect = true;
            this.ok.IsShowTips = false;
            this.ok.Location = new System.Drawing.Point(390, 162);
            this.ok.Margin = new System.Windows.Forms.Padding(0);
            this.ok.Name = "ok";
            this.ok.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ok.RectWidth = 1;
            this.ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ok.Size = new System.Drawing.Size(70, 25);
            this.ok.TabIndex = 4;
            this.ok.TabStop = false;
            this.ok.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ok.TipsText = "";
            this.ok.BtnClick += new System.EventHandler(this.ok_BtnClick);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FileName.Location = new System.Drawing.Point(3, 24);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(454, 23);
            this.FileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // AddFile
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建文件";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt no;
        private HZH_Controls.Controls.UCBtnExt ok;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label1;
    }
}
