
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
            this.label_Author = new MetroFramework.Controls.MetroLabel();
            this.label_Name = new MetroFramework.Controls.MetroLabel();
            this.picturebox_Season = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_After)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Season)).BeginInit();
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
            this.picturebox_Before.TabIndex = 3;
            this.picturebox_Before.TabStop = false;
            // 
            // button_changeLocation
            // 
            this.button_changeLocation.Location = new System.Drawing.Point(23, 336);
            this.button_changeLocation.Name = "button_changeLocation";
            this.button_changeLocation.Size = new System.Drawing.Size(75, 23);
            this.button_changeLocation.TabIndex = 4;
            this.button_changeLocation.Text = "위치 변경";
            this.button_changeLocation.Click += new System.EventHandler(this.button_changeLocation_Click);
            // 
            // label_nowLocation
            // 
            this.label_nowLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_nowLocation.Location = new System.Drawing.Point(23, 310);
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
            this.label_Before.Location = new System.Drawing.Point(373, 91);
            this.label_Before.Name = "label_Before";
            this.label_Before.Size = new System.Drawing.Size(128, 23);
            this.label_Before.TabIndex = 7;
            this.label_Before.Text = "변경 전 미페";
            this.label_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_After
            // 
            this.label_After.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_After.Location = new System.Drawing.Point(588, 91);
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
            this.picturebox_After.Location = new System.Drawing.Point(588, 150);
            this.picturebox_After.Name = "picturebox_After";
            this.picturebox_After.Size = new System.Drawing.Size(128, 128);
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
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Author.Location = new System.Drawing.Point(23, 362);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(128, 19);
            this.label_Author.TabIndex = 13;
            this.label_Author.Text = "제작자: 마마문별이";
            this.label_Author.UseStyleColors = true;
            // 
            // label_Name
            // 
            this.label_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Name.Location = new System.Drawing.Point(409, 117);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(92, 24);
            this.label_Name.TabIndex = 14;
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturebox_Season
            // 
            this.picturebox_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_Season.Location = new System.Drawing.Point(373, 117);
            this.picturebox_Season.Name = "picturebox_Season";
            this.picturebox_Season.Size = new System.Drawing.Size(30, 24);
            this.picturebox_Season.TabIndex = 15;
            this.picturebox_Season.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 382);
            this.Controls.Add(this.picturebox_Season);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Author);
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
        private MetroFramework.Controls.MetroLabel label_Author;
        private MetroFramework.Controls.MetroLabel label_Name;
        private System.Windows.Forms.PictureBox picturebox_Season;
    }
}