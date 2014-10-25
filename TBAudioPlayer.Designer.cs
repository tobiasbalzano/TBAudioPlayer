namespace TBAudioPlayer
{
    partial class TBAudioPlayer
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
            this.components = new System.ComponentModel.Container();
            this.lblNowPLaying = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.updateGuiTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLoadSong = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPlayList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNowPLaying
            // 
            this.lblNowPLaying.Location = new System.Drawing.Point(13, 13);
            this.lblNowPLaying.Name = "lblNowPLaying";
            this.lblNowPLaying.Size = new System.Drawing.Size(363, 13);
            this.lblNowPLaying.TabIndex = 0;
            this.lblNowPLaying.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.Filter = "\"Mp3 files|*.mp3|All files|*.*\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // updateGuiTimer
            // 
            this.updateGuiTimer.Interval = 33;
            this.updateGuiTimer.Tick += new System.EventHandler(this.updateGuiTimer_Tick);
            // 
            // btnLoadSong
            // 
            this.btnLoadSong.Location = new System.Drawing.Point(333, 265);
            this.btnLoadSong.Name = "btnLoadSong";
            this.btnLoadSong.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSong.TabIndex = 2;
            this.btnLoadSong.Text = "button1";
            this.btnLoadSong.UseVisualStyleBackColor = true;
            this.btnLoadSong.Click += new System.EventHandler(this.btnLoadSong_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Webdings", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(203, 120);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 60);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "4";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 24);
            this.panel1.TabIndex = 4;
            // 
            // pnlPlayList
            // 
            this.pnlPlayList.AllowDrop = true;
            this.pnlPlayList.AutoScroll = true;
            this.pnlPlayList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlPlayList.Location = new System.Drawing.Point(417, 12);
            this.pnlPlayList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlayList.Name = "pnlPlayList";
            this.pnlPlayList.Size = new System.Drawing.Size(223, 276);
            this.pnlPlayList.TabIndex = 5;
            this.pnlPlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayList_DragDrop);
            this.pnlPlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPlayList_DragEnter);
            // 
            // TBAudioPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 300);
            this.Controls.Add(this.pnlPlayList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.btnLoadSong);
            this.Controls.Add(this.lblNowPLaying);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TBAudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNowPLaying;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer updateGuiTimer;
        private System.Windows.Forms.Button btnLoadSong;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPlayList;
    }
}

