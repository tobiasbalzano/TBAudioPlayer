using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using IrrKlang;


namespace TBAudioPlayer
{
    public partial class TBAudioPlayer : Form
    {
        static ISoundEngine mainSoundEngine = new ISoundEngine(SoundOutputDriver.AutoDetect);
        static ISoundSource playingFile;
        ISound currentlyPlaying;
        string playFileLocation;
        int currentPlayPos;
        Image[] trackBarImages = new Image[] { Properties.Resources.trackBarOff, Properties.Resources.trackBarOn };
        trackBarImage trackBar;
        List<trackBarImage> trackBarList;
        int trackBarIncrement;
        int trackBarPos;
        List<playListItem> playList = new List<playListItem>();

        public TBAudioPlayer()
        {
            InitializeComponent();
            drawTrackBar(trackBarImages[0].Width);
            updateGuiTimer.Start();
        }

        private void playFile()
        {
            resetTrackBar();
            mainSoundEngine.RemoveAllSoundSources();
            playingFile = mainSoundEngine.AddSoundSourceFromFile(playFileLocation);
            currentlyPlaying = mainSoundEngine.Play2D(playingFile.Name);
            trackBarIncrement = (int)playingFile.PlayLength / trackBarList.Count();
            trackBarPos = 0;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            playFileLocation = openFileDialog1.FileName;
        }

        private void updateGuiTimer_Tick(object sender, EventArgs e)
        {
            int oldTrackBarPos = trackBarPos;
            if (currentlyPlaying != null)
            {
                currentPlayPos = (int)currentlyPlaying.PlayPosition;
            }
            if (currentlyPlaying != null)
            {
                for (int os = oldTrackBarPos; os == trackBarPos && os < trackBarList.Count(); os++)
                {
                    trackBarList[os].Image = trackBarImages[1];
                }
            }
            while (currentPlayPos > trackBarPos * trackBarIncrement)
            {
                trackBarPos++;
            }
            try
            {
                lblNowPLaying.Text = Path.GetFileNameWithoutExtension(playingFile.Name);
            }
            catch
            {
                lblNowPLaying.Text = "No file currently playing";
            }

        }

        private void btnLoadSong_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                playFile();
            }
            catch
            {
                openFileDialog1.ShowDialog();
                if (playFileLocation != null)
                {
                    playFile();
                }
            }
        }

        protected void drawTrackBar(int _imageWidth)
        {
            trackBarList = new List<trackBarImage>();
            int trackBarTotalImages = 400 / _imageWidth;
            for (int i = 0; i < trackBarTotalImages; i++)
            {
                trackBar = new trackBarImage();
                trackBar.Location = new System.Drawing.Point(i * _imageWidth, 0);
                trackBar.Margin = new System.Windows.Forms.Padding(0);
                trackBar.Size = new System.Drawing.Size(trackBarImages[0].Width, trackBarImages[0].Height);
                trackBar.Image = trackBarImages[0];
                panel1.Controls.Add(trackBar);
                trackBarList.Add(trackBar);

            }
        }

        protected void resetTrackBar()
        {
            foreach (trackBarImage i in trackBarList)
            {
                i.Image = trackBarImages[0];
            }
        }

        private void clickPlayList_Click(object sender, EventArgs e)
        {
            playListItem click = (playListItem)sender;
            playFileLocation = click.filePath;
            playFile();
        }

        private void pnlPlayList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlPlayList_DragDrop(object sender, DragEventArgs e)
        {
            
            string[] droppedFilePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string droppedFilePath = droppedFilePaths[0];
            playListItem newPlaylistItem = new playListItem(droppedFilePath, clickPlayList_Click);
            newPlaylistItem.Location = new System.Drawing.Point(0, playList.Count() * newPlaylistItem.Size.Height);
            playList.Add(newPlaylistItem);
            pnlPlayList.Controls.Add(newPlaylistItem);
        }

    }
}
