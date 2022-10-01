using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class SelectionMenuForm : Form
    {

            List<Vehicle> vehicles;
            string result;
            double min;
            double max;

            public SelectionMenuForm()
            {
                InitializeComponent();
            }

            

            private void resultButton_Click(object sender, EventArgs e)
            {
                result = string.Empty;
                if (CheckData())
                {
                    switch (Select_ComboBox.SelectedIndex)
                    {
                        case 0:
                            vehicles.Sort(Vehicle.MaxVolumeSort);
                            break;
                        case 1:
                            vehicles.Sort(Vehicle.VolumeSort);
                            break;
                    }

                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        if (vehicles[i].Volume <= double.Parse(Min_TextBox.Text) && vehicles[i].Volume >= double.Parse(Max_TextBox.Text))
                        {

                        }
                        else if (vehicles[i].MaxVolume <= double.Parse(Min_TextBox.Text) && vehicles[i].MaxVolume >= double.Parse(Max_TextBox.Text))
                        {

                        }
                        else { result += vehicles[i].ToString() + "\n"; }

                    }

                    ResultRichTextBox = result;
                }
                Close();
            }

            protected bool CheckData()
            {
                // максимальное значение
                if (Max_TextBox.Text == null)
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }

                if (!double.TryParse(Max_TextBox.Text, out max))
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }

                if (double.Parse(Max_TextBox.Text) < 0)
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }


                // Минимальное значение
                if (Min_TextBox.Text == null)
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }

                if (!double.TryParse(Min_TextBox.Text, out min))
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }

                if (double.Parse(Min_TextBox.Text) < 0)
                {
                    MessageBox.Show(
                        "Некорректное значение максимального значение!",
                        "");
                    return false;
                }

                return true;

            }

            public string ResultRichTextBox
            {
                set
                {
                    result = value;
                }
                get { return result; }
            }

            public List<Vehicle> ListVehicles
            {
                set
                {
                    vehicles = value;
                }
                get
                {
                    return vehicles;
                }
            }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
