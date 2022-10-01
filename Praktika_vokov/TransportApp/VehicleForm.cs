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
    public partial class VehicleForm : Form
    {
        List<string> characteristicName;
        List<int> valueTypes;

        bool editMode;
        double maxVolume;
        double volume;
        double x;
        double y;

        int iValue;
        double fValue;
        public VehicleForm()
        {
            InitializeComponent();

            //Имена характеристик
            characteristicName = new List<string>(3);
            characteristicName.Add("Количество двигателей");
            characteristicName.Add("Водоизмещение");
            characteristicName.Add("Количество колёс");

            //Тип значений
            valueTypes = new List<int>();
            valueTypes.Add(0);
            valueTypes.Add(1);
            valueTypes.Add(0);


            //Режим добавления
            editMode = false;

            MaxVolume = 1;
            //Характеристика
            IntegerValue = 1;

            
        }

        public string VehicleName
        {
            set { NameTextBox.Text = value; }
            get { return NameTextBox.Text; }
        }

        public VehicleTypes VehicleType
        {
            set
            {
                switch (value)
                {
                    case VehicleTypes.AirVehicle:
                        TypeComboBox.SelectedIndex = 0;
                        break;
                    case VehicleTypes.WaterVehicle:
                        TypeComboBox.SelectedIndex = 1;
                        break;
                    case VehicleTypes.LandVehicle:
                        TypeComboBox.SelectedIndex = 2;
                        break;
                    default:
                        TypeComboBox.SelectedIndex = -1;
                        break;
                }
                SatCharacteristicName(TypeComboBox.SelectedIndex);
            }
            get
            {
                VehicleTypes type = VehicleTypes.Unknown;
                switch(TypeComboBox.SelectedIndex)
                {
                    case 0: type = VehicleTypes.AirVehicle; break;
                    case 1: type = VehicleTypes.WaterVehicle; break;
                    case 2: type = VehicleTypes.LandVehicle; break;
                }
                return type;
            }
        }

        public bool EditMode
        {
            set
            {
                editMode = value;

                //Доступность полей
                TypeComboBox.Enabled = !editMode;
                MaxVolumeTextBox.Enabled = !editMode;
                CharacteristicTextBox.Enabled = !editMode;

            }
            get
            {
                return editMode;
            }
        }

        public double MaxVolume
        {
            set
            {
                maxVolume = value;
                MaxVolumeTextBox.Text = value.ToString();
            }
            get
            {
                return maxVolume;
            }
        }

        public double Volume
        {
            set
            {
                volume = value;
                VolumeTextBox.Text = value.ToString();
            }
            get
            {
                return volume;
            }
        }

        public int IntegerValue
        {
            set
            {
                iValue = value;
                CharacteristicTextBox.Text = value.ToString();

            }
            get
            {
                return iValue;
            }
        }

        public double DoubleValue
        {
            set
            {
                fValue = value;
                CharacteristicTextBox.Text = value.ToString();

            }
            get
            {
                return fValue;
            }
        }

        protected bool CheckData()
        {
            //TODO проверка корректности введенных данных
            //Название транспортного средства
            if (TypeComboBox.SelectedIndex<0)
            {
                MessageBox.Show("Не выбран тип транспортного средства!", "");
                    return false;
            }
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Некорректное название транспортного средства!", "");
                    return false;
            }
            
            //макс объем
            if (!double.TryParse(MaxVolumeTextBox.Text, out maxVolume))
            {
                MessageBox.Show("Некорректный объем!", "");
                return false;
            }
            if (!double.TryParse(VolumeTextBox.Text, out volume))
            {
                MessageBox.Show("Неккоректное значение объема", "");
                return false;
            }
            //Характеристика
            if (!double.TryParse(MaxVolumeTextBox.Text, out maxVolume))
            {
                MessageBox.Show("Некорректный объем!", "");
                return false;
            }

            bool b = false;
            int iType = valueTypes[TypeComboBox.SelectedIndex];
            switch (iType)
            {
                case 0: //целое число
                    b = int.TryParse(CharacteristicTextBox.Text, out iValue);
                    break;
                case 1: //вещественное чило
                    b = double.TryParse(CharacteristicTextBox.Text, out fValue);
                    break;
            }
            if (!b)
            {
                MessageBox.Show("Некорректное значение в поле " + characteristicLable.Text);
                return false;
            }
            return true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void VehicleType_Changed(object sender, EventArgs e)
        {
            SatCharacteristicName(TypeComboBox.SelectedIndex);
        }

        protected void SatCharacteristicName(int type)
        {
            if (type<0)
            {
                characteristicLable.Text = "Характеристика";
            }
            //установить название характеристики
            if (type >= 0 && type<3)
            {
                characteristicLable.Text = characteristicName[type];
            }
            
        }
    }
}
