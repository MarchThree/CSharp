using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_05enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)man.傻2);
            Console.WriteLine(">========================<");
            Console.WriteLine(Enum.GetName(typeof(week),1));
            Console.WriteLine(">========================<");
            string[] weeks = Enum.GetNames(typeof(week));
            Console.WriteLine(">========================<");
            foreach (string s in weeks) {
                Console.WriteLine(s);
            }
            Console.WriteLine(">========================<");
            for (int i=0;i<weeks.Length;i++) {
                Console.WriteLine("{0}|{1}",i,weeks[i]);
            }
            Console.WriteLine(">========================<");
            Array weekArr= Enum.GetValues(typeof(week));
            Console.WriteLine(weekArr.GetValue(0));
            Console.WriteLine(">========================<");
            Type t= Enum.GetUnderlyingType(typeof(sex));
            Console.WriteLine(t);
            Console.WriteLine(">========================<");
            int i2 = 1;
            string s2 = Enum.Parse(typeof(week), i2.ToString()).ToString();
            Console.WriteLine(s2);
            Console.WriteLine(">==========555==============<");
            string item = "Moneday";
            object oi= Enum.Parse(typeof(week), item);
            Console.WriteLine((int)oi);
            Console.ReadKey();
        }
        enum man {
            傻婶=1,
            傻2=2,
            傻3=3
        }

        enum sex : byte {
            male=0,
            fmale=1
        }

        enum week {
            Sunday = 0,
            Moneday =1,
            Tuesday=2,
            Wednesday=3,
            Thursday=8,
            Friday=5,
            Saturday=6
        }
    }
}
