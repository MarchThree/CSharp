using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace json解析
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("utl.txt", FileMode.Append);
            StreamWriter str = new StreamWriter(fs,Encoding.Default);
            httphelper hp = new httphelper();
            hp.Cookie = "__guid=90162694.1973851725759967500.1503058512999.4502; smidV2=2017081820150946acb5d6998f106324df3b5e418b615b6554068aabef76ef0; Q=u%3D360H1251635647%26n%3D%25O6%25NO%25O7%25OQ%25PR%25Q2%25Q1%25O0%25PO%25SQ%26le%3D%26m%3DZGHjWGWOWGWOWGWOWGWOWGWOZmL5%26qid%3D1251635647%26im%3D1_t01cd97a7b358b22921%26src%3Dpcw_webscan%26t%3D1; T=s%3D38ba673cca58e5a448418126147179bd%26t%3D1503058533%26lm%3D%26lf%3D2%26sk%3Ddddfe5816677a649e0f21caa17b8c8a1%26mt%3D1503058533%26rc%3D%26v%3D2.0%26a%3D1; PHPSESSID=s81jljul390ti0qcgelc6fdeh5; __q__=1503140855948";
            hp.Url = "https://butian.360.cn/Reward/pub";
            for (int i=25;i<150;i++) {
                Thread.Sleep(1500);
                string s = hp.postGetData("s=1&p="+i.ToString()+"&token=");
                var o = JsonConvert.DeserializeObject<Dictionary<string, object>>(s);
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(o["data"].ToString());
                List<cslist> list = JsonConvert.DeserializeObject<List<cslist>>(data["list"].ToString());
                foreach (cslist item in list)
                {
                    str.WriteLine(item.company_id + "|" + item.company_name);
                    Console.WriteLine(item.company_id + "|" + item.company_name);
                }
            }
            Console.Clear();
            str.Close();
            fs.Close();
            Console.ReadKey();
        }
    }

    public class cslist {
        public string avatar;
        public string company_id;
        public string company_name;
        public string industry;
    }
}
