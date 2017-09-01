using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace winApi
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        [DllImport("kernel32.dll")]
        public static extern int GetShortPathName(string path,string shortpath,int shortleng);
        static void Main(string[] args)
        {
            /*
            MessageBox(0, "你好啊", "我好啊0", 0);
            MessageBox(0, "你好啊", "我好啊1", 1);
            MessageBox(0, "你好啊", "我好啊2", 2);
            MessageBox(0, "你好啊", "我好啊3", 3);
            MessageBox(0, "你好啊", "我好啊4", 4);
            MessageBox(0, "你好啊", "我好啊5", 5);
            MessageBox(0, "你好啊", "我好啊6", 6);
            MessageBox(0, "你好啊", "我好啊7", 7);
            
            for (int i=0;i<5;i++) {
               Console.WriteLine( MessageBox(0, "你好啊", "我好啊"+i,i));
            }
            */


        }
    }
}
