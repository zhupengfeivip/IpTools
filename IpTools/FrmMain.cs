using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IpTools
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public string HttpGet(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        private void btnGetInternetIp_Click(object sender, EventArgs e)
        {
            try
            {
                string api = "https://api.myip.com/";
                string respStr = HttpGet(api);
                rtbxLog.Text = respStr;
                JObject jo = (JObject)JsonConvert.DeserializeObject(respStr);
                if (jo == null)
                {
                    MessageBox.Show(this, "返回数据格式无法解析", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (jo["ip"] != null)
                    txtInternetIp.Text = jo["ip"].ToString();

                if (jo["country"] != null)
                    txtCountry.Text = jo["country"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
