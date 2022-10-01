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
    public partial class MainForm : Form
    {
        List<Vehicle> vehicles;
        string ResultRichTextBox;
        
        public MainForm()
        {
            InitializeComponent();
            vehicles = new List<Vehicle>();
            transportMapControl.Vehicles = vehicles;
            // Обновление строки состояния
            UpdateStatusBar();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                //Открыть файл
                if(Vehicle.ReadData(dlg.FileName, vehicles))
                {
                    //Заполнить список
                    FillListBox(vehicles, VehicleListBox);
                }
                
            }
        }

        protected void FillListBox(List<Vehicle>vehicles, ListBox listBox)
        {
            //Отчистка
            listBox.Items.Clear();
            //Добавить элемент
            foreach (Vehicle v in vehicles)
            {
                listBox.Items.Add(v);
            }
        }

        private void SafeMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Сохранить файл
                Vehicle.SaveData(dlg.FileName, vehicles);
            }
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddVehicleMenuItem_Click(object sender, EventArgs e)
        {
            //Добавление тс
            VehicleForm form = new VehicleForm();
            form.Text = "Добавление нового транспортного средства";
            if (form.ShowDialog()==DialogResult.OK)
            {
                Vehicle v = null;
                switch (form.VehicleType)
                {                  
                    case VehicleTypes.AirVehicle:
                        v = new AirVehicle(form.VehicleName, form.MaxVolume, form.IntegerValue);
                        v.Volume = form.Volume;
                        break;
                    case VehicleTypes.WaterVehicle:
                        v = new WaterVehicle(form.VehicleName, form.MaxVolume, form.DoubleValue);
                        v.Volume = form.Volume;
                        break;
                    case VehicleTypes.LandVehicle:
                        v = new LandVehicle(form.VehicleName, form.MaxVolume, form.IntegerValue);
                        v.Volume = form.Volume;
                        break;
                }

                //Добавить в список
                if (v!=null)
                {
                    vehicles.Add(v);
                    VehicleListBox.Items.Add(v);
                }
            }
        }

        private void EditVehicleMenuItem_Click(object sender, EventArgs e)
        {
            if (VehicleListBox.SelectedIndex >= 0)
            {
                
                VehicleForm form = new VehicleForm();
                form.EditMode = true;
                form.Text = "Изменение транспортного средства";

                Vehicle v = vehicles[VehicleListBox.SelectedIndex];
                form.VehicleName = v.Name;
                form.VehicleType = v.GetVehicleType();
                form.MaxVolume = v.MaxVolume;
                form.Volume = v.Volume;
                //характеристика
                switch (v.GetVehicleType())
                {
                    //преобразование вниз
                    case VehicleTypes.AirVehicle:
                        form.IntegerValue = ((AirVehicle)v).Engines;
                        break;
                    case VehicleTypes.WaterVehicle:
                        form.DoubleValue = ((WaterVehicle)v).Displacement;
                        break;
                    case VehicleTypes.LandVehicle:
                        form.IntegerValue = ((LandVehicle)v).Wheels;
                        break;
                   
                }


                if (form.ShowDialog() == DialogResult.OK)
                {
                    //Имя
                    v.Name = form.VehicleName;
                    v.Volume = form.Volume;
                    //Обновить списк
                    VehicleListBox.Items[VehicleListBox.SelectedIndex] = v;
                    Update();
                }
            }
            //Изменетие тс
            
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VehicleListBox.SelectedIndex >= 0)
            {
                Vehicle v = VehicleListBox.SelectedItem as Vehicle;
                if (v != null)
                {
                    string question = "Желаете удалить " + v.Name + " ?";
                    DialogResult res = MessageBox.Show(question, "Удаление транспортного средства", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        VehicleListBox.Items.Remove(v);
                        vehicles.Remove(v);
                    }

                }
            }
        }

        private void SortAZMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicles.Count>0)
            {
                //сортировать список
                vehicles.Sort(Vehicle.CompareAZ);
                //обновление списка
                FillListBox(vehicles, VehicleListBox);
            }
        }

        private void SortZAMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicles.Count > 0)
            {
                //сортировать список
                vehicles.Sort(Vehicle.CompareZA);
                //обновление списка
                FillListBox(vehicles, VehicleListBox);
            }
        }

        private void SelectionMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReportMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
