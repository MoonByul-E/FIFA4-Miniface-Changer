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
using Newtonsoft.Json.Linq;
using System.IO;

namespace FIFA4_Miniface_Changer
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public JObject getAPI(string URL) //URL의 API를 구해옵니다.
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            string Text = Reader.ReadToEnd();

            JObject Object = JObject.Parse(Text);

            return Object;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tabControl_Login.SelectedIndex = 0;
        }

        private void button_Login_Click(object sender, EventArgs e) // 로그인 버튼 클릭
        {
            if(textBox_Login_ID.Text == "") // 로그인 아이디가 비어있을때
            {
                MessageBox.Show("아이디를 입력해 주세요.", "Error");
                textBox_Login_ID.Focus();
            }
            else if (textBox_Login_PW.Text == "") // 로그인 비밀번호가 비어있을때
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "Error");
                textBox_Login_PW.Focus();
            }
            else // 둘다 입력됬을때
            {
                JObject Result = getAPI("http://221.163.172.198:7777/login/login?ID=" + textBox_Login_ID.Text + "&PW=" + textBox_Login_PW.Text);
                
                if(Result["Result"].ToString() == "ID Error" || Result["Result"].ToString() == "PW Error") // 아이디를 찾을수 없을때 또는 비밀번호가 일치하지 않을때
                {
                    MessageBox.Show("아이디가 존재하지 않거나, 비밀번호가 맞지 않습니다.", "Error");
                    textBox_Login_ID.Focus();
                }
                else // 로그인 성공
                {
                    string Token = Result["Token"].ToString();
                    ((mainForm)(this.Owner)).Token = Token;
                    this.Close();
                }
            }
        }
    }
}
