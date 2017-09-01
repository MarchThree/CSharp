using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace getAlicount
{
    public static class cookiehelper
    {
        public static CookieContainer retCookieCon(string strCookie,Uri url) {
            string[] cookies = strCookie.Split(new char[]{ ';'},StringSplitOptions.RemoveEmptyEntries);
            CookieContainer cookiecontent = new CookieContainer();
            foreach (string cookieItem in cookies) {
                string[] kv = cookieItem.Split('=');
                Cookie ck = new Cookie();
                ck.Name = kv[0].Trim();
                ck.Value = kv[1];
                cookiecontent.Add(url,ck);
            }
            return cookiecontent;
        }
    }
}
