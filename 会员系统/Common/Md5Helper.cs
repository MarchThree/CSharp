using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace 会员系统.Common
{
    public class Md5Helper
    {
        public static string getStrMd5(string str) {
            string strMd5="";
            byte[] data = Encoding.Default.GetBytes(str);
            MD5 mymd5 =new MD5CryptoServiceProvider();
            byte[] result = mymd5.ComputeHash(data);
            for (int i=0;i<result.Length;i++) {
                strMd5 += result[i].ToString("X2"); ;
            }
            return strMd5;
        }
    }
}
