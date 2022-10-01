using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class TransportMapControl : UserControl
    {
        List<Vehicle> vehicles;
        Transformer tx, ty;
        MapItem mapItem;
        Font gridFont;

        public TransportMapControl()
        {
            InitializeComponent();
            // Двойная буферизация
            DoubleBuffered = true;
            // Список транспорт средств
            vehicles = null;
            // преобразование координат
            tx = new Transformer();
            ty = new Transformer();
            // элемент на карте
            mapItem = new MapItem();
            mapItem.Size = 70;

            gridFont = new Font("Times New Roman", 6);
        }

        public List<Vehicle> Vehicles
        {
            set { vehicles = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Заполнение фона
            e.Graphics.FillRectangle(Brushes.White, ClientRectangle);

            // Вывод карты
            DrawMap(e.Graphics, ClientRectangle);
        }

        protected void DrawMap(Graphics g, Rectangle bound)
        {
            if (vehicles!=null && vehicles.Count > 0)
            {
                //  Вывод транспорт средств
                int m = 10;
                RectangleF rect = new RectangleF(bound.X+m, bound.Y+m,
                    bound.Width-(m << 1),
                    bound.Height - (m << 1));

                DrawVehicles(g, bound, vehicles);
               


            }
            else
            {
                // Вывод текста
                string text = "Карта расположения транспортных средств";
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                RectangleF rect = new RectangleF(bound.X, bound.Y,
                    bound.Width, bound.Height);
                g.DrawString(text, Font, Brushes.Black, rect, format);
            }
            
        }

        protected void DrawVehicles(Graphics g, RectangleF bound,
            List<Vehicle> vehicles)
        {
            // поиск диапазонов изменений координат
            double minX, maxX, minY, maxY;
            FindMinMax(vehicles, out minX, out maxX,
                out minY, out maxY);

            double mX = (maxX - minX) + 0.1;
            double mY = (maxY - minY) + 0.1;

            // настройка преобразования

            tx.SetParametrs(minX - mX, maxX + mX,
                bound.Left, bound.Right);
            ty.SetParametrs(minY - mY, maxY + mY,
                bound.Top, bound.Bottom);

            float x, y;
            float d = 10;
            int index;
            for (int i = 0; i < vehicles.Count; i++)
            {
                // Преобразование координат

                x = (float)tx.Transform(vehicles[i].X);
                y = (float)ty.Transform(vehicles[i].Y);

                // изобрадение транспорт средства

                g.FillEllipse(Brushes.Red, x - 0.5f * d, y - 0.5f * d, d, d);
                index = GetPointIndex(x, y);
                // вывод элемента
                mapItem.Draw(g, vehicles[i], x, y, index);
            }

            // Изображение сетки
            DrawGrid(g, bound, minX, maxX, 10, true);
            DrawGrid(g, bound, minY-mY, maxY-mY, 10, false);



        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // Перерисовать окно
            Invalidate();
        }

        protected void FindMinMax(List<Vehicle> vehicles, out double minX, out double maxX,
            out double minY, out double maxY)
        {
            minX = 0;
            maxX = 1;
            minY = 0;
            maxY = 1;

            if (vehicles == null || vehicles.Count == 0)
                return;

            double x, y;
            for (int i = 0; i < vehicles.Count; i++)
            {
                x = vehicles[i].X;
                y = vehicles[i].Y;

                if (minX > x)
                    minX = x;
                if (maxX < x)
                    maxX = x;

                if (minY > y)
                    minY = y;
                if (maxY < y)
                    maxY = y;
            }

            if (Math.Abs(maxX - minX) < 1e-6)
                maxX += 1;

            if (Math.Abs(maxY - minY) < 1e-6)
                maxY += 1;
        }

        protected int GetPointIndex(float x, float y)
        {
            return 0;
        }

        protected void DrawGrid(Graphics g, RectangleF bound, double min, double max, int parts, bool vertical)
        {
            double v = min;
            double dv = (max - min) / parts;

            SizeF s1 = g.MeasureString(min.ToString(), gridFont);
            SizeF s2 = g.MeasureString(max.ToString(), gridFont);
            RectangleF textRect = new RectangleF();

            textRect.Width = Math.Max(s1.Width, s2.Width);
            textRect.Height = Math.Max(s1.Height, s2.Height);
            // формат вывода текста
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;


            // шаг по координате
            float dc = ((vertical) ? bound.Width:bound.Height) / parts;
            float c0 = (vertical) ? bound.Left : bound.Top;
            float c1 = (vertical) ? bound.Right -1: bound.Bottom -1;

            PointF p1 = PointF.Empty;
            PointF p2 = PointF.Empty;
            // первая линия
            if (vertical)
            {
                //вертикальная линия
                p1.X = c0;
                p1.Y = bound.Top;
                p2.X = p1.X;
                p2.Y = bound.Bottom;
                //
                textRect.X = p1.X - 0.5f * textRect.Width;
                textRect.Y = p1.Y - textRect.Height - 2;
            }
            else
            {
                //горизонтальные линии
                p1.X = bound.Left;
                p1.Y = c0;
                p2.X = bound.Right;
                p2.Y = p1.Y;
                //
                textRect.X = p1.X - textRect.Height - 2;
                textRect.Y = p1.Y - 0.5f * textRect.Width;
            }
            g.DrawLine(Pens.DarkGray, p1, p2);
            g.DrawString(v.ToString(), gridFont, Brushes.Black, textRect, format);
            // промежуточные линии

            for (int i = 0; i < parts; i++)
            {
                if (vertical)
                {
                    // вертикальные линии
                    p1.X = c0 + i * dc;
                    p2.X = p1.X;
                }
                else
                {
                    // горизонтальные линии
                    p1.Y = c0 + i * dc;
                    p2.Y = p1.Y;

                }
                g.DrawLine(Pens.DarkGray, p1, p2);


            }
            // последняя линия
            if (vertical)
            {
                p1.X = c1;
                p2.X = c1;
            }
            else
            {
                p1.Y = c1;
                p2.Y = c1;

            }
            g.DrawLine(Pens.DarkGray, p1, p2);

        }
    }
}
