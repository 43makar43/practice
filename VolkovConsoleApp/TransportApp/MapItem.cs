using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace TransportApp
{
    public class MapItem
    {
        Dictionary<VehicleTypes, Image> images;
        int size;
        RectangleF imageRect;
        RectangleF textRect;
        StringFormat format;
        Font font;

        public MapItem()
        {
            //словарь изображений
            images = new Dictionary<VehicleTypes, Image>();
            images.Add(VehicleTypes.AirVehicle, Properties.Resources.самолёт);
            images.Add(VehicleTypes.WaterVehicle, Properties.Resources.корабль);
            images.Add(VehicleTypes.LandVehicle, Properties.Resources.машина);
            images.Add(VehicleTypes.Unknown, null);
            // размер
            Size = 70;
            // формат
            format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            // шрифт
            font = new Font("Tahoma", 8);

        }

        public int Size
        {
            set
            {
                if (value < 20)
                    size = 20;
                else
                    size = value;
                // определить параметры
                CalculateParametrs();
            }
            get { return size; }
        }

        protected void CalculateParametrs()
        {
            imageRect.Width = 0.5f * size;
            imageRect.Height = 0.5f * size;

            textRect.Width = size;
            textRect.Height = 0.3f * size;
        }

        protected void LocateElements(float x, float y, int index)
        {  
            switch (index)
            {
                case 0: // левый вверхний угол
                    imageRect.X = x + (size - imageRect.Width) * 0.5f;
                    imageRect.Y = y;

                    textRect.X = x;
                    textRect.Y = y + size - textRect.Height;
                    break;
            }
        }

        protected void DrawCenteredImage(Graphics g, Image image, RectangleF bound)
        {

            if (image == null)
                return;

            Rectangle rect = Rectangle.Empty; // прямоугольник в котором будет рисоваться;
            // соотношение сторон
            double a = (double)image.Width / image.Height;
            // изображение по горизонтали
            double width = (int)bound.Width;
            double height = width / a;
            double x = bound.X;
            double y = bound.Y + (bound.Height - height) * 0.5;

            if (height > bound.Height)
            {
                // изображение по вертикали
                height = bound.Height;
                width = a * height;
                y = bound.Y;
                x = bound.X + (bound.Width - width) * 0.5;
            }
            // поля прямоугольника
            rect.X = (int)x;
            rect.Y = (int)y;
            rect.Width = (int)width;
            rect.Height = (int)height;
            // вывод изображения
            g.DrawImage(image, rect, new Rectangle(0,0,image.Width,image.Height),
                GraphicsUnit.Pixel);
        }


        public void Draw(Graphics g, Vehicle v, float x, float y, int index)
        {
            if (v == null)
            {
                return;
            }
            // Опрделить положение элементов
            LocateElements(x, y, index);
            // вывод изображения
            DrawCenteredImage(g, images[v.GetVehicleType()], imageRect);
            // вывод текста
            g.DrawString(v.Name, font, Brushes.Black, textRect, format);
        }


    }
}
