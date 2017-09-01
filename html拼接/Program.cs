using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace html拼接
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("html.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs,Encoding.Default);
            FileStream fout = new FileStream("out.txt",FileMode.OpenOrCreate);
            StreamWriter swout = new StreamWriter(fout);
            while (!sr.EndOfStream) {
                string temp = "'"+sr.ReadLine().Trim()+"'+";
                swout.WriteLine(temp);
            }
            sr.Close();
            fs.Close();
            swout.Close();
            fout.Close();

        }
    }
}
