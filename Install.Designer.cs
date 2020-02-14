namespace AndLuaPlus
{
    partial class Install
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
            this.ucStep1 = new HZH_Controls.Controls.UCStep();
            this.ucProcessLine1 = new HZH_Controls.Controls.UCProcessLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucStep1
            // 
            this.ucStep1.BackColor = System.Drawing.Color.White;
            this.ucStep1.Enabled = false;
            this.ucStep1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucStep1.ImgCompleted = null;
            this.ucStep1.LineWidth = 2;
            this.ucStep1.Location = new System.Drawing.Point(249, 220);
            this.ucStep1.Name = "ucStep1";
            this.ucStep1.Size = new System.Drawing.Size(320, 80);
            this.ucStep1.StepBackColor = System.Drawing.Color.Silver;
            this.ucStep1.StepFontColor = System.Drawing.Color.White;
            this.ucStep1.StepForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucStep1.StepIndex = 1;
            this.ucStep1.Steps = new string[] {
        "准备",
        "解压",
        "安装",
        "完成"};
            this.ucStep1.StepWidth = 35;
            this.ucStep1.TabIndex = 0;
            // 
            // ucProcessLine1
            // 
            this.ucProcessLine1.BorderColor = System.Drawing.Color.Silver;
            this.ucProcessLine1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProcessLine1.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine1.Location = new System.Drawing.Point(173, 350);
            this.ucProcessLine1.MaxValue = 100;
            this.ucProcessLine1.Name = "ucProcessLine1";
            this.ucProcessLine1.Size = new System.Drawing.Size(394, 35);
            this.ucProcessLine1.TabIndex = 1;
            this.ucProcessLine1.Text = "ucProcessLine1";
            this.ucProcessLine1.Value = 1;
            this.ucProcessLine1.ValueBGColor = System.Drawing.Color.Silver;
            this.ucProcessLine1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucProcessLine1.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            this.ucProcessLine1.ValueChanged += new System.EventHandler(this.ucProcessLine1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ucProcessLine1);
            this.panel1.Controls.Add(this.ucStep1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 437);
            this.panel1.TabIndex = 3;
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
            // Install
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Install";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在安装...";
            this.Shown += new System.EventHandler(this.install_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCStep ucStep1;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
