using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 类型判断
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("url.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            httphelper hp = new httphelper();
            while (!sr.EndOfStream) {
                string s = sr.ReadLine();
                string[] temp = s.Split('|');
                Console.WriteLine(temp[2]);
                try {
                    string url = temp[2];
                    url.Replace("http://","");
                    hp.Url = "http://" + url + "/index.asp";
                    if (hp.getCode()==200) {
                        FileStream fasp = new FileStream("./result/asp.txt", FileMode.Append);
                        StreamWriter swasp = new StreamWriter(fasp,Encoding.Unicode);
                        swasp.WriteLine(url);
                        swasp.Close();
                        fasp.Close();
                        continue;
                    }

                    hp.Url = "http://" + url + "/index.php";
                    if (hp.getCode() == 200)
                    {
                        FileStream fphp = new FileStream("./result/php.txt", FileMode.Append);
                        StreamWriter swphp = new StreamWriter(fphp,Encoding.Unicode);
                        swphp.WriteLine(url);
                        swphp.Close();
                        fphp.Close();
                        continue;
                    }

                    hp.Url = "http://" + url + "/index.aspx";
                    if (hp.getCode() == 200)
                    {
                        FileStream faspx = new FileStream("./result/aspx.txt", FileMode.Append);
                        StreamWriter swaspx = new StreamWriter(faspx,Encoding.Unicode);
                        swaspx.WriteLine(url);
                        swaspx.Close();
                        faspx.Close();
                        continue;
                    }

                    hp.Url = "http://" + url + "/index.jsp";
                    if (hp.getCode() == 200)
                    {
                        FileStream fjsp = new FileStream("./result/aspx.txt", FileMode.Append);
                        StreamWriter swjsp = new StreamWriter(fjsp,Encoding.Unicode);
                        swjsp.WriteLine(url);
                        swjsp.Close();
                        fjsp.Close();
                        continue;
                    }

                    FileStream other = new FileStream("./result/other.txt", FileMode.Append);
                    StreamWriter swother = new StreamWriter(other,Encoding.Unicode);
                    swother.WriteLine(url);
                    swother.Close();
                    other.Close();
                }
                catch (Exception ex) {
                    FileStream flog = new FileStream("./log/log2.txt",FileMode.Append);
                    StreamWriter sw = new StreamWriter(flog,Encoding.Unicode);
                    sw.Write(ex.ToString());
                    sw.Close();
                    flog.Close();
                    continue;
                }
            }
        }
    }
}
