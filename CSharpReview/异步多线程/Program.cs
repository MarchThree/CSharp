using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace 异步多线程
{
    class Program
    {
        public delegate string deleTest(int i);
        //public delegate void callB(IAsyncResult a);

        public static string sleep(int time) {
            Thread.Sleep(time);
            Console.WriteLine(time);
            return "返回了";
        }
        static void Main(string[] args)
        {
            var client = HttpWebRequest.Create("http://www.cnblogs.com/afei-24/p/6757361.html");
            client.BeginGetResponse(ar=> {  client.EndGetResponse(ar); },client);
            deleTest dt = new deleTest(sleep);
            AsyncCallback cb = new AsyncCallback(sleepOver);
            IAsyncResult a;
            a=  dt.BeginInvoke(1000,cb,dt);
            Console.WriteLine("6666666");
            Thread.Sleep(2000);
          //  Console.WriteLine(dt.EndInvoke(a));
            Console.ReadKey();
        }

        static void sleepOver(IAsyncResult dt) {
            Thread.Sleep(1000);
            deleTest dt2 = (deleTest)dt.AsyncState;
            Console.WriteLine(dt2.EndInvoke(dt));
            Console.WriteLine("over");
        }
    }
}
