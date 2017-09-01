using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myarray =new int[1,2,3];
            int[,,] treearr = { {{ 1,2}, { 3,4} }, { { 5,6}, { 7,8} } };
            // Console.WriteLine(treearr[1,0,0]);
            int[][] juc= { new int[]{ 1,2,3}, new int[]{ 4,5},new int[] { 7,8,9,10} };
            for (int i=0;i<juc.Length;i++) {
                for (int j=0;j<juc[i].Length;j++) {
                    Console.Write("{0} ", juc[i][j]);
                }
                Console.WriteLine();
            }
            Type t = typeof(int);
            Array a= Array.CreateInstance(t,10);
            int[] ar = new int[3] { 1,2,3};
            int[] br = (int[])ar.Clone();
            Console.WriteLine("{0}:{1}",ar[1],br[1]);
            ar[1] = 66;
            Console.WriteLine("{0}-{1}",ar[1],br[1]);

            //分段取数组

            int[] ar1 = { 1,2,3,4,5,6,7,8,9};
            int[] ar2 = {10,11,12,13,14,15,16,17,18,19};
            var arr3 = new ArraySegment<int>[]{ new ArraySegment<int>(ar1, 4,2),new ArraySegment<int>(ar1,4,4)};
            foreach (var k in arr3) {
               // Console.WriteLine(k.Offset);
                Console.WriteLine(k.Array[4]);
            }
           
           // Console.WriteLine(juc[1].Length);
           // Console.WriteLine(juc[2][3]);
            Console.ReadKey();
        }
    }
}
