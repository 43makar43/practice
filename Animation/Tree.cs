using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Tree : Object
    {
        public Tree(string name, int scaleX, int scaleY, int x, int y)
            : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            //Ствол
            source.Add(new PointF(0.2f, 0));
            source.Add(new PointF(0.2f, 0.2f));
            source.Add(new PointF(0.4f, 0.2f));
            source.Add(new PointF(0.4f, 0));

            //листва
            source.Add(new PointF(0.2f, 0.2f));
            source.Add(new PointF(0, 0.2f));
            source.Add(new PointF(0.1f, 0.3f));
            source.Add(new PointF(0, 0.3f));
            source.Add(new PointF(0.1f, 0.4f));
            source.Add(new PointF(0, 0.4f));
            source.Add(new PointF(0.1f, 0.5f));
            source.Add(new PointF(0, 0.5f));
            source.Add(new PointF(0.1f, 0.6f));
            source.Add(new PointF(0.05f, 0.6f));
            source.Add(new PointF(0.3f, 0.8f));
            source.Add(new PointF(0.55f, 0.6f));
            source.Add(new PointF(0.5f, 0.6f));
            source.Add(new PointF(0.6f, 0.5f));
            source.Add(new PointF(0.5f, 0.5f));
            source.Add(new PointF(0.6f, 0.4f));
            source.Add(new PointF(0.5f, 0.4f));
            source.Add(new PointF(0.6f, 0.3f));
            source.Add(new PointF(0.5f, 0.3f));
            source.Add(new PointF(0.6f, 0.2f));
            source.Add(new PointF(0.4f, 0.2f));
            xc = 0.5;
            yc = 0.5;

        }

        protected override void DrawObject(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);

            // Нарисовать объект
            SolidBrush brevnoColor = new SolidBrush(Color.Brown);
            GraphicsPath brevno = new GraphicsPath();
            brevno.AddLine(transformed[0], transformed[1]);
            brevno.AddLine(transformed[2], transformed[3]);
            brevno.CloseFigure();
            g.FillPath(brevnoColor, brevno);
            g.DrawPath(pen, brevno);
            
            SolidBrush listvaColor = new SolidBrush(Color.FromArgb(28, 97, 72));
            GraphicsPath listva = new GraphicsPath();
            listva.AddLine(transformed[4], transformed[5]);
            listva.AddLine(transformed[6], transformed[7]);
            listva.AddLine(transformed[8], transformed[9]);
            listva.AddLine(transformed[10], transformed[11]);
            listva.AddLine(transformed[12], transformed[13]);
            listva.AddLine(transformed[14], transformed[15]);
            listva.AddLine(transformed[16], transformed[17]);
            listva.AddLine(transformed[18], transformed[19]);
            listva.AddLine(transformed[20], transformed[21]);
            listva.AddLine(transformed[22], transformed[23]);
            listva.CloseFigure();
            g.FillPath(listvaColor, listva);
            g.DrawPath(pen, listva);

        }
    }
}
