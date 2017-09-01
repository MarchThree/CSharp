using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace 水表
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        KaiGuan myKaiGuan;
        ShuiBiao myShuiBiao;
        ShuiChi myShuiChi;

        private void main_Load(object sender, EventArgs e)
        {
            myKaiGuan = new KaiGuan();
            myShuiBiao = new ShuiBiao();
            myShuiChi = new ShuiChi();
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {


        }

        private void groubshuichi_Paint(object sender, PaintEventArgs e)
        {

            Graphics gr = e.Graphics;
            Pen pe = new Pen(Color.Black, 4);
            gr.DrawLine(pe, 40, 50, 40, 230);
            gr.DrawLine(pe, 40, 230, 530, 230);
            gr.DrawLine(pe, 530, 230, 530, 50);

            test();
        }

        public void test()
        {
            myShuiChi.setLiuLiang(myKaiGuan.SuDu);
            Graphics gt = groubshuichi.CreateGraphics();
            Pen pe = new Pen(Color.Black, 4);
            int h = 180 - (Convert.ToInt32(myShuiChi.Height));
            Rectangle rec = new Rectangle(42, 230-(Convert.ToInt32(myShuiChi.Height)), 486, Convert.ToInt32(myShuiChi.Height));
            SolidBrush sb = new SolidBrush(Color.SeaGreen);
            gt.FillRectangle(sb, rec);
        }

        private void btnkg_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (myKaiGuan.Stat == 0) {
                myKaiGuan.Stat = 1;
                timer1.Start();
                btnkg.Text = "关";
            }
            else if (myKaiGuan.Stat==1) {
                myKaiGuan.Stat = 0;
                btnkg.Text = "开";
                timer1.Stop();
            }
        }

        public void Option(object source, System.Timers.ElapsedEventArgs e)
        {
           
            
        }

        public void showShuiBiao() {
            labhao.Text = myShuiBiao.Hao.ToString();
            labge.Text = myShuiBiao.Ge.ToString();
            labshi.Text = myShuiBiao.Shi.ToString();
            labbai.Text = myShuiBiao.Bai.ToString();
            labqian.Text = myShuiBiao.Qing.ToString();
            labwan.Text = myShuiBiao.Wan.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myKaiGuan.SuDu = traBliu.Value;
            myShuiBiao.setNum(myKaiGuan.SuDu);
            showShuiBiao();
            test();
        }
    }
}
