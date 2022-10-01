using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volkovSamost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Character_ComboBox.SelectedIndex = 0;
            TypeObject_ComboBox.SelectedIndex = 0;


        }
        
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Visible = CheckBox.Checked;
        }

        private void Rascet_Button_Click_1(object sender, EventArgs e)
        {
            double radius = 0;
            double height = 0;
            double result;

            //проверка на пустую строку
            if (Radius_TextBox.Text != "" && Height_TextBox.Text != "")
            {
                //проверка на число
                if (double.TryParse(Radius_TextBox.Text, out result) && (double.TryParse(Height_TextBox.Text, out result)))
                {
                    //проверка на больше 0  
                    if (double.Parse(Radius_TextBox.Text) > 0 && double.Parse(Height_TextBox.Text) > 0)
                    {
                        {
                            radius = double.Parse(Radius_TextBox.Text);
                            height = double.Parse(Height_TextBox.Text);
                            int index = Character_ComboBox.SelectedIndex;
                            switch (index)
                            {

                                case 0:
                                    double s = 2 * Math.PI * radius * height;

                                    Result_TextBox.Text = s.ToString();
                                    break;

                                case 1:
                                    double v = Math.PI * radius * radius * height;
                                    Result_TextBox.Text = v.ToString();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Значения должны быть больше 0!");
                    }

                }
                else
                {
                       MessageBox.Show("В строках должны быть только числы!");
                }

            }
            else
            {
                MessageBox.Show("Строка пустая. Введите значение!");
            }
        }
    }
}
