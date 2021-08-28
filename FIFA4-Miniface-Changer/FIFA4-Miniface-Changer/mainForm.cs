using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;

namespace FIFA4_Miniface_Changer
{
    public partial class mainForm : MetroForm
    {
        string FIFA4_Location = "C:\\Nexon\\EA SPORTS(TM) FIFA ONLINE 4";

        List<string> playerNameList = new List<string>();
        List<string> playerCodeList = new List<string>();

        List<string> searchPlayerNameList = new List<string>();
        List<string> searchPlayerCodeList = new List<string>();

        bool ifSearch = false;

        public mainForm()
        {
            InitializeComponent();
        }

        public JArray getAPI(string URL)
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            string Text = Reader.ReadToEnd();

            JArray Array = JArray.Parse(Text);

            return Array;
        }

        public bool getAPI_Photo(string URL)
        {
            bool return_bool = false;
            try
            {
                //Get Data
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                //Encoding
                Stream Stream = Response.GetResponseStream();
                StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
                string Text = Reader.ReadToEnd();
                Console.WriteLine(Text);

                return_bool = true;
            }
            catch(Exception ex)
            {
                return_bool = false;
            }

            return return_bool;
        }

        //listbox 처음 상태로 로딩
        public void load_ListBox()
        {
            listbox_Character.Items.Clear();
            listbox_Character.BeginUpdate();
            for(int i = 0; i < playerNameList.Count; i++)
            {
                listbox_Character.Items.Add(playerNameList[i]);
            }
            listbox_Character.EndUpdate();
            searchPlayerNameList = new List<string>();
            searchPlayerCodeList = new List<string>();
            ifSearch = false;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            label_nowLocation.Text = "현재 위치: " + FIFA4_Location;
            try
            {
                JArray seasonList = getAPI("https://static.api.nexon.co.kr/fifaonline4/latest/seasonid.json");
                JArray playerList = getAPI("https://static.api.nexon.co.kr/fifaonline4/latest/spid.json");

                //get Season Data
                List<string> seasonId = new List<string>();
                List<string> seasonName = new List<string>();
                List<string> seasonIcon = new List<string>();

                foreach (JToken season in seasonList)
                {
                    //get seasonId
                    seasonId.Add(season["seasonId"].ToString());
                    //get seasonName
                    seasonName.Add(season["className"].ToString().Split('(')[0].TrimEnd());
                    //get seasonIcon
                    seasonIcon.Add(season["seasonImg"].ToString());
                }

                //get Player Data
                foreach (JToken player in playerList)
                {
                    string playerSeasonName = "";
                    string playerSeason = player["id"].ToString().Substring(0, 3);
                    playerSeasonName = seasonName[seasonId.IndexOf(playerSeason)];

                    playerNameList.Add("[" + playerSeasonName + "] " + player["name"]);
                    playerCodeList.Add(player["id"].ToString());
                }

                load_ListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can`t load Data.", "Error");
                Console.WriteLine(ex);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            
            if(textbox_Search.Text == "")
            {
                //검색을 하지 않았을때
                if(ifSearch == false)
                {
                    MessageBox.Show("검색하실 선수의 이름을 입력해주세요.", "Error");
                    textbox_Search.Focus();
                }
                //검색을 했었을때
                else
                {
                    load_ListBox();
                }
            }
            else
            {
                //첫 검색이 아닐때
                if(ifSearch == true)
                {
                    load_ListBox();
                }

                for (int i = 0; i < listbox_Character.Items.Count; i++)
                {
                    if(listbox_Character.Items[i].ToString().IndexOf(textbox_Search.Text) != -1)
                    {
                        searchPlayerNameList.Add(listbox_Character.Items[i].ToString());
                        searchPlayerCodeList.Add(playerCodeList[i].ToString());
                    }
                }

                listbox_Character.Items.Clear();

                listbox_Character.BeginUpdate();
                for (int j = 0; j < searchPlayerNameList.Count; j++)
                {
                    listbox_Character.Items.Add(searchPlayerNameList[j]);
                }
                listbox_Character.EndUpdate();
                ifSearch = true;
            }
        }

        private void textbox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_Search_Click(sender, e);
            }
        }

        string check_local_Image(string location, string code)
        {
            FileInfo fileInfo = new FileInfo(FIFA4_Location + "\\_cache\\live\\externalAssest\\common\\" + location + "\\p" + code + ".png");
            if (fileInfo.Exists)
            {
                return FIFA4_Location + "\\_cache\\live\\externalAssest\\common\\" + location + "\\p" + code + ".png";
            }
            else
            {
                return null;
            }
        }

        private void listbox_Character_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> playersName = playerNameList;
            List<string> playersCode = playerCodeList;

            if (ifSearch == true)
            {
                playersName = searchPlayerNameList;
                playersCode = searchPlayerCodeList;
            }

            string fileLocation = "";
            string fileCode = "";
            string tempurl = "";

            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png";

                fileLocation = "playersAction";
                fileCode = playersCode[listbox_Character.SelectedIndex];
            }
            catch(Exception ex)
            {
                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                    tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png";

                    fileLocation = "players";
                    fileCode = playersCode[listbox_Character.SelectedIndex];
                }
                catch(Exception ex2)
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png");
                    tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png";

                    fileLocation = "players";
                    fileCode = int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)).ToString();
                }
            }

            string fileLocations = check_local_Image(fileLocation, fileCode);
            if (fileLocations != null)
            {
                //파일 있음
                picturebox_Before.ImageLocation = fileLocations;
            }
            else
            {
                picturebox_Before.ImageLocation = tempurl;
            }
            
        }

        private void button_changeLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                FIFA4_Location = folder.SelectedPath;
                label_nowLocation.Text = "현재 위치: " + FIFA4_Location;
            }
        }
    }
}
