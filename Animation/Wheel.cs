using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Wheel : Object
    {
        public Wheel(string name, int scaleX, int scaleY, int x, int y)
          : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            source.Add(new PointF(0, 0.5f));
            source.Add(new PointF(1, 0.5f));

            source.Add(new PointF(0.5f, 0));
            source.Add(new PointF(0.5f, 1));

            source.Add(new PointF(0, 1));
            source.Add(new PointF(1, 0));

            source.Add(new PointF(0, 0));
            source.Add(new PointF(1, 1));

            xc = 0.5;
            yc = 0.5;


        }

        protected override void DrawObject(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath a1 = new GraphicsPath();
            a1.AddLine(transformed[0], transformed[1]);
            g.DrawPath(pen, a1);

            GraphicsPath a2 = new GraphicsPath();
            a2.AddLine(transformed[2], transformed[3]);
            g.DrawPath(pen, a2);

            GraphicsPath a3 = new GraphicsPath();
            a3.AddLine(transformed[4], transformed[5]);
            g.DrawPath(pen, a3);

            GraphicsPath a4 = new GraphicsPath();
            a4.AddLine(transformed[6], transformed[7]);
            g.DrawPath(pen, a4);

        }
    }
}
