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

namespace playlist_linkedlist
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }
        DoubleLinkedList listname = new DoubleLinkedList();
        DoubleLinkedList listpath = new DoubleLinkedList();
        string value;
        string songname;
        //Lấy file nhạc
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";// lọc file có đuôi mp3, mp4, ....
            openfile.Multiselect = true;//Chọn nhiều file
            openfile.Title = "Chọn file";//Tên
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in openfile.FileNames)
                    listpath.AddLast(item);
                foreach (string item in openfile.SafeFileNames)
                {
                    listname.AddLast(item.Replace(".mp3", ""));
                    listBox1.Items.Add(item.Replace(".mp3", ""));
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chosse = listBox1.SelectedIndex + 1;
            int dem_path = 0;
            songname = listname.First.Value; 
            value = listpath.First.Value;
            for (int i = 0;; i++)
            {
                dem_path++;
                if (dem_path == chosse)
                {
                    axWindowsMediaPlayer1.URL = value;
                    song_name.Text = songname;
                    break;
                }
                value = listpath.Find(value).Next.Value;
                songname = listname.Find(songname).Next.Value;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            trangthai.Text = "Playing....";
            timer1.Start();
            trackBar1.Value = 10;
            voLume_value.Text = (trackBar1.Value*10).ToString() + "%";
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (value != null)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                trangthai.Text = "Playing....";
            } 
            else
            {
                songname = listname.First.Value;
                song_name.Text = songname;

                value = listpath.First.Value;
                axWindowsMediaPlayer1.URL = value;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                trangthai.Text = "Playing....";
                timer1.Start();
            }    
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (value != null)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                trangthai.Text = "Stopping....";
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (value == listpath.Last.Value)
            {
                songname = listname.First.Value;
                song_name.Text = songname;

                value = listpath.First.Value;
                axWindowsMediaPlayer1.URL = value;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                trangthai.Text = "Playing....";
            }    
            else
            {
                value = listpath.Find(value).Next.Value;
                songname = listname.Find(songname).Next.Value;
                if (value != null)
                {
                    song_name.Text = songname;
                    axWindowsMediaPlayer1.URL = value;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    trangthai.Text = "Playing....";
                }
            }    
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (value == listpath.First.Value)
            {
                songname = listname.Last.Value;
                song_name.Text = songname;

                value = listpath.Last.Value;
                axWindowsMediaPlayer1.URL = value;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                trangthai.Text = "Playing....";
            }
            else
            {
                value = listpath.Find(value).Previous.Value;
                songname = listname.Find(songname).Previous.Value;
                if (value != null)
                {
                    song_name.Text = songname;
                    axWindowsMediaPlayer1.URL = value;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    trangthai.Text = "Playing....";
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }    
            start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString.ToString();
            finish.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                if (value == listpath.Last.Value)
                {
                    songname = listname.First.Value;
                    song_name.Text = songname;

                    value = listpath.First.Value;
                    axWindowsMediaPlayer1.URL = value;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    trangthai.Text = "Playing....";
                }
                else
                {
                    songname = listname.Find(songname).Next.Value;
                    value = listpath.Find(value).Next.Value;
                    if (value != null)
                    {
                        song_name.Text = songname;
                        axWindowsMediaPlayer1.URL = value;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        trangthai.Text = "Playing....";
                    }
                }
            }    
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            voLume_value.Text = (trackBar1.Value * 10).ToString() + "%";
        }
    }
}
