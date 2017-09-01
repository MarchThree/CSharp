using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;

namespace 补天公益src列表获取
{
    public partial class Form1 : Form
    {
        public static object flag = new object();
        public static StreamWriter wr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cookie = txtcookie.Text;
            FileStream fs = new FileStream("url.txt", FileMode.Append);
            wr = new StreamWriter(fs);
            deleSrc des = new deleSrc(getSrc);
            for (int i=0;i<1;i++) {
                Thread t = new Thread(new ParameterizedThreadStart(des));
                t.IsBackground = true;
                t.Start(cookie);
            }
            
        }

        public delegate void deleSrc(object s);
        public void getSrc(object obj) {
            string cookie = obj.ToString();
            httphelper hp = new httphelper();
            StreamReader sr = new StreamReader("list.txt",Encoding.Default);
            int num = 0;
            bool key=false;
            while (!sr.EndOfStream) {
                string[] temp = sr.ReadLine().Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);
                string id = temp[0].Trim();
                Random r = new Random();
                int time = r.Next(1000,2000);
                lock (flag) {
                    hp.Url = "http://loudong.360.cn/Loo/submit?cid="+ id;
                    hp.Cookie = cookie;
                    if (key) {
                        Thread.Sleep(time);
                        string s = id + "|" + temp[1] + "|" + hp.getUrl();
                        wr.WriteLine(s);
                        wr.Flush();
                    }
                    if (id == "3820")
                    {
                        key = true;
                    }
                    num++;
                    if (txtnum.InvokeRequired)
                    {
                        dedeSet ds = new dedeSet(setValue);
                        txtnum.Invoke(ds,num.ToString());
                    }
                    else
                    {
                        txtnum.Text =num.ToString();
                    }
                }
            }
            wr.Close();
        }

        public delegate void dedeSet(object s);
        public void setValue(object o) {
            txtnum.Text = o.ToString();
        }

    }
}
