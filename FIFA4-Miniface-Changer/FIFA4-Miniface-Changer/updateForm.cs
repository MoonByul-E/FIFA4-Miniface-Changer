using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.IO;

namespace FIFA4_Miniface_Changer
{
    public partial class updateForm : MetroForm
    {
        public updateForm()
        {
            InitializeComponent();
        }

        public string getVersion()
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/MoonByul-E/FIFA4-Miniface-Changer/main/Version");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            return Reader.ReadToEnd();
        }

        public string getUpdateLog()
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/MoonByul-E/FIFA4-Miniface-Changer/main/updateLog");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            return Reader.ReadToEnd();
        }

        public string getDownload()
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/MoonByul-E/FIFA4-Miniface-Changer/main/downloadLink");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            return Reader.ReadToEnd();
        }


        private void updateForm_Load(object sender, EventArgs e)
        {
            label_nowVersion.Text = "현재 버전: " + Properties.Settings.Default.nowVersion;
            label_newVersion.Text = "최신 버전: " + getVersion();

            label_UpdateLog_Value.Text = getUpdateLog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(getDownload());
        }
    }
}
