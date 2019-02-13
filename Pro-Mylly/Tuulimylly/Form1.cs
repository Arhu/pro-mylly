using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Tuulimylly2._0
{
    public partial class Form1 : MaterialForm
    {
        //Tässä alustetaan muuttujat
        public decimal nopeusvali;
        public bool messageboxit = false;
        public bool avaajutska = true;
        public string nettiosoite;
        public bool autowrite = false;
        public string omateksti;
        public string cmdkirj;
        public bool notepad = false;
        public bool hiirikaka = true;
        public bool sysbubbles = false;
        public bool cmd;
        public bool glitch = false;
        Random rnd = new Random();
        

        public Form1()
        {
            InitializeComponent();

            // Tehdään materiaali teema manageri ja lisätään se formiin (tämä)
            // Lisää tietoa:
            //https://ourcodeworld.com/articles/read/441/how-to-use-material-design-controls-with-c-in-your-winforms-application

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configuroidaan värit
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.Pink400, Primary.LightBlue900, Accent.Orange700, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            if (autowrite == false && hiirikaka == false && sysbubbles == true && notepad == false && avaajutska == false)
            {
                MessageBox.Show("But nothing happened...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Tässä kaikki tärkeä tapahtuu
            nettiosoite = textBox2.Text;
            omateksti = textBox1.Text;
            MessageBox.Show("Tuulimylly", "bataatti", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            nopeusvali = numericUpDown1.Value;
            //nopeusväli (nspv1) muutetaan decimaalista integeriksi.
            int npsvl = (int)nopeusvali;
            /*
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Aapewi.wav");
            player.Play();
            */
            while (true)
            {
                if (glitch == true)
                {
                    new Overlay().Show();
                }
                this.BringToFront();
                this.Activate();
                //jos hiiirikaka on päällä, se liikuttaa hiirtä määrättyyn paikkaan.
                if (hiirikaka == true)
                {
                    int rnd2 = rnd.Next(1, 500);
                    Cursor.Position = new Point(Cursor.Position.X + rnd2, Cursor.Position.Y + rnd2);
                }
                System.Threading.Thread.Sleep(npsvl);
                if (notepad == true)
                {
                    System.Diagnostics.Process.Start("notepad.exe");
                }
                System.Threading.Thread.Sleep(npsvl);
                if (cmd == true)
                {
                    System.Diagnostics.Process.Start("cmd.exe");
                }
                System.Threading.Thread.Sleep(npsvl);
                if (avaajutska == true)
                {
                    System.Threading.Thread.Sleep(npsvl);
                    System.Diagnostics.Process.Start(nettiosoite);

                }
                if (sysbubbles == true)
                {
                    System.Diagnostics.Process.Start("Bubbles.scr");
                }
                //hiirikaka tehdään toiseen kertaan
                if (hiirikaka == true)
                {
                    int rnd2 = rnd.Next(1, 500);
                    Cursor.Position = new Point(Cursor.Position.X + rnd2, Cursor.Position.Y + rnd2);
                    Cursor.Hide();
                }
                if (messageboxit == true)
                {
                    MessageBox.Show("Tuulimylly iskee jälleen");
                    System.Threading.Thread.Sleep(npsvl);
                }
                if (autowrite == true)
                {
                    SendKeys.Send(omateksti);
                }



            }
        }


        //Kaikki asetukset määrätään tästä eteenpäin
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            messageboxit = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            hiirikaka = false;
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            avaajutska = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            notepad = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            autowrite = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            sysbubbles = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            cmd = false;
        }

        private void Lisätietoa_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            new Muut_versiot().Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            //Tämä nappi tahallaan crashaa Tuulimyllyn
            System.Diagnostics.Debug.Print("Käyttäjä crashasi Tuulimyllyn.");
            System.Diagnostics.Process.Start("€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€");
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            glitch = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vaingald/Tuulimylly");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Ohjeet().Show();
        }
    }
}
