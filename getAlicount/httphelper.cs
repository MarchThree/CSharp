using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace getAlicount
{
    public class httphelper
    {
        private string url;
        private string cookie;

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public string Cookie
        {
            get
            {
                return cookie;
            }

            set
            {
                cookie = value;
            }
        }

        public string getUrl() {
            try {
                string siteUrl = "";
                HttpWebRequest hrq = (HttpWebRequest)WebRequest.Create(this.url);
                hrq.Method = "GET";
                hrq.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5";
                hrq.ContentType = "application/json, text/javascript, */*; q=0.01";
                hrq.Timeout = 10000;
                string cookieHeader = cookie;
                WebProxy wp = new WebProxy();
                wp.Address = new Uri("http://127.0.0.1:8080");
                hrq.CookieContainer = cookiehelper.retCookieCon(cookieHeader, new Uri(url));
                // hrq.Proxy = wp;
                HttpWebResponse hrp = (HttpWebResponse)hrq.GetResponse();
                Stream sr = hrp.GetResponseStream();
                StreamReader sread = new StreamReader(sr, Encoding.UTF8);
                string res = sread.ReadToEnd();
                //res = res.Replace("\r\n", "");
                //Regex reg = new Regex(".*placeholder=\"请输入厂商名称\" value=\"(?<name>.*?)\".*placeholder=\"请输入厂商域名\" value=\"(?<doman>.*?)\" />.*");
                //Match m = reg.Match(res);
                // return m.Groups["name"].Value + ":" + m.Groups["doman"].Value;
                return res;
            }
            catch (Exception ex) {
                throw ex;
            }
            
           // return res;
        }

        public string postGetData(string data)
        {
            try
            {
                byte[] bytdata = Encoding.Default.GetBytes(data); ;
                HttpWebRequest hrq = (HttpWebRequest)WebRequest.Create(this.url);
                hrq.Method = "POST";
                hrq.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5";
                hrq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                hrq.Timeout = 10000;
                string cookieHeader = cookie;
                WebProxy wp = new WebProxy();
                wp.Address = new Uri("http://127.0.0.1:8080");
                hrq.Proxy = wp;
                hrq.CookieContainer = cookiehelper.retCookieCon(cookieHeader, new Uri(url));
                using (Stream sw=hrq.GetRequestStream()) {
                    sw.Write(bytdata,0,bytdata.Length);
                }
                HttpWebResponse hrp = (HttpWebResponse)hrq.GetResponse();
                Stream sr = hrp.GetResponseStream();
                StreamReader sread = new StreamReader(sr, Encoding.UTF8);
                string res = sread.ReadToEnd();
                return res;
            }
            catch (Exception ex)
            {
                FileStream fs = File.Open("log.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(ex.ToString());
                sw.Close();
                fs.Close();
                return "";
            }

            // return res;
        }

    }
}
