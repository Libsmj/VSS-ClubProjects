using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Media;
using System.Windows.Forms;

namespace GSN_Timer
{
    public partial class Form1 : Form
    {
        int Time = 0;
        int Min;
        int Sec;
        SoundPlayer Buzz = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\Buzz1.wav");

        private Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void buttonTime1_Click(object sender, EventArgs e)
        {
            Time = 1 * 60;
            labelTimeDisplay.Text = "Time: " + Time;
            Sec = Time;
            if (Time >= 60)
            {
                while (Sec >= 60)
                {
                    Sec = Sec - 60;
                    Min++;
                }
            }
            if (Sec < 10)
            {
                form2.labelTime2.Text = "" + Min + ":0" + Sec;
            }
            else
            {
                form2.labelTime2.Text = "" + Min + ":" + Sec;
            }
            Min = 0;
        }

        private void buttonTime5_Click(object sender, EventArgs e)
        {
            Time = 5 * 60;
            labelTimeDisplay.Text = "Time: " + Time;
            Sec = Time;
            if (Time >= 60)
            {
                while (Sec >= 60)
                {
                    Sec = Sec - 60;
                    Min++;
                }
            }
            if (Sec < 10)
            {
                form2.labelTime2.Text = "" + Min + ":0" + Sec;
            }
            else
            {
                form2.labelTime2.Text = "" + Min + ":" + Sec;
            }
            Min = 0;
        }

        private void buttonTime8_Click(object sender, EventArgs e)
        {
            Time = 8 * 60;
            labelTimeDisplay.Text = "Time: " + Time;
            Sec = Time;
            if (Time >= 60)
            {
                while (Sec >= 60)
                {
                    Sec = Sec - 60;
                    Min++;
                }
            }
            if (Sec < 10)
            {
                form2.labelTime2.Text = "" + Min + ":0" + Sec;
            }
            else
            {
                form2.labelTime2.Text = "" + Min + ":" + Sec;
            }
            Min = 0;
        }

        private void buttonTimeSet_Click(object sender, EventArgs e)
        {
            if (textBoxCustomTimeMinutes.Text != "")
            {
                Time = Int32.Parse(textBoxCustomTimeMinutes.Text) * 60;
            }
            if (textBoxCustomTimeSeconds.Text != "")
            {
                Time = Time + Int32.Parse(textBoxCustomTimeSeconds.Text);
            }
            Sec = Time;
            if (Time >= 60)
            {
                while (Sec >= 60)
                {
                    Sec = Sec - 60;
                    Min++;
                }
            }
            if (Sec < 10)
            {
                form2.labelTime2.Text = "" + Min + ":0" + Sec;
            }
            else
            {
                form2.labelTime2.Text = "" + Min + ":" + Sec;
            }
            Min = 0;
            labelTimeDisplay.Text = "" + Time;
            textBoxCustomTimeMinutes.Text = "";
            textBoxCustomTimeSeconds.Text = "";
        }

        private void buttonTimeStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void buttonTimeStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void buttonBuzz_Click(object sender, EventArgs e)
        {
            Buzz.Play();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time--;
            Sec = Time;
            if (Time >= 60)
            {
                while (Sec >= 60)
                {
                    Sec = Sec - 60;
                    Min++;
                }
            }
            if (Sec < 10)
            {
                form2.labelTime2.Text = "" + Min + ":0" + Sec;
            }
            else
            {
                form2.labelTime2.Text = "" + Min + ":" + Sec;
            }
            Min = 0;
            if (Time == 0)
            {
                if (checkBoxBuzz.Checked == true)
                    Buzz.Play();
                timer.Enabled = false;
                Time = 1;
            }
        }

        private void checkBoxBuzz_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}