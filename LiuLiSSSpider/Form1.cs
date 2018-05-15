using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiuLiSSSpider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_StartUp_Click(object sender, EventArgs e)
        {

            GetStates.GetZhuHtml(t_Url.Text);
            t1 = new Thread(() =>
            {
                //GetStates.GetZhuHtml(t_Url.Text);
                GetStates.GetAllHtml(this, 6, 6, "t1");
            });

            t2 = new Thread(() =>
            {
                //GetStates.GetZhuHtml(t_Url.Text);
                GetStates.GetAllHtml(this, 10, 10, "t2");
            });

            t3 = new Thread(() =>
            {
                //GetStates.GetZhuHtml(t_Url.Text);
                GetStates.GetAllHtml(this, 12, 12, "t3");
            });

            t1.Start();
            t2.Start();
            t3.Start();

            b_StartUp.Enabled = false;

            //t1.Join();
            //t2.Join();
            //t3.Join();

            b_StartUp.Enabled = true;
        }

        private void t_loges_TextChanged(object sender, EventArgs e)
        {
            this.t_loges.Select(this.t_loges.TextLength, 0);//光标定位到文本最后
            this.t_loges.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t_Url.Text = "https://blog.reimu.net/";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
