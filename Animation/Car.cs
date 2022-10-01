using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Car : Object
    {
        public Car(string name, int scaleX, int scaleY, int x, int y)
           : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            //Каркас
            source.Add(new PointF(0.3f, 0.1f));
            source.Add(new PointF(0.1f, 0.1f));
            source.Add(new PointF(0, 0.2f));
            source.Add(new PointF(0, 0.3f));
            source.Add(new PointF(0.1f, 0.4f));
            source.Add(new PointF(0.2f, 0.4f));
            source.Add(new PointF(0.4f, 0.6f));
            source.Add(new PointF(0.4f, 0.6f));
            source.Add(new PointF(0.9f, 0.6f));
            source.Add(new PointF(1.1f, 0.4f));
            source.Add(new PointF(1.5f, 0.4f));
            source.Add(new PointF(1.6f, 0.3f));
            source.Add(new PointF(1.6f, 0.2f));
            source.Add(new PointF(1.5f, 0.1f));

            //левая фара
            source.Add(new PointF(0.1f, 0.3f));
            source.Add(new PointF(0, 0.3f));
            source.Add(new PointF(0.1f, 0.2f));


            //правая фара
            source.Add(new PointF(1.5f, 0.3f));
            source.Add(new PointF(1.6f, 0.3f));
            source.Add(new PointF(1.5f, 0.2f));

            //капот
            source.Add(new PointF(1.6f, 0.3f));
            source.Add(new PointF(1.5f, 0.4f));
            source.Add(new PointF(1.1f, 0.4f));
            source.Add(new PointF(1.2f, 0.3f));

            //лобовое стекло
            source.Add(new PointF(1.18f, 0.3f));
            source.Add(new PointF(1, 0.3f));
            source.Add(new PointF(0.8f, 0.4f));
            source.Add(new PointF(0.8f, 0.48f));
            source.Add(new PointF(0.9f, 0.58f));
            source.Add(new PointF(1.1f, 0.38f));

            //дверь
            source.Add(new PointF(1.1f, 0.15f));
            source.Add(new PointF(0.8f, 0.15f));
            source.Add(new PointF(0.7f, 0.2f));
            source.Add(new PointF(0.7f, 0.48f));
            source.Add(new PointF(0.92f, 0.48f));
            source.Add(new PointF(1.1f, 0.3f));

            //стекло на двери
            source.Add(new PointF(1.05f, 0.3f));
            source.Add(new PointF(0.75f, 0.3f));
            source.Add(new PointF(0.75f, 0.4f));
            source.Add(new PointF(0.8f, 0.45f));
            source.Add(new PointF(0.9f, 0.45f));

            //крыша
            source.Add(new PointF(1, 0.5f));
            source.Add(new PointF(0.5f, 0.5f));
            source.Add(new PointF(0.3f, 0.3f));

            //колеса
            source.Add(new PointF(0.33f, 0.16f));
            source.Add(new PointF(0.363f, 0.125f));

            source.Add(new PointF(1.2f, 0.16f));
            source.Add(new PointF(1.233f, 0.125f));

            //номер
            source.Add(new PointF(1.3f, 0.3f));


            xc = 0.5;
            yc = 0.5;

        }
        protected override void DrawObject(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);

            //Каркас
            SolidBrush CarkasColor = new SolidBrush(Color.FromArgb(34, 57, 115));
            GraphicsPath Carkas = new GraphicsPath();
            Carkas.AddLine(transformed[0], transformed[1]);
            Carkas.AddLine(transformed[2], transformed[3]);
            Carkas.AddLine(transformed[4], transformed[5]);
            Carkas.AddLine(transformed[6], transformed[7]);
            Carkas.AddLine(transformed[8], transformed[9]);
            Carkas.AddLine(transformed[10], transformed[11]);
            Carkas.AddLine(transformed[12], transformed[13]);
            Carkas.CloseFigure();
            g.FillPath(CarkasColor, Carkas);
            g.DrawPath(pen, Carkas);

            //фары
            SolidBrush LeftFaraColor = new SolidBrush(Color.FromArgb(156, 62, 62));
            GraphicsPath LeftFara = new GraphicsPath();
            LeftFara.AddLine(transformed[14], transformed[15]);
            LeftFara.AddLine(transformed[16], transformed[14]);
            LeftFara.CloseFigure();
            g.FillPath(LeftFaraColor, LeftFara);
            g.DrawPath(pen, LeftFara);

            SolidBrush RightFaraColor = new SolidBrush(Color.FromArgb(156, 62, 62));
            GraphicsPath RightFara = new GraphicsPath();
            RightFara.AddLine(transformed[17], transformed[18]);
            RightFara.AddLine(transformed[19], transformed[17]);
            RightFara.CloseFigure();
            g.FillPath(RightFaraColor, RightFara);
            g.DrawPath(pen, RightFara);

            //капот
            SolidBrush KapotColor = new SolidBrush(Color.FromArgb(34, 57, 115));
            GraphicsPath Kapot = new GraphicsPath();
            Kapot.AddLine(transformed[20], transformed[21]);
            Kapot.AddLine(transformed[22], transformed[23]);
            Kapot.CloseFigure();
            g.FillPath(KapotColor, Kapot);
            g.DrawPath(pen, Kapot);


            //дверь
            SolidBrush DoorColor = new SolidBrush(Color.FromArgb(34, 57, 115));
            GraphicsPath Door = new GraphicsPath();
            Door.AddLine(transformed[30], transformed[31]);
            Door.AddLine(transformed[32], transformed[33]);
            Door.AddLine(transformed[34], transformed[35]);
            Door.CloseFigure();
            g.FillPath(DoorColor, Door);
            g.DrawPath(pen, Door);

            //стекло на двери
            SolidBrush GlassDoorColor = new SolidBrush(Color.FromArgb(25, 49, 56));
            GraphicsPath GlassDoor = new GraphicsPath();
            GlassDoor.AddLine(transformed[36], transformed[37]);
            GlassDoor.AddLine(transformed[38], transformed[39]);
            GlassDoor.AddLine(transformed[40], transformed[36]);
            GlassDoor.CloseFigure();
            g.FillPath(GlassDoorColor, GlassDoor);
            g.DrawPath(pen, GlassDoor);

            //крыша
            GraphicsPath Krisha = new GraphicsPath();
            Krisha.AddLine(transformed[41], transformed[42]);
            Krisha.AddLine(transformed[42], transformed[7]);
            Krisha.AddLine(transformed[42], transformed[43]);
            Krisha.AddLine(transformed[43], transformed[5]);
            Krisha.AddLine(transformed[43], transformed[3]);
            g.DrawPath(pen, Krisha);

            //колеса
            Pen pen0 = new Pen(Color.Black, 3);
            SolidBrush wheelColor = new SolidBrush(Color.FromArgb(0, 0, 0));
            RectangleF wheel = new RectangleF(transformed[44].X, transformed[44].Y, 50, 50);
            g.FillEllipse(wheelColor, wheel);

            SolidBrush wheelColor1 = new SolidBrush(Color.FromArgb(112, 112, 102));
            RectangleF wheel1 = new RectangleF(transformed[45].X, transformed[45].Y, 30, 30);
            g.FillEllipse(wheelColor1, wheel1);

            SolidBrush wheel2Color = new SolidBrush(Color.FromArgb(0, 0, 0));
            RectangleF wheel2 = new RectangleF(transformed[46].X, transformed[46].Y, 50, 50);
            g.FillEllipse(wheel2Color, wheel2);

            SolidBrush wheelColor3 = new SolidBrush(Color.FromArgb(112, 112, 102));
            RectangleF wheel3 = new RectangleF(transformed[47].X, transformed[47].Y, 30, 30);
            g.FillEllipse(wheelColor3, wheel3);

            //номер
            Font NomberFont = new Font("Times New Roman", 25);
            g.DrawString("69", NomberFont, Brushes.Black, transformed[48]);




        }
    }
}
