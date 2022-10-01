using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Tablet : Object
    {
        public Tablet(string name, int scaleX, int scaleY, int x, int y)
           : base(name, scaleX, scaleY, x, y)
        {
            //табличка
            source.Add(new PointF(0.4f, 0.15f));
            source.Add(new PointF(0, 0.15f));
            source.Add(new PointF(0, 0.35f));
            source.Add(new PointF(0.4f, 0.35f));

            //ножка для таблички
            source.Add(new PointF(0.2f, 0));
            source.Add(new PointF(0.2f, 0.2f));

            source.Add(new PointF(0.1f, 0.3f));

            

            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);
            Pen pen0 = new Pen(Color.Black, 2);

            GraphicsPath Leg = new GraphicsPath();
            Leg.AddLine(transformed[4], transformed[5]);
            g.DrawPath(pen, Leg);

            SolidBrush TabletColor = new SolidBrush(Color.FromArgb(75, 84, 87));
            GraphicsPath Tablet = new GraphicsPath();
            Tablet.AddLine(transformed[0], transformed[1]);
            Tablet.AddLine(transformed[2], transformed[3]);
            Tablet.CloseFigure();
            g.FillPath(TabletColor, Tablet);
            g.DrawPath(pen0, Tablet);

            Font gridFont = new Font("Times New Roman", 14);
            g.DrawString("Вяжа", gridFont, Brushes.Black, transformed[6]);


        }
    }
}
