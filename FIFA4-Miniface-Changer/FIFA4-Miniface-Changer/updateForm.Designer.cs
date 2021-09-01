
namespace FIFA4_Miniface_Changer
{
    partial class updateForm
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
            this.label_nowVersion = new MetroFramework.Controls.MetroLabel();
            this.label_newVersion = new MetroFramework.Controls.MetroLabel();
            this.label_UpdateLog = new MetroFramework.Controls.MetroLabel();
            this.label_UpdateLog_Value = new MetroFramework.Controls.MetroLabel();
            this.button_Close = new MetroFramework.Controls.MetroButton();
            this.button_Download = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label_nowVersion
            // 
            this.label_nowVersion.AutoSize = true;
            this.label_nowVersion.Location = new System.Drawing.Point(23, 60);
            this.label_nowVersion.Name = "label_nowVersion";
            this.label_nowVersion.Size = new System.Drawing.Size(109, 19);
            this.label_nowVersion.TabIndex = 0;
            this.label_nowVersion.Text = "label_nowVersion";
            // 
            // label_newVersion
            // 
            this.label_newVersion.AutoSize = true;
            this.label_newVersion.Location = new System.Drawing.Point(23, 79);
            this.label_newVersion.Name = "label_newVersion";
            this.label_newVersion.Size = new System.Drawing.Size(108, 19);
            this.label_newVersion.TabIndex = 1;
            this.label_newVersion.Text = "label_newVersion";
            // 
            // label_UpdateLog
            // 
            this.label_UpdateLog.AutoSize = true;
            this.label_UpdateLog.Location = new System.Drawing.Point(23, 109);
            this.label_UpdateLog.Name = "label_UpdateLog";
            this.label_UpdateLog.Size = new System.Drawing.Size(97, 19);
            this.label_UpdateLog.TabIndex = 3;
            this.label_UpdateLog.Text = "업데이트 로그";
            // 
            // label_UpdateLog_Value
            // 
            this.label_UpdateLog_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_UpdateLog_Value.Location = new System.Drawing.Point(23, 128);
            this.label_UpdateLog_Value.Name = "label_UpdateLog_Value";
            this.label_UpdateLog_Value.Size = new System.Drawing.Size(490, 190);
            this.label_UpdateLog_Value.TabIndex = 4;
            this.label_UpdateLog_Value.Text = "업데이트 로그";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(438, 321);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "나중에";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(357, 321);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 6;
            this.button_Download.Text = "다운로드";
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 367);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label_UpdateLog_Value);
            this.Controls.Add(this.label_UpdateLog);
            this.Controls.Add(this.label_newVersion);
            this.Controls.Add(this.label_nowVersion);
            this.MaximizeBox = false;
            this.Name = "updateForm";
            this.Resizable = false;
            this.Text = "새로운 업데이트가 발견되었습니다.";
            this.Load += new System.EventHandler(this.updateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label_nowVersion;
        private MetroFramework.Controls.MetroLabel label_newVersion;
        private MetroFramework.Controls.MetroLabel label_UpdateLog;
        private MetroFramework.Controls.MetroLabel label_UpdateLog_Value;
        private MetroFramework.Controls.MetroButton button_Close;
        private MetroFramework.Controls.MetroButton button_Download;
    }
}