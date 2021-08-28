
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
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Before)).BeginInit();
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
            this.picturebox_Before.Location = new System.Drawing.Point(373, 63);
            this.picturebox_Before.Name = "picturebox_Before";
            this.picturebox_Before.Size = new System.Drawing.Size(128, 128);
            this.picturebox_Before.TabIndex = 3;
            this.picturebox_Before.TabStop = false;
            // 
            // button_changeLocation
            // 
            this.button_changeLocation.Location = new System.Drawing.Point(23, 332);
            this.button_changeLocation.Name = "button_changeLocation";
            this.button_changeLocation.Size = new System.Drawing.Size(75, 23);
            this.button_changeLocation.TabIndex = 4;
            this.button_changeLocation.Text = "위치 변경";
            this.button_changeLocation.Click += new System.EventHandler(this.button_changeLocation_Click);
            // 
            // label_nowLocation
            // 
            this.label_nowLocation.AutoSize = true;
            this.label_nowLocation.Location = new System.Drawing.Point(23, 310);
            this.label_nowLocation.Name = "label_nowLocation";
            this.label_nowLocation.Size = new System.Drawing.Size(80, 19);
            this.label_nowLocation.TabIndex = 5;
            this.label_nowLocation.Text = "FIFA4 위치: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 378);
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
    }
}