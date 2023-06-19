using System;
using System.Media;
using System.Windows.Forms;

namespace Gece_Gunduz_Ses_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int tkr = rnd.Next(1, 3);
            if (tkr == 1)
            {
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = "Gece.wav";
                ses.Play();
            }
            if (tkr == 2)
            {
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = "Gunduz.wav";
                ses.Play();
            }
        }
    }
}
