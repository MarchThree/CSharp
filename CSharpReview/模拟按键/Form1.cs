using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 模拟按键
{
    public partial class Form1 : Form
    {

        //获取窗口标题
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText(
        IntPtr hWnd,//窗口句柄
        StringBuilder lpString,//标题
        int nMaxCount //最大值
        );

        //获取类的名字
        [DllImport("user32.dll")]
        private static extern int GetClassName(
        IntPtr hWnd,//句柄
        StringBuilder lpString, //类名
        int nMaxCount //最大值
        );

        //根据坐标获取窗口句柄
        [DllImport("user32")]
        private static extern IntPtr WindowFromPoint(
        Point Point  //坐标
        );
        public Form1()
        {
            InitializeComponent();
        }
        bool stat = false;
        bool ishas = false;
        Thread t;
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = txtmsg.Text;
            if (msg=="") {
                msg = "136815986";
            }
            int num = Convert.ToInt32(txtnum.Text);
            int time = Convert.ToInt32(txttime.Text);
            para p = new para();
            p.num = num;
            p.time = time;
            p.msg = msg;
            if (!ishas) {

                t = new Thread(sendMsg);
                t.SetApartmentState(ApartmentState.STA);
                t.Start(p);
                button1.Text = "停止";
                ishas = true;
            }else if(ishas) {
                    t.Abort();
                    ishas = false;
                button1.Text = "开始";
            }
           
            
        }

        public static void sendMsg(object a) {
            para pa = (para)a;
            int num = pa.num;
           int time =pa.time;
            string msg=pa.msg;
            Clipboard.SetDataObject(msg);
            Thread.Sleep(time*1000);
            for (int i=0;i< num;i++) {
                SendKeys.SendWait("^a");
                Thread.Sleep(50);
                SendKeys.SendWait("{BACKSPACE}");
                Thread.Sleep(50);
                SendKeys.SendWait("^v");
                Thread.Sleep(50);
                SendKeys.SendWait("%s");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        struct para {
            public int num;
            public int time;
            public string msg;
        }
    }
}
