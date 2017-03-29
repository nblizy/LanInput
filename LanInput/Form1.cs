using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_OPEN_URL_Click(object sender, EventArgs e)
        {
            webb.Navigate(textBox_URL_Show.Text.ToString());
        }

        private void webb_NewWindow(object sender, CancelEventArgs e)
        {
            //打开新窗口的方式是在已有的窗口内打开
            webb.Url = new Uri(((WebBrowser)sender).StatusText);
            e.Cancel = true;

        }

        private void webb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // 页面跳转后改变地址栏地址
           // webb.Dispose();
            textBox_URL_Show.Text = webb.Url.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 释放WEB资源
            webb.Dispose();
        }
    }
}
