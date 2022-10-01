using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            anim.Timer.Enabled = true;
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            anim.Timer.Enabled = false;
        }
    }
}
