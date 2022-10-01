using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class House : Object
    {
        public House(string name, int scaleX, int scaleY, int x, int y)
            : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            //Передняя стена
            source.Add(new PointF(0.4f, 0));
            source.Add(new PointF(0.4f, 0.55f));
            source.Add(new PointF(1, 0.55f));
            source.Add(new PointF(1, 0));

            //боковая стена
            source.Add(new PointF(0.4f, 0));
            source.Add(new PointF(0, 0.2f));
            source.Add(new PointF(0, 0.55f));
            source.Add(new PointF(0.4f, 0.55f));

            //передняя крыша
            source.Add(new PointF(0.39f, 0.55f));
            source.Add(new PointF(0.7f, 1));
            source.Add(new PointF(1.05f, 0.55f));

            //полосы передней крыши
            source.Add(new PointF(0.5f, 0.55f));
            source.Add(new PointF(0.5f, 0.7f));

            source.Add(new PointF(0.6f, 0.55f));
            source.Add(new PointF(0.6f, 0.84f));

            source.Add(new PointF(0.699999f, 0.55f));
            source.Add(new PointF(0.699999f, 0.99f));

            source.Add(new PointF(0.82f, 0.55f));
            source.Add(new PointF(0.82f, 0.84f));

            source.Add(new PointF(0.93f, 0.55f));
            source.Add(new PointF(0.93f, 0.7f));

            //боковая крыша
            source.Add(new PointF(0.39f, 0.55f));
            source.Add(new PointF(-0.1f, 0.55f));
            source.Add(new PointF(0.2f, 1));
            source.Add(new PointF(0.7f, 1));

            //полосы боковой крыши
            source.Add(new PointF(0.03f, 0.55f));
            source.Add(new PointF(0.3f, 1));

            source.Add(new PointF(0.13f, 0.55f));
            source.Add(new PointF(0.4f, 1));

            source.Add(new PointF(0.23f, 0.55f));
            source.Add(new PointF(0.5f, 1));

            source.Add(new PointF(0.33f, 0.55f));
            source.Add(new PointF(0.6f, 1));

            //переднее стекло
            source.Add(new PointF(0.5f, 0.4f));
            source.Add(new PointF(0.5f, 0.5f));
            source.Add(new PointF(0.9f, 0.5f));
            source.Add(new PointF(0.9f, 0.4f));

            //дверь
            source.Add(new PointF(0.6f, 0));
            source.Add(new PointF(0.6f, 0.3f));
            source.Add(new PointF(0.8f, 0.3f));
            source.Add(new PointF(0.8f, 0));

            //окно на крыше
            source.Add(new PointF(0.6f, 0.7f));
            source.Add(new PointF(0.7f, 0.8f));
            source.Add(new PointF(0.8f, 0.7f));

            //боковое окно
            source.Add(new PointF(0.3f, 0.25f));
            source.Add(new PointF(0.15f, 0.3f));
            source.Add(new PointF(0.15f, 0.5f));
            source.Add(new PointF(0.3f, 0.45f));

            xc = 0.5;
            yc = 0.5;
        }
        protected override void DrawObject(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(74, 62, 2), 2);
            Pen pen0 = new Pen(Color.Black, 2);

            

            //Передняя стена
            SolidBrush stenaColor = new SolidBrush(Color.FromArgb(66, 55, 1));
            GraphicsPath stena = new GraphicsPath();
            stena.AddLine(transformed[0], transformed[1]);
            stena.AddLine(transformed[2], transformed[3]);
            stena.CloseFigure();
            g.FillPath(stenaColor, stena);
            g.DrawPath(pen0, stena);
            

            //боковая стена
            SolidBrush sideStenaColor = new SolidBrush(Color.FromArgb(66, 55, 1));
            GraphicsPath sideStena = new GraphicsPath();
            sideStena.AddLine(transformed[4], transformed[5]);
            sideStena.AddLine(transformed[6], transformed[7]);
            sideStena.CloseFigure();
            g.FillPath(sideStenaColor, sideStena);
            g.DrawPath(pen0, sideStena);
            

            //передняя крыша
            SolidBrush krishaColor = new SolidBrush(Color.Gray);
            GraphicsPath krisha = new GraphicsPath();
            krisha.AddLine(transformed[8], transformed[9]);
            krisha.AddLine(transformed[10], transformed[8]);
            krisha.CloseFigure();
            g.FillPath(krishaColor, krisha);
            g.DrawPath(pen0, krisha);
            

            //полосы передней крыши

            GraphicsPath lineKrisha = new GraphicsPath();
            lineKrisha.AddLine(transformed[11], transformed[12]);
            g.DrawPath(pen, lineKrisha);

            GraphicsPath lineKrisha0 = new GraphicsPath();
            lineKrisha0.AddLine(transformed[13], transformed[14]);
            g.DrawPath(pen, lineKrisha0);

            GraphicsPath lineKrisha1 = new GraphicsPath();
            lineKrisha1.AddLine(transformed[15], transformed[16]);
            g.DrawPath(pen, lineKrisha1);

            GraphicsPath lineKrisha2 = new GraphicsPath();
            lineKrisha2.AddLine(transformed[17], transformed[18]);
            g.DrawPath(pen, lineKrisha2);

            GraphicsPath lineKrisha3 = new GraphicsPath();
            lineKrisha3.AddLine(transformed[19], transformed[20]);
            g.DrawPath(pen, lineKrisha3);

            //боковая крыша
            SolidBrush sideKrishaColor = new SolidBrush(Color.Gray);
            GraphicsPath sideKrisha = new GraphicsPath();
            sideKrisha.AddLine(transformed[21], transformed[22]);
            sideKrisha.AddLine(transformed[23], transformed[24]);
            sideKrisha.CloseFigure();
            g.FillPath(sideKrishaColor, sideKrisha);
            g.DrawPath(pen0, sideKrisha);

            //полосы боковой крыши
            GraphicsPath lineSideKrisha = new GraphicsPath();
            lineSideKrisha.AddLine(transformed[25], transformed[26]);
            g.DrawPath(pen, lineSideKrisha);

            GraphicsPath lineSideKrisha0 = new GraphicsPath();
            lineSideKrisha0.AddLine(transformed[27], transformed[28]);
            g.DrawPath(pen, lineSideKrisha0);

            GraphicsPath lineSideKrisha1 = new GraphicsPath();
            lineSideKrisha1.AddLine(transformed[29], transformed[30]);
            g.DrawPath(pen, lineSideKrisha1);

            GraphicsPath lineSideKrisha2 = new GraphicsPath();
            lineSideKrisha2.AddLine(transformed[31], transformed[32]);
            g.DrawPath(pen, lineSideKrisha2);

            //переднее стекло
            SolidBrush GlassColor = new SolidBrush(Color.FromArgb(153, 151, 90));
            GraphicsPath Glass = new GraphicsPath();
            Glass.AddLine(transformed[33], transformed[34]);
            Glass.AddLine(transformed[35], transformed[36]);
            Glass.CloseFigure();
            g.FillPath(GlassColor, Glass);
            g.DrawPath(pen0, Glass);

            //дверь
            SolidBrush DoorColor = new SolidBrush(Color.FromArgb(13, 17, 28));
            GraphicsPath Door = new GraphicsPath();
            Door.AddLine(transformed[37], transformed[38]);
            Door.AddLine(transformed[39], transformed[40]);
            Door.CloseFigure();
            g.FillPath(DoorColor, Door);
            g.DrawPath(pen0, Door);

            //окно на крыше
            SolidBrush GlassKrishaColor = new SolidBrush(Color.FromArgb(153, 151, 90));
            GraphicsPath GlassKrisha = new GraphicsPath();
            GlassKrisha.AddLine(transformed[41], transformed[42]);
            GlassKrisha.AddLine(transformed[43], transformed[41]);
            GlassKrisha.CloseFigure();
            g.FillPath(GlassKrishaColor, GlassKrisha);
            g.DrawPath(pen0, GlassKrisha);

            //боковое окно
            SolidBrush SideGlassColor = new SolidBrush(Color.FromArgb(153, 151, 90));
            GraphicsPath SideGlass = new GraphicsPath();
            SideGlass.AddLine(transformed[44], transformed[45]);
            SideGlass.AddLine(transformed[46], transformed[47]);
            SideGlass.CloseFigure();
            g.FillPath(SideGlassColor, SideGlass);
            g.DrawPath(pen0, SideGlass);


        }
    }
}
