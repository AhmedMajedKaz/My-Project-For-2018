using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voice = new SpeechSynthesizer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                switch (cor.SelectedIndex)
                {
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case 2:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 3:
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                    default:
                        break;
                }
                voice.SpeakAsync(textBox1.Text);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using(SaveFileDialog df = new SaveFileDialog())
                {
                    df.Title = "wave file";
                    if(df.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(df.FileName,FileMode.Create,FileAccess.Write);
                        voice.SetOutputToWaveStream(fs);
                        voice.Speak(textBox1.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
