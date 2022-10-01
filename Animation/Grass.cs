using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Grass : Object
    {
        public Grass(string name, int scaleX, int scaleY, int x, int y)
          : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            source.Add(new PointF(0.1f, 0));
            source.Add(new PointF(0.05f, 0.05f));
            source.Add(new PointF(0, 0.1f));
            source.Add(new PointF(0.05f, 0.2f));
            source.Add(new PointF(0.1f, 0.22f));
            source.Add(new PointF(0.2f, 0.2f));
            source.Add(new PointF(0.25f, 0.25f));
            source.Add(new PointF(0.35f, 0.3f));
            source.Add(new PointF(0.45f, 0.25f));
            source.Add(new PointF(0.5f, 0.2f));
            source.Add(new PointF(0.6f, 0.22f));
            source.Add(new PointF(0.65f, 0.2f));
            source.Add(new PointF(0.7f, 0.1f));
            source.Add(new PointF(0.65f, 0.05f));
            source.Add(new PointF(6, 0));

            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект
            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath Grass = new GraphicsPath();
            SolidBrush GrassColor = new SolidBrush(Color.FromArgb(15, 171, 59));
            PointF[] g1 =
            {
                transformed[1],
                transformed[2],
                transformed[3],
                transformed[4],
                transformed[5],
                transformed[6],
                transformed[7],
                transformed[8],
                transformed[9],
                transformed[10],
                transformed[11],
                transformed[12],
                transformed[13],
            };
            Grass.AddCurve(g1);
            Grass.CloseFigure();
            g.FillPath(GrassColor, Grass);
            g.DrawPath(pen, Grass);

        }

    }
    
}
