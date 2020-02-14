namespace AndLuaPlus
{
    partial class Loading
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
            this.ucProcessLine1 = new HZH_Controls.Controls.UCProcessLine();
            this.SuspendLayout();
            // 
            // ucProcessLine1
            // 
            this.ucProcessLine1.BackColor = System.Drawing.Color.White;
            this.ucProcessLine1.BorderColor = System.Drawing.Color.White;
            this.ucProcessLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine1.ForeColor = System.Drawing.Color.Black;
            this.ucProcessLine1.Location = new System.Drawing.Point(7, 2);
            this.ucProcessLine1.MaxValue = 100;
            this.ucProcessLine1.Name = "ucProcessLine1";
            this.ucProcessLine1.Size = new System.Drawing.Size(477, 23);
            this.ucProcessLine1.TabIndex = 0;
            this.ucProcessLine1.Text = "ucProcessLine1";
            this.ucProcessLine1.Value = 0;
            this.ucProcessLine1.ValueBGColor = System.Drawing.Color.White;
            this.ucProcessLine1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ucProcessLine1.ValueTextType = HZH_Controls.Controls.ValueTextType.None;
            // 
            // Loading
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 31);
            this.Controls.Add(this.ucProcessLine1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AndLua+";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCProcessLine ucProcessLine1;
    }
}
