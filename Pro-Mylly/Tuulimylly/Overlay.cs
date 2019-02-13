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
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;
        }
    }
}
