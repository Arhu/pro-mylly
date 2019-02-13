using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuulimylly2._0
{
    public partial class Muut_versiot : Form
    {
        public Muut_versiot()
        {
            InitializeComponent();
        }

        private void Muut_versiot_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/rt5ju9k7dp1fej7/Tuulimylly.exe?dl=1");
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/ctla5ps9vbelet6/Tuulimylly2.0.exe?dl=1");
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/sh/qld65kf6gv9vtxi/AACanWyny4bsMQ_3phrE6ggna?dl=1");
        }
    }
}
