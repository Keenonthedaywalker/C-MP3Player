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

namespace Music_Player_Forms_Edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creates Media Player
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        //Creates Openfiledialog
        OpenFileDialog dlg = new OpenFileDialog();

        SoundPlayer splayer = new SoundPlayer();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //A filter if you only want to display specific files.
            //dlg.Filter = "MP3|*.mp3";

            //Will only continue with the code if user selects a file and presses ok.
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = dlg.FileName;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            wplayer.URL = textBox1.Text;
            wplayer.controls.play();

        }

        bool isPaused = true;

        private void pauseButton_Click(object sender, EventArgs e)
        {

            if (isPaused)
            {
                wplayer.controls.pause();

                isPaused = false;

                pauseButton.Image = Image.FromFile("C:\\Users\\keeno\\source\\repos\\Music_Player_Forms_Edition\\images\\play_button.png");

            } else
            {
                wplayer.controls.play();

                isPaused = true;

                pauseButton.Image = Image.FromFile("C:\\Users\\keeno\\source\\repos\\Music_Player_Forms_Edition\\images\\pause_button.png");
            }
           

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }


       /* private string TimeFormat(int iMilliseconds)
        {

            int iTotalseconds = iMilliseconds / 1000;
            int hours = (iTotalseconds >= 3600) ? iTotalseconds / 3600 : 0;
            int hours_res = (iTotalseconds >= 3600) ? iTotalseconds - (hours * 3600) : iTotalseconds;
            int minutes = hours_res / 60;
            int minutes_res = hours_res - (minutes * 60);
            int seconds = minutes_res % 60;
            string strTimeString = String.Format("{0,1}:{1,2:D2}:{2,2:D2}", hours, minutes, seconds);
            return strTimeString;

        } */

    }
}
