
namespace FIFA4_Miniface_Changer
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_Character = new System.Windows.Forms.ListBox();
            this.textbox_Search = new MetroFramework.Controls.MetroTextBox();
            this.button_Search = new MetroFramework.Controls.MetroButton();
            this.picturebox_Before = new System.Windows.Forms.PictureBox();
            this.button_changeLocation = new MetroFramework.Controls.MetroButton();
            this.label_nowLocation = new MetroFramework.Controls.MetroLabel();
            this.button_Before = new MetroFramework.Controls.MetroButton();
            this.label_Before = new MetroFramework.Controls.MetroLabel();
            this.label_After = new MetroFramework.Controls.MetroLabel();
            this.button_After = new MetroFramework.Controls.MetroButton();
            this.picturebox_After = new System.Windows.Forms.PictureBox();
            this.button_Change = new MetroFramework.Controls.MetroButton();
            this.button_After_Open = new MetroFramework.Controls.MetroButton();
            this.label_Name = new MetroFramework.Controls.MetroLabel();
            this.picturebox_Season = new System.Windows.Forms.PictureBox();
            this.label_After_Name = new MetroFramework.Controls.MetroLabel();
            this.button_MiniFace = new MetroFramework.Controls.MetroButton();
            this.label_checkFIFA4 = new MetroFramework.Controls.MetroLabel();
            this.listbox_MiniFace = new System.Windows.Forms.ListBox();
            this.label_MiniFace_Name = new MetroFramework.Controls.MetroLabel();
            this.picturebox_MiniFace = new System.Windows.Forms.PictureBox();
            this.button_MiniFace_Select = new MetroFramework.Controls.MetroButton();
            this.button_MiniFace_Report = new MetroFramework.Controls.MetroButton();
            this.button_MiniFace_Upload = new MetroFramework.Controls.MetroButton();
            this.button_Login = new MetroFramework.Controls.MetroButton();
            this.button_Login_Close = new MetroFramework.Controls.MetroButton();
            this.tabControl_Login = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Login = new MetroFramework.Controls.MetroTabPage();
            this.checkBox_Login_IDSave = new MetroFramework.Controls.MetroCheckBox();
            this.button_Login_Login = new MetroFramework.Controls.MetroButton();
            this.textBox_Login_PW = new MetroFramework.Controls.MetroTextBox();
            this.label_Login_PW = new MetroFramework.Controls.MetroLabel();
            this.textBox_Login_ID = new MetroFramework.Controls.MetroTextBox();
            this.label_Login_ID = new MetroFramework.Controls.MetroLabel();
            this.tabPage_Register = new MetroFramework.Controls.MetroTabPage();
            this.textBox_Register_EMail = new MetroFramework.Controls.MetroTextBox();
            this.label_Register_EMail = new MetroFramework.Controls.MetroLabel();
            this.textBox_Register_REPW = new MetroFramework.Controls.MetroTextBox();
            this.label_Register_REPW = new MetroFramework.Controls.MetroLabel();
            this.button_Register = new MetroFramework.Controls.MetroButton();
            this.textBox_Register_PW = new MetroFramework.Controls.MetroTextBox();
            this.label_Register_PW = new MetroFramework.Controls.MetroLabel();
            this.textBox_Register_ID = new MetroFramework.Controls.MetroTextBox();
            this.label_Register_ID = new MetroFramework.Controls.MetroLabel();
            this.tabPage_IDSearch = new MetroFramework.Controls.MetroTabPage();
            this.button_IDSearch = new MetroFramework.Controls.MetroButton();
            this.textBox_IDSearch_EMail = new MetroFramework.Controls.MetroTextBox();
            this.label_IDSearch_EMail = new MetroFramework.Controls.MetroLabel();
            this.tabPage_PWChange = new MetroFramework.Controls.MetroTabPage();
            this.textBox_PWChange_RENEWPW = new MetroFramework.Controls.MetroTextBox();
            this.label_PWChange_RENEWPW = new MetroFramework.Controls.MetroLabel();
            this.textBox_PWChange_NEWPW = new MetroFramework.Controls.MetroTextBox();
            this.label_PWChange_NEWPW = new MetroFramework.Controls.MetroLabel();
            this.textBox_PWChange_ID = new MetroFramework.Controls.MetroTextBox();
            this.label_PWChange_ID = new MetroFramework.Controls.MetroLabel();
            this.button_PWChange = new MetroFramework.Controls.MetroButton();
            this.textBox_PWChange_EMail = new MetroFramework.Controls.MetroTextBox();
            this.label_PWChange_EMail = new MetroFramework.Controls.MetroLabel();
            this.button_Logout = new MetroFramework.Controls.MetroButton();
            this.label_UserName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_After)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_MiniFace)).BeginInit();
            this.tabControl_Login.SuspendLayout();
            this.tabPage_Login.SuspendLayout();
            this.tabPage_Register.SuspendLayout();
            this.tabPage_IDSearch.SuspendLayout();
            this.tabPage_PWChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_Character
            // 
            this.listbox_Character.FormattingEnabled = true;
            this.listbox_Character.ItemHeight = 12;
            this.listbox_Character.Location = new System.Drawing.Point(23, 99);
            this.listbox_Character.Name = "listbox_Character";
            this.listbox_Character.Size = new System.Drawing.Size(318, 208);
            this.listbox_Character.TabIndex = 0;
            this.listbox_Character.SelectedIndexChanged += new System.EventHandler(this.listbox_Character_SelectedIndexChanged);
            // 
            // textbox_Search
            // 
            this.textbox_Search.Location = new System.Drawing.Point(23, 63);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.Size = new System.Drawing.Size(244, 23);
            this.textbox_Search.TabIndex = 1;
            this.textbox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_Search_KeyUp);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(273, 63);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(68, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "검색";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // picturebox_Before
            // 
            this.picturebox_Before.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_Before.Location = new System.Drawing.Point(373, 150);
            this.picturebox_Before.Name = "picturebox_Before";
            this.picturebox_Before.Size = new System.Drawing.Size(128, 128);
            this.picturebox_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Before.TabIndex = 3;
            this.picturebox_Before.TabStop = false;
            // 
            // button_changeLocation
            // 
            this.button_changeLocation.Location = new System.Drawing.Point(23, 339);
            this.button_changeLocation.Name = "button_changeLocation";
            this.button_changeLocation.Size = new System.Drawing.Size(75, 23);
            this.button_changeLocation.TabIndex = 4;
            this.button_changeLocation.Text = "위치 변경";
            this.button_changeLocation.Click += new System.EventHandler(this.button_changeLocation_Click);
            // 
            // label_nowLocation
            // 
            this.label_nowLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_nowLocation.Location = new System.Drawing.Point(23, 313);
            this.label_nowLocation.Name = "label_nowLocation";
            this.label_nowLocation.Size = new System.Drawing.Size(478, 23);
            this.label_nowLocation.TabIndex = 5;
            this.label_nowLocation.Text = "FIFA4 위치: ";
            // 
            // button_Before
            // 
            this.button_Before.Location = new System.Drawing.Point(373, 284);
            this.button_Before.Name = "button_Before";
            this.button_Before.Size = new System.Drawing.Size(128, 23);
            this.button_Before.TabIndex = 6;
            this.button_Before.Text = "선수 선택";
            this.button_Before.Click += new System.EventHandler(this.button_Before_Click);
            // 
            // label_Before
            // 
            this.label_Before.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Before.Location = new System.Drawing.Point(373, 97);
            this.label_Before.Name = "label_Before";
            this.label_Before.Size = new System.Drawing.Size(128, 23);
            this.label_Before.TabIndex = 7;
            this.label_Before.Text = "변경 전 미페";
            this.label_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_After
            // 
            this.label_After.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_After.Location = new System.Drawing.Point(588, 97);
            this.label_After.Name = "label_After";
            this.label_After.Size = new System.Drawing.Size(128, 23);
            this.label_After.TabIndex = 10;
            this.label_After.Text = "변경 후 미페";
            this.label_After.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_After
            // 
            this.button_After.Location = new System.Drawing.Point(588, 284);
            this.button_After.Name = "button_After";
            this.button_After.Size = new System.Drawing.Size(128, 23);
            this.button_After.TabIndex = 9;
            this.button_After.Text = "미페 선택";
            this.button_After.Click += new System.EventHandler(this.button_After_Click);
            // 
            // picturebox_After
            // 
            this.picturebox_After.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_After.Location = new System.Drawing.Point(588, 141);
            this.picturebox_After.Name = "picturebox_After";
            this.picturebox_After.Size = new System.Drawing.Size(128, 128);
            this.picturebox_After.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_After.TabIndex = 8;
            this.picturebox_After.TabStop = false;
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(507, 199);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(75, 23);
            this.button_Change.TabIndex = 11;
            this.button_Change.Text = "변경하기";
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_After_Open
            // 
            this.button_After_Open.Location = new System.Drawing.Point(588, 313);
            this.button_After_Open.Name = "button_After_Open";
            this.button_After_Open.Size = new System.Drawing.Size(128, 23);
            this.button_After_Open.TabIndex = 12;
            this.button_After_Open.Text = "미페 블러오기";
            this.button_After_Open.Click += new System.EventHandler(this.button_After_Open_Click);
            // 
            // label_Name
            // 
            this.label_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Name.Location = new System.Drawing.Point(409, 123);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(92, 24);
            this.label_Name.TabIndex = 14;
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturebox_Season
            // 
            this.picturebox_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_Season.Location = new System.Drawing.Point(373, 123);
            this.picturebox_Season.Name = "picturebox_Season";
            this.picturebox_Season.Size = new System.Drawing.Size(30, 24);
            this.picturebox_Season.TabIndex = 15;
            this.picturebox_Season.TabStop = false;
            // 
            // label_After_Name
            // 
            this.label_After_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_After_Name.Location = new System.Drawing.Point(588, 123);
            this.label_After_Name.Name = "label_After_Name";
            this.label_After_Name.Size = new System.Drawing.Size(128, 24);
            this.label_After_Name.TabIndex = 16;
            this.label_After_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_MiniFace
            // 
            this.button_MiniFace.Location = new System.Drawing.Point(23, 368);
            this.button_MiniFace.Name = "button_MiniFace";
            this.button_MiniFace.Size = new System.Drawing.Size(75, 23);
            this.button_MiniFace.TabIndex = 17;
            this.button_MiniFace.Text = "미페 저장소";
            this.button_MiniFace.Visible = false;
            this.button_MiniFace.Click += new System.EventHandler(this.button_MiniFace_Click);
            // 
            // label_checkFIFA4
            // 
            this.label_checkFIFA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_checkFIFA4.Location = new System.Drawing.Point(104, 339);
            this.label_checkFIFA4.Name = "label_checkFIFA4";
            this.label_checkFIFA4.Size = new System.Drawing.Size(226, 23);
            this.label_checkFIFA4.Style = MetroFramework.MetroColorStyle.Red;
            this.label_checkFIFA4.TabIndex = 18;
            this.label_checkFIFA4.Text = "FIFA4 위치 확인: ";
            this.label_checkFIFA4.UseStyleColors = true;
            // 
            // listbox_MiniFace
            // 
            this.listbox_MiniFace.FormattingEnabled = true;
            this.listbox_MiniFace.ItemHeight = 12;
            this.listbox_MiniFace.Location = new System.Drawing.Point(23, 440);
            this.listbox_MiniFace.Name = "listbox_MiniFace";
            this.listbox_MiniFace.Size = new System.Drawing.Size(559, 208);
            this.listbox_MiniFace.TabIndex = 19;
            this.listbox_MiniFace.SelectedIndexChanged += new System.EventHandler(this.listbox_MiniFace_SelectedIndexChanged);
            // 
            // label_MiniFace_Name
            // 
            this.label_MiniFace_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_MiniFace_Name.Location = new System.Drawing.Point(23, 414);
            this.label_MiniFace_Name.Name = "label_MiniFace_Name";
            this.label_MiniFace_Name.Size = new System.Drawing.Size(693, 23);
            this.label_MiniFace_Name.TabIndex = 20;
            // 
            // picturebox_MiniFace
            // 
            this.picturebox_MiniFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_MiniFace.Location = new System.Drawing.Point(588, 440);
            this.picturebox_MiniFace.Name = "picturebox_MiniFace";
            this.picturebox_MiniFace.Size = new System.Drawing.Size(128, 128);
            this.picturebox_MiniFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_MiniFace.TabIndex = 21;
            this.picturebox_MiniFace.TabStop = false;
            // 
            // button_MiniFace_Select
            // 
            this.button_MiniFace_Select.Location = new System.Drawing.Point(588, 574);
            this.button_MiniFace_Select.Name = "button_MiniFace_Select";
            this.button_MiniFace_Select.Size = new System.Drawing.Size(128, 23);
            this.button_MiniFace_Select.TabIndex = 22;
            this.button_MiniFace_Select.Text = "미페 선택";
            // 
            // button_MiniFace_Report
            // 
            this.button_MiniFace_Report.Location = new System.Drawing.Point(588, 603);
            this.button_MiniFace_Report.Name = "button_MiniFace_Report";
            this.button_MiniFace_Report.Size = new System.Drawing.Size(128, 23);
            this.button_MiniFace_Report.TabIndex = 23;
            this.button_MiniFace_Report.Text = "미페 신고";
            // 
            // button_MiniFace_Upload
            // 
            this.button_MiniFace_Upload.Location = new System.Drawing.Point(588, 632);
            this.button_MiniFace_Upload.Name = "button_MiniFace_Upload";
            this.button_MiniFace_Upload.Size = new System.Drawing.Size(128, 23);
            this.button_MiniFace_Upload.TabIndex = 24;
            this.button_MiniFace_Upload.Text = "미페 등록";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(641, 63);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 25;
            this.button_Login.Text = "로그인";
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Login_Close
            // 
            this.button_Login_Close.Location = new System.Drawing.Point(1087, 433);
            this.button_Login_Close.Name = "button_Login_Close";
            this.button_Login_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Login_Close.TabIndex = 26;
            this.button_Login_Close.Text = "뒤로";
            this.button_Login_Close.Visible = false;
            this.button_Login_Close.Click += new System.EventHandler(this.button_Login_Close_Click);
            // 
            // tabControl_Login
            // 
            this.tabControl_Login.Controls.Add(this.tabPage_Login);
            this.tabControl_Login.Controls.Add(this.tabPage_Register);
            this.tabControl_Login.Controls.Add(this.tabPage_IDSearch);
            this.tabControl_Login.Controls.Add(this.tabPage_PWChange);
            this.tabControl_Login.Location = new System.Drawing.Point(794, 63);
            this.tabControl_Login.Name = "tabControl_Login";
            this.tabControl_Login.SelectedIndex = 3;
            this.tabControl_Login.Size = new System.Drawing.Size(375, 364);
            this.tabControl_Login.TabIndex = 27;
            // 
            // tabPage_Login
            // 
            this.tabPage_Login.Controls.Add(this.checkBox_Login_IDSave);
            this.tabPage_Login.Controls.Add(this.button_Login_Login);
            this.tabPage_Login.Controls.Add(this.textBox_Login_PW);
            this.tabPage_Login.Controls.Add(this.label_Login_PW);
            this.tabPage_Login.Controls.Add(this.textBox_Login_ID);
            this.tabPage_Login.Controls.Add(this.label_Login_ID);
            this.tabPage_Login.HorizontalScrollbarBarColor = true;
            this.tabPage_Login.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Login.Name = "tabPage_Login";
            this.tabPage_Login.Size = new System.Drawing.Size(367, 324);
            this.tabPage_Login.TabIndex = 0;
            this.tabPage_Login.Text = "로그인";
            this.tabPage_Login.VerticalScrollbarBarColor = true;
            // 
            // checkBox_Login_IDSave
            // 
            this.checkBox_Login_IDSave.AutoSize = true;
            this.checkBox_Login_IDSave.Location = new System.Drawing.Point(3, 177);
            this.checkBox_Login_IDSave.Name = "checkBox_Login_IDSave";
            this.checkBox_Login_IDSave.Size = new System.Drawing.Size(86, 15);
            this.checkBox_Login_IDSave.TabIndex = 7;
            this.checkBox_Login_IDSave.Text = "아이디 저장";
            this.checkBox_Login_IDSave.UseVisualStyleBackColor = true;
            // 
            // button_Login_Login
            // 
            this.button_Login_Login.Location = new System.Drawing.Point(3, 148);
            this.button_Login_Login.Name = "button_Login_Login";
            this.button_Login_Login.Size = new System.Drawing.Size(361, 23);
            this.button_Login_Login.TabIndex = 6;
            this.button_Login_Login.Text = "로그인";
            this.button_Login_Login.Click += new System.EventHandler(this.button_Login_Login_Click);
            // 
            // textBox_Login_PW
            // 
            this.textBox_Login_PW.Location = new System.Drawing.Point(3, 97);
            this.textBox_Login_PW.Name = "textBox_Login_PW";
            this.textBox_Login_PW.PasswordChar = '*';
            this.textBox_Login_PW.Size = new System.Drawing.Size(361, 23);
            this.textBox_Login_PW.TabIndex = 5;
            // 
            // label_Login_PW
            // 
            this.label_Login_PW.AutoSize = true;
            this.label_Login_PW.Location = new System.Drawing.Point(3, 75);
            this.label_Login_PW.Name = "label_Login_PW";
            this.label_Login_PW.Size = new System.Drawing.Size(65, 19);
            this.label_Login_PW.TabIndex = 4;
            this.label_Login_PW.Text = "비밀번호";
            // 
            // textBox_Login_ID
            // 
            this.textBox_Login_ID.Location = new System.Drawing.Point(3, 49);
            this.textBox_Login_ID.Name = "textBox_Login_ID";
            this.textBox_Login_ID.Size = new System.Drawing.Size(361, 23);
            this.textBox_Login_ID.TabIndex = 3;
            // 
            // label_Login_ID
            // 
            this.label_Login_ID.AutoSize = true;
            this.label_Login_ID.Location = new System.Drawing.Point(3, 27);
            this.label_Login_ID.Name = "label_Login_ID";
            this.label_Login_ID.Size = new System.Drawing.Size(51, 19);
            this.label_Login_ID.TabIndex = 2;
            this.label_Login_ID.Text = "아이디";
            // 
            // tabPage_Register
            // 
            this.tabPage_Register.Controls.Add(this.textBox_Register_EMail);
            this.tabPage_Register.Controls.Add(this.label_Register_EMail);
            this.tabPage_Register.Controls.Add(this.textBox_Register_REPW);
            this.tabPage_Register.Controls.Add(this.label_Register_REPW);
            this.tabPage_Register.Controls.Add(this.button_Register);
            this.tabPage_Register.Controls.Add(this.textBox_Register_PW);
            this.tabPage_Register.Controls.Add(this.label_Register_PW);
            this.tabPage_Register.Controls.Add(this.textBox_Register_ID);
            this.tabPage_Register.Controls.Add(this.label_Register_ID);
            this.tabPage_Register.HorizontalScrollbarBarColor = true;
            this.tabPage_Register.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Register.Name = "tabPage_Register";
            this.tabPage_Register.Size = new System.Drawing.Size(367, 324);
            this.tabPage_Register.TabIndex = 1;
            this.tabPage_Register.Text = "회원가입";
            this.tabPage_Register.VerticalScrollbarBarColor = true;
            // 
            // textBox_Register_EMail
            // 
            this.textBox_Register_EMail.Location = new System.Drawing.Point(3, 193);
            this.textBox_Register_EMail.Name = "textBox_Register_EMail";
            this.textBox_Register_EMail.Size = new System.Drawing.Size(361, 23);
            this.textBox_Register_EMail.TabIndex = 15;
            // 
            // label_Register_EMail
            // 
            this.label_Register_EMail.AutoSize = true;
            this.label_Register_EMail.Location = new System.Drawing.Point(3, 171);
            this.label_Register_EMail.Name = "label_Register_EMail";
            this.label_Register_EMail.Size = new System.Drawing.Size(51, 19);
            this.label_Register_EMail.TabIndex = 14;
            this.label_Register_EMail.Text = "이메일";
            // 
            // textBox_Register_REPW
            // 
            this.textBox_Register_REPW.Location = new System.Drawing.Point(3, 145);
            this.textBox_Register_REPW.Name = "textBox_Register_REPW";
            this.textBox_Register_REPW.PasswordChar = '*';
            this.textBox_Register_REPW.Size = new System.Drawing.Size(361, 23);
            this.textBox_Register_REPW.TabIndex = 13;
            // 
            // label_Register_REPW
            // 
            this.label_Register_REPW.AutoSize = true;
            this.label_Register_REPW.Location = new System.Drawing.Point(3, 123);
            this.label_Register_REPW.Name = "label_Register_REPW";
            this.label_Register_REPW.Size = new System.Drawing.Size(111, 19);
            this.label_Register_REPW.TabIndex = 12;
            this.label_Register_REPW.Text = "비밀번호 재입력";
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(3, 244);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(361, 23);
            this.button_Register.TabIndex = 16;
            this.button_Register.Text = "회원가입";
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // textBox_Register_PW
            // 
            this.textBox_Register_PW.Location = new System.Drawing.Point(3, 97);
            this.textBox_Register_PW.Name = "textBox_Register_PW";
            this.textBox_Register_PW.PasswordChar = '*';
            this.textBox_Register_PW.Size = new System.Drawing.Size(361, 23);
            this.textBox_Register_PW.TabIndex = 11;
            // 
            // label_Register_PW
            // 
            this.label_Register_PW.AutoSize = true;
            this.label_Register_PW.Location = new System.Drawing.Point(3, 75);
            this.label_Register_PW.Name = "label_Register_PW";
            this.label_Register_PW.Size = new System.Drawing.Size(65, 19);
            this.label_Register_PW.TabIndex = 10;
            this.label_Register_PW.Text = "비밀번호";
            // 
            // textBox_Register_ID
            // 
            this.textBox_Register_ID.Location = new System.Drawing.Point(3, 49);
            this.textBox_Register_ID.Name = "textBox_Register_ID";
            this.textBox_Register_ID.Size = new System.Drawing.Size(361, 23);
            this.textBox_Register_ID.TabIndex = 9;
            // 
            // label_Register_ID
            // 
            this.label_Register_ID.AutoSize = true;
            this.label_Register_ID.Location = new System.Drawing.Point(3, 27);
            this.label_Register_ID.Name = "label_Register_ID";
            this.label_Register_ID.Size = new System.Drawing.Size(51, 19);
            this.label_Register_ID.TabIndex = 8;
            this.label_Register_ID.Text = "아이디";
            // 
            // tabPage_IDSearch
            // 
            this.tabPage_IDSearch.Controls.Add(this.button_IDSearch);
            this.tabPage_IDSearch.Controls.Add(this.textBox_IDSearch_EMail);
            this.tabPage_IDSearch.Controls.Add(this.label_IDSearch_EMail);
            this.tabPage_IDSearch.HorizontalScrollbarBarColor = true;
            this.tabPage_IDSearch.Location = new System.Drawing.Point(4, 36);
            this.tabPage_IDSearch.Name = "tabPage_IDSearch";
            this.tabPage_IDSearch.Size = new System.Drawing.Size(367, 324);
            this.tabPage_IDSearch.TabIndex = 2;
            this.tabPage_IDSearch.Text = "아이디 찾기";
            this.tabPage_IDSearch.VerticalScrollbarBarColor = true;
            // 
            // button_IDSearch
            // 
            this.button_IDSearch.Location = new System.Drawing.Point(3, 100);
            this.button_IDSearch.Name = "button_IDSearch";
            this.button_IDSearch.Size = new System.Drawing.Size(361, 23);
            this.button_IDSearch.TabIndex = 13;
            this.button_IDSearch.Text = "아이디 찾기";
            this.button_IDSearch.Click += new System.EventHandler(this.button_IDSearch_Click);
            // 
            // textBox_IDSearch_EMail
            // 
            this.textBox_IDSearch_EMail.Location = new System.Drawing.Point(3, 49);
            this.textBox_IDSearch_EMail.Name = "textBox_IDSearch_EMail";
            this.textBox_IDSearch_EMail.Size = new System.Drawing.Size(361, 23);
            this.textBox_IDSearch_EMail.TabIndex = 11;
            // 
            // label_IDSearch_EMail
            // 
            this.label_IDSearch_EMail.AutoSize = true;
            this.label_IDSearch_EMail.Location = new System.Drawing.Point(3, 27);
            this.label_IDSearch_EMail.Name = "label_IDSearch_EMail";
            this.label_IDSearch_EMail.Size = new System.Drawing.Size(51, 19);
            this.label_IDSearch_EMail.TabIndex = 10;
            this.label_IDSearch_EMail.Text = "이메일";
            // 
            // tabPage_PWChange
            // 
            this.tabPage_PWChange.Controls.Add(this.textBox_PWChange_RENEWPW);
            this.tabPage_PWChange.Controls.Add(this.label_PWChange_RENEWPW);
            this.tabPage_PWChange.Controls.Add(this.textBox_PWChange_NEWPW);
            this.tabPage_PWChange.Controls.Add(this.label_PWChange_NEWPW);
            this.tabPage_PWChange.Controls.Add(this.textBox_PWChange_ID);
            this.tabPage_PWChange.Controls.Add(this.label_PWChange_ID);
            this.tabPage_PWChange.Controls.Add(this.button_PWChange);
            this.tabPage_PWChange.Controls.Add(this.textBox_PWChange_EMail);
            this.tabPage_PWChange.Controls.Add(this.label_PWChange_EMail);
            this.tabPage_PWChange.HorizontalScrollbarBarColor = true;
            this.tabPage_PWChange.Location = new System.Drawing.Point(4, 36);
            this.tabPage_PWChange.Name = "tabPage_PWChange";
            this.tabPage_PWChange.Size = new System.Drawing.Size(367, 324);
            this.tabPage_PWChange.TabIndex = 3;
            this.tabPage_PWChange.Text = "비밀번호 변경";
            this.tabPage_PWChange.VerticalScrollbarBarColor = true;
            // 
            // textBox_PWChange_RENEWPW
            // 
            this.textBox_PWChange_RENEWPW.Location = new System.Drawing.Point(3, 193);
            this.textBox_PWChange_RENEWPW.Name = "textBox_PWChange_RENEWPW";
            this.textBox_PWChange_RENEWPW.PasswordChar = '*';
            this.textBox_PWChange_RENEWPW.Size = new System.Drawing.Size(361, 23);
            this.textBox_PWChange_RENEWPW.TabIndex = 22;
            // 
            // label_PWChange_RENEWPW
            // 
            this.label_PWChange_RENEWPW.AutoSize = true;
            this.label_PWChange_RENEWPW.Location = new System.Drawing.Point(3, 171);
            this.label_PWChange_RENEWPW.Name = "label_PWChange_RENEWPW";
            this.label_PWChange_RENEWPW.Size = new System.Drawing.Size(157, 19);
            this.label_PWChange_RENEWPW.TabIndex = 21;
            this.label_PWChange_RENEWPW.Text = "새로운 비밀번호 재입력";
            // 
            // textBox_PWChange_NEWPW
            // 
            this.textBox_PWChange_NEWPW.Location = new System.Drawing.Point(3, 145);
            this.textBox_PWChange_NEWPW.Name = "textBox_PWChange_NEWPW";
            this.textBox_PWChange_NEWPW.PasswordChar = '*';
            this.textBox_PWChange_NEWPW.Size = new System.Drawing.Size(361, 23);
            this.textBox_PWChange_NEWPW.TabIndex = 20;
            // 
            // label_PWChange_NEWPW
            // 
            this.label_PWChange_NEWPW.AutoSize = true;
            this.label_PWChange_NEWPW.Location = new System.Drawing.Point(3, 123);
            this.label_PWChange_NEWPW.Name = "label_PWChange_NEWPW";
            this.label_PWChange_NEWPW.Size = new System.Drawing.Size(111, 19);
            this.label_PWChange_NEWPW.TabIndex = 19;
            this.label_PWChange_NEWPW.Text = "새로운 비밀번호";
            // 
            // textBox_PWChange_ID
            // 
            this.textBox_PWChange_ID.Location = new System.Drawing.Point(3, 49);
            this.textBox_PWChange_ID.Name = "textBox_PWChange_ID";
            this.textBox_PWChange_ID.Size = new System.Drawing.Size(361, 23);
            this.textBox_PWChange_ID.TabIndex = 18;
            // 
            // label_PWChange_ID
            // 
            this.label_PWChange_ID.AutoSize = true;
            this.label_PWChange_ID.Location = new System.Drawing.Point(3, 27);
            this.label_PWChange_ID.Name = "label_PWChange_ID";
            this.label_PWChange_ID.Size = new System.Drawing.Size(51, 19);
            this.label_PWChange_ID.TabIndex = 17;
            this.label_PWChange_ID.Text = "아이디";
            // 
            // button_PWChange
            // 
            this.button_PWChange.Location = new System.Drawing.Point(3, 244);
            this.button_PWChange.Name = "button_PWChange";
            this.button_PWChange.Size = new System.Drawing.Size(361, 23);
            this.button_PWChange.TabIndex = 16;
            this.button_PWChange.Text = "비밀번호 변경";
            this.button_PWChange.Click += new System.EventHandler(this.button_PWChange_Click);
            // 
            // textBox_PWChange_EMail
            // 
            this.textBox_PWChange_EMail.Location = new System.Drawing.Point(3, 97);
            this.textBox_PWChange_EMail.Name = "textBox_PWChange_EMail";
            this.textBox_PWChange_EMail.Size = new System.Drawing.Size(361, 23);
            this.textBox_PWChange_EMail.TabIndex = 15;
            // 
            // label_PWChange_EMail
            // 
            this.label_PWChange_EMail.AutoSize = true;
            this.label_PWChange_EMail.Location = new System.Drawing.Point(3, 75);
            this.label_PWChange_EMail.Name = "label_PWChange_EMail";
            this.label_PWChange_EMail.Size = new System.Drawing.Size(51, 19);
            this.label_PWChange_EMail.TabIndex = 14;
            this.label_PWChange_EMail.Text = "이메일";
            // 
            // button_Logout
            // 
            this.button_Logout.Location = new System.Drawing.Point(1087, 462);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(75, 23);
            this.button_Logout.TabIndex = 28;
            this.button_Logout.Text = "로그아웃";
            this.button_Logout.Visible = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(1057, 488);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(105, 19);
            this.label_UserName.TabIndex = 29;
            this.label_UserName.Text = "label_UserName";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 678);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.tabControl_Login);
            this.Controls.Add(this.button_Login_Close);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_MiniFace_Upload);
            this.Controls.Add(this.button_MiniFace_Report);
            this.Controls.Add(this.button_MiniFace_Select);
            this.Controls.Add(this.picturebox_MiniFace);
            this.Controls.Add(this.label_MiniFace_Name);
            this.Controls.Add(this.listbox_MiniFace);
            this.Controls.Add(this.label_checkFIFA4);
            this.Controls.Add(this.button_MiniFace);
            this.Controls.Add(this.label_After_Name);
            this.Controls.Add(this.picturebox_Season);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_After_Open);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label_After);
            this.Controls.Add(this.button_After);
            this.Controls.Add(this.picturebox_After);
            this.Controls.Add(this.label_Before);
            this.Controls.Add(this.button_Before);
            this.Controls.Add(this.label_nowLocation);
            this.Controls.Add(this.button_changeLocation);
            this.Controls.Add(this.picturebox_Before);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textbox_Search);
            this.Controls.Add(this.listbox_Character);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.Text = "FIFA4 Miniface Changer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_After)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_MiniFace)).EndInit();
            this.tabControl_Login.ResumeLayout(false);
            this.tabPage_Login.ResumeLayout(false);
            this.tabPage_Login.PerformLayout();
            this.tabPage_Register.ResumeLayout(false);
            this.tabPage_Register.PerformLayout();
            this.tabPage_IDSearch.ResumeLayout(false);
            this.tabPage_IDSearch.PerformLayout();
            this.tabPage_PWChange.ResumeLayout(false);
            this.tabPage_PWChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_Character;
        private MetroFramework.Controls.MetroTextBox textbox_Search;
        private MetroFramework.Controls.MetroButton button_Search;
        private System.Windows.Forms.PictureBox picturebox_Before;
        private MetroFramework.Controls.MetroButton button_changeLocation;
        private MetroFramework.Controls.MetroLabel label_nowLocation;
        private MetroFramework.Controls.MetroButton button_Before;
        private MetroFramework.Controls.MetroLabel label_Before;
        private MetroFramework.Controls.MetroLabel label_After;
        private MetroFramework.Controls.MetroButton button_After;
        private System.Windows.Forms.PictureBox picturebox_After;
        private MetroFramework.Controls.MetroButton button_Change;
        private MetroFramework.Controls.MetroButton button_After_Open;
        private MetroFramework.Controls.MetroLabel label_Name;
        private System.Windows.Forms.PictureBox picturebox_Season;
        private MetroFramework.Controls.MetroLabel label_After_Name;
        private MetroFramework.Controls.MetroButton button_MiniFace;
        private MetroFramework.Controls.MetroLabel label_checkFIFA4;
        private System.Windows.Forms.ListBox listbox_MiniFace;
        private MetroFramework.Controls.MetroLabel label_MiniFace_Name;
        private System.Windows.Forms.PictureBox picturebox_MiniFace;
        private MetroFramework.Controls.MetroButton button_MiniFace_Select;
        private MetroFramework.Controls.MetroButton button_MiniFace_Report;
        private MetroFramework.Controls.MetroButton button_MiniFace_Upload;
        private MetroFramework.Controls.MetroButton button_Login;
        private MetroFramework.Controls.MetroButton button_Login_Close;
        private MetroFramework.Controls.MetroTabControl tabControl_Login;
        private MetroFramework.Controls.MetroTabPage tabPage_Login;
        private MetroFramework.Controls.MetroCheckBox checkBox_Login_IDSave;
        private MetroFramework.Controls.MetroButton button_Login_Login;
        private MetroFramework.Controls.MetroTextBox textBox_Login_PW;
        private MetroFramework.Controls.MetroLabel label_Login_PW;
        private MetroFramework.Controls.MetroTextBox textBox_Login_ID;
        private MetroFramework.Controls.MetroLabel label_Login_ID;
        private MetroFramework.Controls.MetroTabPage tabPage_Register;
        private MetroFramework.Controls.MetroTextBox textBox_Register_EMail;
        private MetroFramework.Controls.MetroLabel label_Register_EMail;
        private MetroFramework.Controls.MetroTextBox textBox_Register_REPW;
        private MetroFramework.Controls.MetroLabel label_Register_REPW;
        private MetroFramework.Controls.MetroButton button_Register;
        private MetroFramework.Controls.MetroTextBox textBox_Register_PW;
        private MetroFramework.Controls.MetroLabel label_Register_PW;
        private MetroFramework.Controls.MetroTextBox textBox_Register_ID;
        private MetroFramework.Controls.MetroLabel label_Register_ID;
        private MetroFramework.Controls.MetroTabPage tabPage_IDSearch;
        private MetroFramework.Controls.MetroButton button_IDSearch;
        private MetroFramework.Controls.MetroTextBox textBox_IDSearch_EMail;
        private MetroFramework.Controls.MetroLabel label_IDSearch_EMail;
        private MetroFramework.Controls.MetroTabPage tabPage_PWChange;
        private MetroFramework.Controls.MetroTextBox textBox_PWChange_RENEWPW;
        private MetroFramework.Controls.MetroLabel label_PWChange_RENEWPW;
        private MetroFramework.Controls.MetroTextBox textBox_PWChange_NEWPW;
        private MetroFramework.Controls.MetroLabel label_PWChange_NEWPW;
        private MetroFramework.Controls.MetroTextBox textBox_PWChange_ID;
        private MetroFramework.Controls.MetroLabel label_PWChange_ID;
        private MetroFramework.Controls.MetroButton button_PWChange;
        private MetroFramework.Controls.MetroTextBox textBox_PWChange_EMail;
        private MetroFramework.Controls.MetroLabel label_PWChange_EMail;
        private MetroFramework.Controls.MetroButton button_Logout;
        private MetroFramework.Controls.MetroLabel label_UserName;
    }
}