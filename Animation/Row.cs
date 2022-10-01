using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Row : Object
    {
        public Row (string name, int scaleX, int scaleY, int x, int y)
            : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();
            source.Add(new PointF(0, 2.5f));
            source.Add(new PointF(20, 2.5f));
            source.Add(new PointF(0, 1));
            source.Add(new PointF(20, 1));


            float shift = 0;

            for (int i = 0; i < 40; i++)
            {
                source.Add(new PointF(0.2f + shift, 1.74f));
                source.Add(new PointF(0.7f + shift, 1.7f));
                shift += 1f;
            }
            xc = 0.5;
            yc = 0.5;
        }
        protected override void DrawObject(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);

            g.DrawLine(pen, transformed[2], transformed[3]);
            g.DrawLine(pen, transformed[0], transformed[1]);

            g.DrawLine(pen, transformed[4], transformed[5]);
            g.DrawLine(pen, transformed[6], transformed[7]);

            g.DrawLine(pen, transformed[8], transformed[9]);
            g.DrawLine(pen, transformed[10], transformed[11]);

            g.DrawLine(pen, transformed[12], transformed[13]);
            g.DrawLine(pen, transformed[14], transformed[15]);

            g.DrawLine(pen, transformed[16], transformed[17]);
            g.DrawLine(pen, transformed[18], transformed[19]);

            g.DrawLine(pen, transformed[20], transformed[21]);
            g.DrawLine(pen, transformed[22], transformed[23]);

            g.DrawLine(pen, transformed[24], transformed[25]);
            g.DrawLine(pen, transformed[26], transformed[27]);

            g.DrawLine(pen, transformed[28], transformed[29]);
            g.DrawLine(pen, transformed[30], transformed[31]);

            g.DrawLine(pen, transformed[32], transformed[33]);
            g.DrawLine(pen, transformed[34], transformed[35]);

            g.DrawLine(pen, transformed[36], transformed[37]);
            g.DrawLine(pen, transformed[38], transformed[39]);

            g.DrawLine(pen, transformed[40], transformed[41]);
            g.DrawLine(pen, transformed[42], transformed[43]);

            
        }
    }
}
