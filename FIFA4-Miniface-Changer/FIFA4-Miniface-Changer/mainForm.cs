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

        public string Token;

        public mainForm()
        {
            InitializeComponent();
        }

        public string getVersion() //서버의 최신 버전을 구해옵니다.
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/MoonByul-E/FIFA4-Miniface-Changer/main/Version");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            return Reader.ReadToEnd();
        }

        public JArray getAPI(string URL) //URL의 API를 구해옵니다.
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

        public void load_ListBox() //listBox를 처음 상태로 다시 로딩합니다.
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

        public JObject getServer(string URL) //URL의 API를 구해옵니다.
        {
            //Get Data
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Encoding
            Stream Stream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(Stream, Encoding.UTF8);
            string Text = Reader.ReadToEnd();

            JObject Object = JObject.Parse(Text);
            Console.WriteLine(Object);

            return Object;
        }

        private void mainForm_Load(object sender, EventArgs e) //메인폼 로딩시 실행
        {
            StringBuilder fileLocation = new StringBuilder();
            GetPrivateProfileString("FILE", "LOCATION", FIFA4_Location, fileLocation, 1000, Application.StartupPath + @"\Setting.ini"); //Setting.ini에서 저장된 경로 확인
            FIFA4_Location = fileLocation.ToString();
            this.Size = new Size(739, 414);
            label_nowLocation.Text = "현재 위치: " + FIFA4_Location;
            FileInfo check_FIFA4EXE = new FileInfo(FIFA4_Location + "\\fifa4zf.exe"); //FIFA4 폴더가 맞는지 확인

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
                JArray seasonList = getAPI("https://static.api.nexon.co.kr/fifaonline4/latest/seasonid.json"); //시즌 목록 구해오기
                JArray playerList = getAPI("https://static.api.nexon.co.kr/fifaonline4/latest/spid.json"); //선수 목록 구해오기

                //get Season Data
                List<string> seasonId = new List<string>();
                List<string> seasonName = new List<string>();
                List<string> seasonIcon = new List<string>();

                foreach (JToken season in seasonList) //시즌 목록 정리
                {
                    //get seasonId
                    seasonId.Add(season["seasonId"].ToString()); //시즌 아이디 가져오기
                    //get seasonName
                    seasonName.Add(season["className"].ToString().Split('(')[0].TrimEnd()); //시즌 이름 가져오기
                    //get seasonIcon
                    seasonIcon.Add(season["seasonImg"].ToString()); //시즌 아이콘 가져오기
                }

                //get Player Data
                foreach (JToken player in playerList) //선수 목록 정리
                {
                    string playerSeasonName = "";
                    string playerSeasonIcon = "";
                    string playerSeason = player["id"].ToString().Substring(0, 3); //선수의 시즌 아이디 구하기
                    playerSeasonName = seasonName[seasonId.IndexOf(playerSeason)]; // 선수의 시즌 이름 구하기
                    playerSeasonIcon = seasonIcon[seasonId.IndexOf(playerSeason)]; // 선수의 시즌 아이콘 구하기

                    playerNameList.Add("[" + playerSeasonName + "] " + player["name"]); // "[시즌 이름] 선수 이름" 으로 정리후 목록에 추가
                    playerCodeList.Add(player["id"].ToString()); //선수 코드를 목록에 추가
                    playerIconList.Add(playerSeasonIcon); //선수의 시즌 아이콘을 목록에 추가
                }

                load_ListBox(); //listBox 처음 상태로 로딩
                string nowVersion = Properties.Settings.Default.nowVersion; //현재 프로그램의 버전 구해오기
                if (getVersion().TrimEnd() != nowVersion) //온라인의 최신버전과 현재 버전이 다를시
                {
                    updateForm UpdateForm = new updateForm();
                    UpdateForm.ShowDialog(); //업데이트 알림창을 띄운다
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can`t load Data.", "Error"); //선수, 시즌 정보 구하기 실패
                Console.WriteLine(ex);
            }
        }

        private void button_Search_Click(object sender, EventArgs e) //검색 버튼 클릭시
        {
            
            if(textbox_Search.Text == "") //검색창이 비어있을때
            {
                if(ifSearch == false) //첫 검색이면
                {
                    MessageBox.Show("검색하실 선수의 이름을 입력해주세요.", "Error"); //오류창 띄우기
                    textbox_Search.Focus();
                }

                else //첫 검색이 아니면
                {
                    load_ListBox(); //listBpx를 처음 상태로 로딩
                    ifSearch = false; // 검색을 했다고 알림을 취소
                }
            }
            else //검색창이 비어있지 않을때
            {
                if(ifSearch == true) //첫 검색이 아니면
                {
                    load_ListBox(); //listBpx를 처음 상태로 로딩
                    //이유: listBox를 초기화후 검색을 해야 모든 list에서 정보를 찾을수 있기 때문에 초기화를 함
                }

                for (int i = 0; i < listbox_Character.Items.Count; i++) // listBox의 items갯수 만큼 반복
                {
                    if(listbox_Character.Items[i].ToString().IndexOf(textbox_Search.Text) != -1) // 검색창에 입력한 내용이 listBox.items의 포함되있을때
                    {
                        searchPlayerNameList.Add(listbox_Character.Items[i].ToString()); //선수 이름 검색 목록에 선수 이름 추가
                        searchPlayerCodeList.Add(playerCodeList[i].ToString()); // 선수 코드 검색 목록에 선수 코드 추가
                        searchPlayerIconList.Add(playerIconList[i].ToString()); // 시즌 아이콘 검색 목록에 시즌 아이콘 추가
                    }
                }

                listbox_Character.Items.Clear(); // listBox 초기화

                listbox_Character.BeginUpdate(); //listBox 업데이트를 멈춤
                for (int j = 0; j < searchPlayerNameList.Count; j++) //선수 이름 검색 목록의 갯수 만큼 반복
                {
                    listbox_Character.Items.Add(searchPlayerNameList[j]); //listBox에 선수 이름 검색 추가
                }
                listbox_Character.EndUpdate(); //listBox 업데이트를 끝냄
                ifSearch = true; // 검색을 했다고 알림
            }
        }

        private void textbox_Search_KeyUp(object sender, KeyEventArgs e) //검색창에서 키보드 클릭
        {
            if(e.KeyCode == Keys.Enter) //만약 엔터키 클릭시
            {
                button_Search_Click(sender, e); //검색 버튼을 누름
            }
        }

        string check_local_Image(string location, string code) //FIFA4 폴더에 선수 사진이 있는지 확인
        {
            FileInfo fileInfo = new FileInfo(FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + location + "\\p" + code + ".png"); //FIFA4 폴더에 선수사진 확인
            if (fileInfo.Exists) //선수 사진 있으면
            {
                return (FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + location + "\\p" + code + ".png"); //선수 사진 경로 반환
            }
            else //선수 사진 없으면
            {
                return null; //null 반환
            }
        }

        private void button_changeLocation_Click(object sender, EventArgs e) //경로 변경 버튼 클릭
        {
            FolderBrowserDialog folder = new FolderBrowserDialog(); //폴더 선택 다이얼로그
            if(folder.ShowDialog() == DialogResult.OK) //폴더 선택 다이얼로그 띄우고 확인 클릭시
            {
                FIFA4_Location = folder.SelectedPath; //FIFA4 경로를 폴더 선택 다이얼로그에서 가져온 경로로 변경
                WritePrivateProfileString("FILE", "LOCATION", FIFA4_Location, Application.StartupPath + @"\Setting.ini"); //Setting.ini에 작성
                label_nowLocation.Text = "현재 위치: " + FIFA4_Location; //현재 위치 label 텍스트 변경
                FileInfo check_FIFA4EXE = new FileInfo(FIFA4_Location + "\\fifa4zf.exe"); //FIFA4 폴더가 맞는지 확인

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

        private void button_Before_Click(object sender, EventArgs e) //변경전 미페 선수 선택 버튼 클릭
        {
            if(listbox_Character.SelectedIndex == -1) //listBox에서 선택한 선수가 없을때
            {
                MessageBox.Show("선수를 선택해주세요.", "Error");
            }
            else //listBox에서 선택한 선수가 있을때
            {
                List<string> playersName = playerNameList; //선수 이름을 전체 목록에서 가져옴
                List<string> playersCode = playerCodeList; //선수 코드를 전체 목록에서 가져옴
                List<string> playersIcon = playerIconList; //시즌 아이콘을 전체 목록에서 가져옴

                if (ifSearch == true) //만약 검색을 했었다면
                {
                    playersName = searchPlayerNameList; //선수 이름을 검색 목록에서 가져옴
                    playersCode = searchPlayerCodeList; //선수 코드를 검색 목록에서 가져옴
                    playersIcon = searchPlayerIconList; //시즌 아이콘을 검색 목록에서 가져옴
                }

                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png"); //액션 사진으로 구하기 시도
                    tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png"; //액션 사진이 있으면 임시 링크에 저장

                    fileLocation = "playersAction"; //선수 폴더를 액션 사진으로 설정
                    fileCode = playersCode[listbox_Character.SelectedIndex]; //선수 코드를 spid로 저장
                }
                catch (Exception ex) //만약 액션 사진이 없으면
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png"); //일반 사진을 spid로 구하기 시도
                        tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png"; //일반 사진이 있다면 임시 링크에 저장

                        fileLocation = "players"; //선수 폴더를 일반 사진으로 설정
                        fileCode = playersCode[listbox_Character.SelectedIndex]; //선수 코드를 spid로 저장
                    }
                    catch (Exception ex2) //만약 일반 사진을 spid로 구하지 못했으면
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png"); //일반 사진을 pid로 구하기 시도
                            tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png"; //일반 사진이 있다면 임시 링크에 저장

                            fileLocation = "players"; //선수 폴더를 일반 사진으로 설정
                            fileCode = int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)).ToString(); //선수 코드를 pid로 저장
                        }
                        catch (Exception ex3) //만약 일반 사진을 pid로 구하지 못했으면
                        {
                            tempurl = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/not_found.png"; //임시 링크를 기본 미페로 설정

                            fileLocation = "players"; //선수 폴더를 일반 사진으로 설정
                            fileCode = "not_found"; //선수 코드를 기본 미페로 저장

                            MessageBox.Show("현재 \"" + playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd().TrimStart() + "\" 선수는 미페가 없습니다.\n변경시 모든 미페가 없는 선수는 현재 미페로 적용됩니다."); //기본 미페를 변경시 모든 기본미페가 같이 변경된다는 경고
                        }
                    }
                }

                string fileLocations = check_local_Image(fileLocation, fileCode); //FIFA4 폴더에 사진 있는지 확인
                if (fileLocations != null) //사진이 있으면
                {
                    picturebox_Before.ImageLocation = fileLocations; //변경전 미페를 FIFA4 폴더에서 불러오기
                }
                else //사진이 없으면
                {
                    picturebox_Before.ImageLocation = tempurl; //변경전 미페를 임시 링크에서 가져오기
                }

                before_Check = true; //변경전 미페 선택 확인
                picturebox_Season.ImageLocation = playersIcon[listbox_Character.SelectedIndex]; //시즌 아이콘을 선택된 선수의 시즌으로 변경한다.
                label_Name.Text = playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd(); // 선수 이름을 시즌 이름 제외하고 출력한다.
            }
        }

        private void button_After_Click(object sender, EventArgs e) //변경후 미페 선수 선택 버튼 클릭
        {
            if(listbox_Character.SelectedIndex == -1) //listBox에서 선택한 선수가 없을때
            {
                MessageBox.Show("선수를 선택해주세요.", "Error");
            }
            else
            {
                List<string> playersName = playerNameList; //선수 이름을 전체 목록에서 가져옴
                List<string> playersCode = playerCodeList; //선수 코드를 전체 목록에서 가져옴
                List<string> playersIcon = playerIconList; //시즌 아이콘을 전체 목록에서 가져옴

                if (ifSearch == true) //만약 검색을 했었다면
                {
                    playersName = searchPlayerNameList; //선수 이름을 검색 목록에서 가져옴
                    playersCode = searchPlayerCodeList; //선수 코드를 검색 목록에서 가져옴
                    playersIcon = searchPlayerIconList; //시즌 아이콘을 검색 목록에서 가져옴
                }

                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png"); //액션 사진으로 구하기 시도
                    picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/playersAction/p" + playersCode[listbox_Character.SelectedIndex] + ".png"; //액션 사진이 있으면 변경후 선수 사진에 설정
                }
                catch (Exception ex) //만약 액션 사진이 없으면
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png"); //일반 사진으로 구하기 시도
                        picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + playersCode[listbox_Character.SelectedIndex] + ".png"; //일반 사진이 있으면 변경후 선수 사진에 설정
                    }
                    catch (Exception ex2) //만약 일반 사진을 spid로 구하지 못했으면
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            byte[] bytes = wc.DownloadData("https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png"); //일반 사진을 spid로 구하기 시도
                            picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/p" + int.Parse(playersCode[listbox_Character.SelectedIndex].Substring(3)) + ".png"; //일반 사진이 있으면 변경후 선수 사진에 설정
                        }
                        catch (Exception ex3) //만약 일반 사진을 pid로 구하지 못했으면
                        {
                            picturebox_After.ImageLocation = "https://fo4.dn.nexoncdn.co.kr/live/externalAssets/common/players/not_found.png"; //변경후 선수 사진을 기본 미페로 설정
                        }
                    }
                }
                label_After_Name.Text = playersName[listbox_Character.SelectedIndex].Split(']')[1].TrimEnd().TrimStart(); // 선수 이름을 시즌 이름 제외하고 출력한다.
                after_Check = true; //변경후 미페 선택 확인
            }
        }

        private void button_After_Open_Click(object sender, EventArgs e) //미페 불러오기 버튼 클릭
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //파일 다이얼로그
            openFileDialog.Filter = "이미지 파일 (*.png, *.jpg, *.bmp) | *.png; *.jpg; *.bmp;"; //파일 선택시 확장자를 지정

            if (openFileDialog.ShowDialog() == DialogResult.OK) //파일 다이얼로그를 띄우고 확인 버튼 클릭시
            {
                picturebox_After.ImageLocation = openFileDialog.FileName; //변경후 이미지 경로를 선택한 파일 경로로 변경
                label_After_Name.Text = openFileDialog.SafeFileName; //변경후 이름을 파일 이름으로 변경
                after_Check = true; //변경후 미페 선택 확인
            }
        }

        private void button_Change_Click(object sender, EventArgs e) //변경하기 버튼 클릭
        {
            if(before_Check == true && after_Check == true) //만약 변경전 미페 선택과 변경후 미페 선택이 확인됬으면
            {
                try
                {
                    picturebox_After.Image.Save(FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + fileLocation + "\\p" + fileCode + ".png", System.Drawing.Imaging.ImageFormat.Png); //변경후 이미지를 변경전 경로에 저장한다.

                    picturebox_Before.ImageLocation = FIFA4_Location + "\\_cache\\live\\externalAssets\\common\\" + fileLocation + "\\p" + fileCode + ".png"; //변경전 이미지를 새로고침 한다.
                }
                catch(Exception ex) //오류 발생시
                {
                    MessageBox.Show("FIFA ONLINE 4 폴더를 찾을수 없습니다.\n경로를 다시 확인해주세요.", "Error"); //FIFA4 경로를 찾을수 없다는 오류
                }
            }
            else if(before_Check == false) //만약 변경전 미페 선택이 확인이 되지 않았으면
            {
                MessageBox.Show("변경 전 미페를 선택해주세요.", "Error"); //경고를 띄운다
            }
            else if (after_Check == false) //만약 변경후 미페 선택이 확인이 되지 않았으면
            {
                MessageBox.Show("변경 후 전 미페를 선택해주세요.", "Error"); //경고를 띄운다
            }
        }

        private void listbox_MiniFace_SelectedIndexChanged(object sender, EventArgs e) //미페 저장소의 listBox의 선택이 바뀌면
        {
            Console.WriteLine(listbox_MiniFace.SelectedIndex);
            picturebox_MiniFace.ImageLocation = "http://127.0.0.1/static/img/" + miniface_Location[listbox_MiniFace.SelectedIndex].ToString(); //서버에서 해당 미니페이스를 불러온다.
            Console.WriteLine(picturebox_MiniFace.ImageLocation);
        }

        private void listbox_Character_SelectedIndexChanged(object sender, EventArgs e) //listBox의 선택이 바뀌면
        {
            List<string> playersName = playerNameList; //선수 이름을 전체 목록에서 가져옴
            List<string> playersCode = playerCodeList; //선수 코드를 전체 목록에서 가져옴
            List<string> playersIcon = playerIconList; //시즌 아이콘을 전체 목록에서 가져옴

            miniface_No = new List<string>();
            miniface_Name = new List<string>();
            miniface_Location = new List<string>();

            if (ifSearch == true) //만약 검색을 했었다면
            {
                playersName = searchPlayerNameList; //선수 이름을 검색 목록에서 가져옴
                playersCode = searchPlayerCodeList; //선수 코드를 검색 목록에서 가져옴
                playersIcon = searchPlayerIconList; //시즌 아이콘을 검색 목록에서 가져옴
            }

            if (miniFace_Save == true) //미페 저장소가 켜져있을때
            {
                label_MiniFace_Name.Text = listbox_Character.Items[listbox_Character.SelectedIndex].ToString(); //미페 저장소의 이름을 현재 선택된 선수의 이름으로 띄운다.
                JArray board = getAPI("http://127.0.0.1/board/" + playersCode[listbox_Character.SelectedIndex]); //서버에서 선수의 미페 목록을 불러온다.
                if (board[0]["No"].ToString() == "-1") //만약 미페번호가 -1 이면
                {
                    listbox_MiniFace.Items.Add("등록된 미니 페이스가 없습니다."); //미니 페이스가 없다는 알림을 보낸다.
                }
                else
                {
                    listbox_MiniFace.BeginUpdate(); //미페 저장소 listBox 업데이트를 멈춤
                    for (int i = 0; i < board.Count; i++) //서버에서 받아온 미페 목록만큼 반복
                    {
                        Console.WriteLine(board[i]["Title"]);
                        miniface_No.Add(board[i]["No"].ToString()); //미페 번호 목록에 서버에서 받아온 미페 번호 추가
                        miniface_Name.Add(board[i]["Title"].ToString()); //미페 이름 목록에 서버에서 받아온 미페 이름 추가
                        miniface_Location.Add(board[i]["fileLocation"].ToString()); //미페 위치 목록에 서버에서 받아온 미페 경로 추가
                        listbox_MiniFace.Items.Add("[No. " + board[i]["No"].ToString() + "] " + board[i]["Title"].ToString()); //미페 저장소 listBox에 "[No. 번호] 미페 이름"을 띄운다.
                    }
                    listbox_MiniFace.EndUpdate(); //미페 저장소 listBox 업데이트를 끝낸다.
                }
            }
        }

        private void Visible_MainForm(bool Visible)
        {
            //검색 부분
            textbox_Search.Visible = Visible;
            button_Search.Visible = Visible;
            listbox_Character.Visible = Visible;

            //변경전 부분
            label_Before.Visible = Visible;
            picturebox_Season.Visible = Visible;
            label_Name.Visible = Visible;
            picturebox_Before.Visible = Visible;
            button_Before.Visible = Visible;

            //변경후 부분
            label_After.Visible = Visible;
            label_After_Name.Visible = Visible;
            picturebox_After.Visible = Visible;
            button_After.Visible = Visible;
            button_After_Open.Visible = Visible;

            //변경
            button_Change.Visible = Visible;

            //피파 위치
            label_nowLocation.Visible = Visible;
            button_changeLocation.Visible = Visible;
            label_checkFIFA4.Visible = Visible;

            //미페 저장소
            button_MiniFace.Visible = Visible;

            //로그인 버튼
            button_Login.Visible = Visible;
        }

        private void Visible_Login(bool Visible)
        {
            //로그인
            tabControl_Login.Location = new Point(23, 63);
            tabControl_Login.Visible = Visible;

            //닫기 버튼
            button_Login_Close.Location = new Point(641, 63);
            button_Login_Close.Visible = Visible;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Visible_MainForm(false);
            Visible_Login(true);

            tabControl_Login.SelectedIndex = 0;

            textBox_Login_ID.Text = "";
            textBox_Login_PW.Text = "";

            textBox_Register_ID.Text = "";
            textBox_Register_PW.Text = "";
            textBox_Register_REPW.Text = "";
            textBox_Register_EMail.Text = "";

            textBox_IDSearch_EMail.Text = "";

            textBox_PWChange_ID.Text = "";
            textBox_PWChange_EMail.Text = "";
            textBox_PWChange_NEWPW.Text = "";
            textBox_PWChange_RENEWPW.Text = "";
        }

        private void button_Login_Close_Click(object sender, EventArgs e)
        {
            Visible_Login(false);
            Visible_MainForm(true);
        }

        private void button_Login_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Login_ID.Text == "") // 로그인 아이디가 비어있을때
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
                JObject Result = getServer("http://127.0.0.1:7777/login/login?ID=" + textBox_Login_ID.Text + "&PW=" + textBox_Login_PW.Text);

                if (Result["Result"].ToString() == "ID Error" || Result["Result"].ToString() == "PW Error") // 아이디를 찾을수 없을때 또는 비밀번호가 일치하지 않을때
                {
                    MessageBox.Show("아이디가 존재하지 않거나, 비밀번호가 맞지 않습니다.", "Error");
                    textBox_Login_ID.Focus();
                }
                else // 로그인 성공
                {
                    Token = Result["Token"].ToString();
                    Console.WriteLine(Token);

                    //메인 화면으로
                    Visible_Login(false);
                    Visible_MainForm(true);

                    //메인화면 로그인 버튼 숨기기
                    button_Login.Visible = false;
                    //메인화면 로그아웃 버튼 보이기
                    button_Logout.Visible = true;
                    //메인화면 로그아웃 위치 옮기기
                    button_Logout.Location = new Point(641, 63);
                    //메인화면 사용자 이름 표시
                    label_UserName.Text = "사용자: " + getServer("http://127.0.0.1:7777/login/getid?Token=" + Token)["ID"].ToString();
                    label_UserName.Location = new Point(button_Login.Location.X - label_UserName.Size.Width, button_Login.Location.Y);
                }
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if(textBox_Register_ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해 주세요.", "Error");
                textBox_Register_ID.Focus();
            }
            else if(textBox_Register_PW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "Error");
                textBox_Register_PW.Focus();
            }
            else if (textBox_Register_REPW.Text == "")
            {
                MessageBox.Show("비밀번호를 다시 입력해 주세요.", "Error");
                textBox_Register_REPW.Focus();
            }
            else if (textBox_Register_EMail.Text == "")
            {
                MessageBox.Show("이메일을 다시 입력해 주세요.", "Error");
                textBox_Register_EMail.Focus();
            }
            else if(textBox_Register_PW.Text != textBox_Register_REPW.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "Error");
                textBox_Register_REPW.Focus();
            }
            else
            {
                JObject Result = getServer("http://127.0.0.1:7777/login/register?ID=" + textBox_Register_ID.Text + "&PW=" + textBox_Register_PW.Text + "&EMail=" + textBox_Register_EMail.Text);
                if (Result["Result"].ToString() == "ID Overlap")
                {
                    MessageBox.Show("이미 사용중인 아이디 입니다.", "Error");
                    textBox_Register_ID.Focus();
                }
                else if (Result["Result"].ToString() == "EMail Overlap")
                {
                    MessageBox.Show("이미 사용중인 이메일 입니다.", "Error");
                    textBox_Register_EMail.Focus();
                }
                else
                {
                    MessageBox.Show("회원가입이 완료됬습니다.", "Success");

                    textBox_Register_ID.Text = "";
                    textBox_Register_PW.Text = "";
                    textBox_Register_REPW.Text = "";
                    textBox_Register_EMail.Text = "";

                    tabControl_Login.SelectedIndex = 0;

                }
            }
        }

        private void button_IDSearch_Click(object sender, EventArgs e)
        {
            if (textBox_IDSearch_EMail.Text == "")
            {
                MessageBox.Show("이메일을 입력해 주세요.", "Error");
                textBox_IDSearch_EMail.Focus();
            }
            else
            {
                JObject Result = getServer("http://127.0.0.1:7777/login/idsearch?EMail=" + textBox_IDSearch_EMail.Text);

                if(Result["Result"].ToString() == "EMail Error")
                {
                    MessageBox.Show("이메일을 찾을 수 없습니다.", "Error");
                    textBox_IDSearch_EMail.Focus();
                }
                else
                {
                    MessageBox.Show("입력하신 이메일로 아이디를 전송했습니다.", "Success");

                    textBox_IDSearch_EMail.Text = "";

                    tabControl_Login.SelectedIndex = 0;
                }
            }
        }

        private void button_PWChange_Click(object sender, EventArgs e)
        {
            if (textBox_PWChange_ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해 주세요.", "Error");
                textBox_PWChange_ID.Focus();
            }
            else if (textBox_PWChange_EMail.Text == "")
            {
                MessageBox.Show("이메일을 입력해 주세요.", "Error");
                textBox_PWChange_EMail.Focus();
            }
            else if (textBox_PWChange_NEWPW.Text == "")
            {
                MessageBox.Show("새로운 비밀번호를 입력해 주세요.", "Error");
                textBox_PWChange_NEWPW.Focus();
            }
            else if (textBox_PWChange_RENEWPW.Text == "")
            {
                MessageBox.Show("새로운 비밀번호를 다시 입력해 주세요.", "Error");
                textBox_PWChange_RENEWPW.Focus();
            }
            else if (textBox_PWChange_NEWPW.Text != textBox_PWChange_RENEWPW.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다", "Error");
                textBox_PWChange_RENEWPW.Focus();
            }
            else
            {
                JObject Result = getServer("http://127.0.0.1:7777/login/pwchange?ID=" + textBox_PWChange_ID.Text + "&EMail=" + textBox_PWChange_EMail.Text + "&NewPW=" + textBox_PWChange_NEWPW.Text);

                if(Result["Result"].ToString() == "EMail Error")
                {
                    MessageBox.Show("이메일을 찾을 수 없습니다.", "Error");
                    textBox_PWChange_EMail.Focus();
                }
                else if (Result["Result"].ToString() == "ID Error")
                {
                    MessageBox.Show("아이디를 찾을 수 없습니다.", "Error");
                    textBox_PWChange_ID.Focus();
                }
                else
                {
                    MessageBox.Show("비밀번호가 변경 되었습니다.", "Success");

                    textBox_PWChange_ID.Text = "";
                    textBox_PWChange_EMail.Text = "";
                    textBox_PWChange_NEWPW.Text = "";
                    textBox_PWChange_RENEWPW.Text = "";

                    tabControl_Login.SelectedIndex = 0;
                }
            }
        }

        private void button_Logout_Click(object sender, EventArgs e) //로그아웃 클릭시
        {
            //토큰 지우기
            Token = "";
            //메인화면 로그인 버튼 보이기
            button_Login.Visible = true;
            //메인화면 로그아웃 버튼 숨기기
            button_Logout.Visible = false;
            //메인화면 사용자 이름 숨기기
            label_UserName.Visible = false;
        }

        private void MiniFace_Main_Visible(bool Visible)
        {
            //변경전 부분
            label_Before.Visible = Visible;
            picturebox_Season.Visible = Visible;
            label_Name.Visible = Visible;
            picturebox_Before.Visible = Visible;
            button_Before.Visible = Visible;

            //변경후 부분
            label_After.Visible = Visible;
            label_After_Name.Visible = Visible;
            picturebox_After.Visible = Visible;
            button_After.Visible = Visible;
            button_After_Open.Visible = Visible;

            //변경
            button_Change.Visible = Visible;

            //미페 저장소
            button_MiniFace.Visible = Visible;
        }

        private void MiniFace_Visible(bool Visible)
        {
            label_MiniFace_Name.Visible = Visible;
            listbox_MiniFace.Visible = Visible;
            picturebox_MiniFace.Visible = Visible;
            button_MiniFace_Select.Visible = Visible;
            button_MiniFace_Report.Visible = Visible;
            button_MiniFace_Upload.Visible = Visible;
            button_MiniFace_Close.Visible = Visible;
        }

        private void button_MiniFace_Click(object sender, EventArgs e) //미페 저장소 버튼 클릭
        {
            MiniFace_Main_Visible(false);
            MiniFace_Visible(true);

            label_MiniFace_Name.Location = new Point(373, 97);
            listbox_MiniFace.Location = new Point(373, 123);
            picturebox_MiniFace.Location = new Point(588, 123);
            button_MiniFace_Select.Location = new Point(588, 257);
            button_MiniFace_Report.Location = new Point(588, 286);
            button_MiniFace_Upload.Location = new Point(588, 315);
            button_MiniFace_Close.Location = new Point(22, 372);
            button_MiniFace_Player.Location = new Point(507, 315);
            
        }

        private void button_MiniFace_Close_Click(object sender, EventArgs e)
        {
            MiniFace_Visible(false);
            MiniFace_Main_Visible(true);
        }
    }
}
