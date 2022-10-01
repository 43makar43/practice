using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makarov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ShowPanel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {


           
        }

        protected void ShowPanel()
        {
            panel1.Visible = showCheckBox.Checked;
        }

        private void ShowPanel_ChackedChanger(object sender, EventArgs e)
        {
            ShowPanel();
        }
    }
}
