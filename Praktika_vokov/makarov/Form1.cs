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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {

            int selected = ActionComboBox.SelectedIndex;

            switch (selected)
            {
                case 0: // Показать сообщение
                    {
                        //MessageBox.Show("Hello, World!");
                        string text = MessegeTextBox.Text;
                        MessageBox.Show(text, "Сообщение");
                    }
                    break;
                case 1: //Записать сообщение в поле
                    {
                        if (RusCheckBox1.Checked)
                            MessegeTextBox.Text = "Привет, Мир!";
                        else
                            MessegeTextBox.Text = "Hello, World!";                    }
                    break;
                case 2: //Добавить сообщение в список
                    {
                        string text = MessegeTextBox.Text;
                        if (!string.IsNullOrEmpty(text))
                            MessageListBox.Items.Add(text);

                    }
                    break;
                case 3: //Удалить выбранное сообщение
                    {
                        //Номер выделенного сообщения
                        int selectrdItem = MessageListBox.SelectedIndex;
                        //Запрос удаления
                        DialogResult res = MessageBox.Show("Желание удалить сообщение" + "?", "Удаление сообщения", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                            MessageListBox.Items.RemoveAt(selectrdItem);                       
                    }
                    break;
                case 4: //Отчисть список
                    {
                        //Запрос отчисть список
                        DialogResult res = MessageBox.Show("Желание отчистить список сообщений" + "?", "Отчистка списка сообщений", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                            MessageListBox.Items.Clear();
                    }
                    break;
                case 5: //Записать все сообщения в текстовом поле
                    {
                        StringBuilder text = new StringBuilder();
                        for (int i = 0; i < MessageListBox.Items.Count; i++)
                        {
                            text.AppendLine(MessageListBox.Items[i].ToString());
                        }
                        //Записать текст в текстовое поле
                        TextRichTextBox.Text = text.ToString();

                    }
                    break;
                case 6: //Показать изображение
                    {
                        //Диалог выбора файла
                        OpenFileDialog dlg = new OpenFileDialog();
                        //Настрока фильтров файлов
                        dlg.Filter = "Файлы PNG|*.png|Файлы JPEG|*.jpg";
                        dlg.FilterIndex = 1;
                        // Показать диалог
                        if(dlg.ShowDialog()== DialogResult.OK)
                        {
                            //Задать имя файла изображения
                            PictureBox.ImageLocation = dlg.FileName;
                        }
                    }
                    break;
            }
        }

        
    }
}
