using System.Threading;

namespace LiuLiSSSpider
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_LastUpDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_StartUp = new System.Windows.Forms.Button();
            this.t_Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_pages = new System.Windows.Forms.TabControl();
            this.t_page1 = new System.Windows.Forms.TabPage();
            this.t_page2 = new System.Windows.Forms.TabPage();
            this.t_page3 = new System.Windows.Forms.TabPage();
            this.t_page4 = new System.Windows.Forms.TabPage();
            this.t_page5 = new System.Windows.Forms.TabPage();
            this.t_page6 = new System.Windows.Forms.TabPage();
            this.t_page7 = new System.Windows.Forms.TabPage();
            this.t_page8 = new System.Windows.Forms.TabPage();
            this.t_page9 = new System.Windows.Forms.TabPage();
            this.t_page10 = new System.Windows.Forms.TabPage();
            this.t_page11 = new System.Windows.Forms.TabPage();
            this.t_page12 = new System.Windows.Forms.TabPage();
            this.t_page13 = new System.Windows.Forms.TabPage();
            this.t_loges = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.t_pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_LastUpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.b_StartUp);
            this.groupBox1.Controls.Add(this.t_Url);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据更新";
            // 
            // l_LastUpDate
            // 
            this.l_LastUpDate.AutoSize = true;
            this.l_LastUpDate.Location = new System.Drawing.Point(164, 61);
            this.l_LastUpDate.Name = "l_LastUpDate";
            this.l_LastUpDate.Size = new System.Drawing.Size(157, 15);
            this.l_LastUpDate.TabIndex = 4;
            this.l_LastUpDate.Text = "上次更新时间显示区域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "上次更新时间：";
            // 
            // b_StartUp
            // 
            this.b_StartUp.Location = new System.Drawing.Point(539, 21);
            this.b_StartUp.Name = "b_StartUp";
            this.b_StartUp.Size = new System.Drawing.Size(75, 23);
            this.b_StartUp.TabIndex = 2;
            this.b_StartUp.Text = "开始更新";
            this.b_StartUp.UseVisualStyleBackColor = true;
            this.b_StartUp.Click += new System.EventHandler(this.b_StartUp_Click);
            // 
            // t_Url
            // 
            this.t_Url.Location = new System.Drawing.Point(128, 22);
            this.t_Url.Name = "t_Url";
            this.t_Url.Size = new System.Drawing.Size(388, 25);
            this.t_Url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "神社网址：";
            // 
            // t_pages
            // 
            this.t_pages.Controls.Add(this.t_page1);
            this.t_pages.Controls.Add(this.t_page2);
            this.t_pages.Controls.Add(this.t_page3);
            this.t_pages.Controls.Add(this.t_page4);
            this.t_pages.Controls.Add(this.t_page5);
            this.t_pages.Controls.Add(this.t_page6);
            this.t_pages.Controls.Add(this.t_page7);
            this.t_pages.Controls.Add(this.t_page8);
            this.t_pages.Controls.Add(this.t_page9);
            this.t_pages.Controls.Add(this.t_page10);
            this.t_pages.Controls.Add(this.t_page11);
            this.t_pages.Controls.Add(this.t_page12);
            this.t_pages.Controls.Add(this.t_page13);
            this.t_pages.Location = new System.Drawing.Point(28, 119);
            this.t_pages.Name = "t_pages";
            this.t_pages.SelectedIndex = 0;
            this.t_pages.Size = new System.Drawing.Size(814, 461);
            this.t_pages.TabIndex = 1;
            // 
            // t_page1
            // 
            this.t_page1.Location = new System.Drawing.Point(4, 25);
            this.t_page1.Name = "t_page1";
            this.t_page1.Padding = new System.Windows.Forms.Padding(3);
            this.t_page1.Size = new System.Drawing.Size(806, 432);
            this.t_page1.TabIndex = 0;
            this.t_page1.Text = "3D";
            this.t_page1.UseVisualStyleBackColor = true;
            // 
            // t_page2
            // 
            this.t_page2.Location = new System.Drawing.Point(4, 25);
            this.t_page2.Name = "t_page2";
            this.t_page2.Padding = new System.Windows.Forms.Padding(3);
            this.t_page2.Size = new System.Drawing.Size(806, 432);
            this.t_page2.TabIndex = 1;
            this.t_page2.Text = "三次";
            this.t_page2.UseVisualStyleBackColor = true;
            // 
            // t_page3
            // 
            this.t_page3.Location = new System.Drawing.Point(4, 25);
            this.t_page3.Name = "t_page3";
            this.t_page3.Padding = new System.Windows.Forms.Padding(3);
            this.t_page3.Size = new System.Drawing.Size(806, 432);
            this.t_page3.TabIndex = 2;
            this.t_page3.Text = "动画";
            this.t_page3.UseVisualStyleBackColor = true;
            // 
            // t_page4
            // 
            this.t_page4.Location = new System.Drawing.Point(4, 25);
            this.t_page4.Name = "t_page4";
            this.t_page4.Padding = new System.Windows.Forms.Padding(3);
            this.t_page4.Size = new System.Drawing.Size(806, 432);
            this.t_page4.TabIndex = 3;
            this.t_page4.Text = "半次";
            this.t_page4.UseVisualStyleBackColor = true;
            // 
            // t_page5
            // 
            this.t_page5.Location = new System.Drawing.Point(4, 25);
            this.t_page5.Name = "t_page5";
            this.t_page5.Padding = new System.Windows.Forms.Padding(3);
            this.t_page5.Size = new System.Drawing.Size(806, 432);
            this.t_page5.TabIndex = 4;
            this.t_page5.Text = "合集";
            this.t_page5.UseVisualStyleBackColor = true;
            // 
            // t_page6
            // 
            this.t_page6.Location = new System.Drawing.Point(4, 25);
            this.t_page6.Name = "t_page6";
            this.t_page6.Padding = new System.Windows.Forms.Padding(3);
            this.t_page6.Size = new System.Drawing.Size(806, 432);
            this.t_page6.TabIndex = 5;
            this.t_page6.Text = "图包";
            this.t_page6.UseVisualStyleBackColor = true;
            // 
            // t_page7
            // 
            this.t_page7.Location = new System.Drawing.Point(4, 25);
            this.t_page7.Name = "t_page7";
            this.t_page7.Padding = new System.Windows.Forms.Padding(3);
            this.t_page7.Size = new System.Drawing.Size(806, 432);
            this.t_page7.TabIndex = 6;
            this.t_page7.Text = "壁纸";
            this.t_page7.UseVisualStyleBackColor = true;
            // 
            // t_page8
            // 
            this.t_page8.Location = new System.Drawing.Point(4, 25);
            this.t_page8.Name = "t_page8";
            this.t_page8.Padding = new System.Windows.Forms.Padding(3);
            this.t_page8.Size = new System.Drawing.Size(806, 432);
            this.t_page8.TabIndex = 7;
            this.t_page8.Text = "御所汉化";
            this.t_page8.UseVisualStyleBackColor = true;
            // 
            // t_page9
            // 
            this.t_page9.Location = new System.Drawing.Point(4, 25);
            this.t_page9.Name = "t_page9";
            this.t_page9.Padding = new System.Windows.Forms.Padding(3);
            this.t_page9.Size = new System.Drawing.Size(806, 432);
            this.t_page9.TabIndex = 8;
            this.t_page9.Text = "游戏";
            this.t_page9.UseVisualStyleBackColor = true;
            // 
            // t_page10
            // 
            this.t_page10.Location = new System.Drawing.Point(4, 25);
            this.t_page10.Name = "t_page10";
            this.t_page10.Padding = new System.Windows.Forms.Padding(3);
            this.t_page10.Size = new System.Drawing.Size(806, 432);
            this.t_page10.TabIndex = 9;
            this.t_page10.Text = "漫画";
            this.t_page10.UseVisualStyleBackColor = true;
            // 
            // t_page11
            // 
            this.t_page11.Location = new System.Drawing.Point(4, 25);
            this.t_page11.Name = "t_page11";
            this.t_page11.Padding = new System.Windows.Forms.Padding(3);
            this.t_page11.Size = new System.Drawing.Size(806, 432);
            this.t_page11.TabIndex = 10;
            this.t_page11.Text = "独立";
            this.t_page11.UseVisualStyleBackColor = true;
            // 
            // t_page12
            // 
            this.t_page12.Location = new System.Drawing.Point(4, 25);
            this.t_page12.Name = "t_page12";
            this.t_page12.Padding = new System.Windows.Forms.Padding(3);
            this.t_page12.Size = new System.Drawing.Size(806, 432);
            this.t_page12.TabIndex = 11;
            this.t_page12.Text = "表番推荐";
            this.t_page12.UseVisualStyleBackColor = true;
            // 
            // t_page13
            // 
            this.t_page13.Location = new System.Drawing.Point(4, 25);
            this.t_page13.Name = "t_page13";
            this.t_page13.Padding = new System.Windows.Forms.Padding(3);
            this.t_page13.Size = new System.Drawing.Size(806, 432);
            this.t_page13.TabIndex = 12;
            this.t_page13.Text = "音声";
            this.t_page13.UseVisualStyleBackColor = true;
            // 
            // t_loges
            // 
            this.t_loges.Location = new System.Drawing.Point(28, 590);
            this.t_loges.Multiline = true;
            this.t_loges.Name = "t_loges";
            this.t_loges.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.t_loges.Size = new System.Drawing.Size(810, 142);
            this.t_loges.TabIndex = 2;
            this.t_loges.TextChanged += new System.EventHandler(this.t_loges_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 744);
            this.Controls.Add(this.t_loges);
            this.Controls.Add(this.t_pages);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.t_pages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_LastUpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_StartUp;
        private System.Windows.Forms.TextBox t_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl t_pages;
        private System.Windows.Forms.TabPage t_page1;
        private System.Windows.Forms.TabPage t_page2;
        private System.Windows.Forms.TabPage t_page3;
        private System.Windows.Forms.TabPage t_page4;
        private System.Windows.Forms.TabPage t_page5;
        private System.Windows.Forms.TabPage t_page6;
        private System.Windows.Forms.TabPage t_page7;
        private System.Windows.Forms.TabPage t_page8;
        private System.Windows.Forms.TabPage t_page9;
        private System.Windows.Forms.TabPage t_page10;
        private System.Windows.Forms.TabPage t_page11;
        private System.Windows.Forms.TabPage t_page12;
        private System.Windows.Forms.TabPage t_page13;
        public System.Windows.Forms.TextBox t_loges;
        public Thread t1;
        public Thread t2;
        public Thread t3;
    }
}

