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
using System.Runtime.InteropServices;
using AdsJumboWinForm;

namespace FIFA4_Miniface_Changer
{
    public partial class mainForm : MetroForm
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private readonly AdsJumboWinForm.BannerAds bannerAds = new BannerAds();

        string FIFA4_Location = "C:\\Nexon\\EA SPORTS(TM) FIFA ONLINE 4";

        List<string> playerNameList = new List<string>();
        List<string> playerCodeList = new List<string>();
        List<string> playerIconList = new List<string>();

        List<string> searchPlayerNameList = new List<string>();
        List<string> searchPlayerCodeList = new List<string>();
        List<string> searchPlayerIconList = new List<string>();

        List<string> miniface_No = new List<string>();
        List<string> miniface_Name = new List<string>();
        List<string> miniface_Location = new List<string>();

        bool ifSearch = false;
        bool before_Check = false;
        bool after_Check = false;
        bool miniFace_Save = false;

        public mainForm()
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
            searchPlayerIconList = new List<string>();
            ifSearch = false;
            listbox_Character.SelectedIndex = 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            StringBuilder fileLocation = new StringBuilder();
            GetPrivateProfileString("FILE", "LOCATION", FIFA4_Location, fileLocation, 1000, Application.StartupPath + @"\Setting.ini");
            FIFA4_Location = fileLocation.ToString();
            this.Size = new Size(900, 414);
            label_nowLocation.Text = "현재 위치: " + FIFA4_Location;
            FileInfo check_FIFA4EXE = new FileInfo(FIFA4_Location + "\\fifa4zf.exe");

            //있을때
            if (check_FIFA4EXE.Exists)
            {
                label_checkFIFA4.Text = "현재 경로 확인: FIFA4 파일 확인.";
                label_checkFIFA4.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                label_checkFIFA4.Text = "현재 경로 확인: FIFA4 파일 없음.";
                label_checkFIFA4.Style = MetroFramework.MetroColorStyle.Red;
            }

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
                    string playerSeasonIcon = "";
                    string playerSeason = player["id"].ToString().Substring(0, 3);
                    playerSeasonName = seasonName[seasonId.IndexOf(playerSeason)];
                    playerSeasonIcon = seasonIcon[seasonId.IndexOf(playerSeason)];

                    playerNameList.Add("[" + playerSeasonName + "] " + player["name"]);
                    playerCodeList.Add(player["id"].ToString());
                    playerIconList.Add(playerSeasonIcon);
                }

                load_ListBox();
                string nowVersion = Properties.Settings.Default.nowVersion;
                if (getVersion().TrimEnd() != nowVersion)
                {
                    updateForm UpdateForm = new updateForm();
                    UpdateForm.ShowDialog();
                }

                Controls.Add(bannerAds);
                bannerAds.Location = new Point(740, 30);
                bannerAds.ShowAd(160, 600, "bamd4f0pc0ns");
                bannerAds.Size = new Size(160, 350);
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
                        searchPlayerIconList.Add(playerIconList[i].ToString());
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
            FileInfo fileInfo = new FileInfo(FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + location + "\\p" + code + ".png");
            if (fileInfo.Exists)
            {
                return (FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + location + "\\p" + code + ".png");
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
            List<string> playersIcon = playerIconList;

            miniface_No = new List<string>();
            miniface_Name = new List<string>();
            miniface_Location = new List<string>();

            if (ifSearch == true)
            {
                playersName = searchPlayerNameList;
                playersCode = searchPlayerCodeList;
                playersIcon = searchPlayerIconList;
            }

            if (miniFace_Save == true)
            {
                label_MiniFace_Name.Text = listbox_Character.Items[listbox_Character.SelectedIndex].ToString();
                JArray board = getAPI("http://127.0.0.1/board/" + playersCode[listbox_Character.SelectedIndex]);
                if(board[0]["No"].ToString() == "-1")
                {
                    listbox_MiniFace.Items.Add("등록된 미니 페이스가 없습니다.");
                }
                else
                {
                    listbox_MiniFace.BeginUpdate();
                    for (int i = 0; i < board.Count; i++)
                    {
                        Console.WriteLine(board[i]["Title"]);
                        miniface_No.Add(board[i]["No"].ToString());
                        miniface_Name.Add(board[i]["Title"].ToString());
                        miniface_Location.Add(board[i]["fileLocation"].ToString());
                        listbox_MiniFace.Items.Add("[No. " + board[i]["No"].ToString() + "] " + board[i]["Title"].ToString());
                    }
                    listbox_MiniFace.EndUpdate();
                }
            }
        }

        private void button_changeLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                FIFA4_Location = folder.SelectedPath;
                WritePrivateProfileString("FILE", "LOCATION", FIFA4_Location, Application.StartupPath + @"\Setting.ini");
                label_nowLocation.Text = "현재 위치: " + FIFA4_Location;
                FileInfo check_FIFA4EXE = new FileInfo(FIFA4_Location + "\\fifa4zf.exe");

                //있을때
                if (check_FIFA4EXE.Exists)
                {
                    label_checkFIFA4.Text = "현재 경로 확인: FIFA4 파일 확인.";
                    label_checkFIFA4.Style = MetroFramework.MetroColorStyle.Green;
                }
                else
                {
                    label_checkFIFA4.Text = "현재 경로 확인: FIFA4 파일 없음.";
                    label_checkFIFA4.Style = MetroFramework.MetroColorStyle.Red;
                }
            }
        }

        string fileLocation = "";
        string fileCode = "";
        string tempurl = "";

        private void button_Before_Click(object sender, EventArgs e)
        {
            if(listbox_Character.SelectedIndex == -1)
            {
                MessageBox.Show("선수를 선택해주세요.", "Error");
            }
            else
            {
                List<string> playersName = playerNameList;
                List<string> playersCode = playerCodeList;
                List<string> playersIcon = playerIconList;

                if (ifSearch == true)
                {
                    playersName = searchPlayerNameList;
                    playersCode = searchPlayerCodeList;
                    playersIcon = searchPlayerIconList;
                }

                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                    tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png";

                    fileLocation = "playersAction";
                    fileCode = playersCode[listbox_Character.SelectedIndex];
                }
                catch (Exception ex)
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                        tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png";

                        fileLocation = "players";
                        fileCode = playersCode[listbox_Character.SelectedIndex];
                    }
                    catch (Exception ex2)
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png");
                            tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png";

                            fileLocation = "players";
                            fileCode = int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)).ToString();
                        }
                        catch (Exception ex3)
                        {
                            tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/not_found.png";

                            fileLocation = "players";
                            fileCode = "not_found";

                            MessageBox.Show("현재 \"" + playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd().TrimStart() + "\" 선수는 미페가 없습니다.\n변경시 모든 미페가 없는 선수는 현재 미페로 적용됩니다.");
                        }
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

                before_Check = true;
                picturebox_Season.ImageLocation = playersIcon[listbox_Character.SelectedIndex];
                label_Name.Text = playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd();
            }
        }

        private void button_After_Click(object sender, EventArgs e)
        {
            if(listbox_Character.SelectedIndex == -1)
            {
                MessageBox.Show("선수를 선택해주세요.", "Error");
            }
            else
            {
                List<string> playersName = playerNameList;
                List<string> playersCode = playerCodeList;
                List<string> playersIcon = playerIconList;

                if (ifSearch == true)
                {
                    playersName = searchPlayerNameList;
                    playersCode = searchPlayerCodeList;
                    playersIcon = searchPlayerIconList;
                }

                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                    picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png";
                }
                catch (Exception ex)
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png");
                        picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png";
                    }
                    catch (Exception ex2)
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png");
                            picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png";
                        }
                        catch (Exception ex3)
                        {
                            picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/not_found.png";
                        }
                    }
                }
                label_After_Name.Text = playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd().TrimStart();
                after_Check = true;
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if(before_Check == true && after_Check == true)
            {
                try
                {
                    picturebox_After.Image.Save(FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + fileLocation + "\\p" + fileCode + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    picturebox_Before.ImageLocation = FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + fileLocation + "\\p" + fileCode + ".png";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("FIFA ONLINE 4 폴더를 찾을수 없습니다.\n경로를 다시 확인해주세요.", "Error");
                }
            }
            else if(before_Check == false)
            {
                MessageBox.Show("변경 전 미페를 선택해주세요.", "Error");
            }
            else if (after_Check == false)
            {
                MessageBox.Show("변경 후 전 미페를 선택해주세요.", "Error");
            }
        }

        private void button_After_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "이미지 파일 (*.png, *.jpg, *.bmp) | *.png; *.jpg; *.bmp;";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturebox_After.ImageLocation = openFileDialog.FileName;
                label_After_Name.Text = openFileDialog.SafeFileName;
                after_Check = true;
            }
        }

        private void button_MiniFace_Click(object sender, EventArgs e)
        {
            if(miniFace_Save == false)
            {
                this.Size = new Size(739, 662);
                miniFace_Save = true;
                label_MiniFace_Name.Text = listbox_Character.Items[listbox_Character.SelectedIndex].ToString();
            }
            else
            {
                this.Size = new Size(739, 414);
                miniFace_Save = false;
            }
        }

        private void listbox_MiniFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listbox_MiniFace.SelectedIndex);
            picturebox_MiniFace.ImageLocation = "http://127.0.0.1/static/img/" + miniface_Location[listbox_MiniFace.SelectedIndex].ToString();
            Console.WriteLine(picturebox_MiniFace.ImageLocation);
        }
    }
}
