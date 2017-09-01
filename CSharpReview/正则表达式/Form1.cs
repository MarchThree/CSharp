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
using System.Text.RegularExpressions;

namespace 正则表达式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Open("1.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            str= str.Replace("\r\n","");
            Regex reg = new Regex(".*placeholder=\"请输入厂商名称\" value=\"(?<name>.*?)\".*placeholder=\"请输入厂商域名\" value=\"(?<doman>.*?)\" />.*");
            Match m = reg.Match(str);
            string res = m.Groups["doman"].Value;
            txtres.Text = res;
        }
    }
}
