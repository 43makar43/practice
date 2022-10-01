using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Animation
{
    class Field : Object 
    {
        public Field(string name, int scaleX, int scaleY, int x, int y)
           : base(name, scaleX, scaleY, x, y)
        {
            source.Clear();

            source.Add(new PointF(1, 0.4f));
            source.Add(new PointF(0.5f, 0.7f));
            source.Add(new PointF(0, 0.4f));



            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект
            Pen pen = new Pen(Color.Black, 1);

            GraphicsPath field1 = new GraphicsPath();
            SolidBrush fieldColor = new SolidBrush(Color.FromArgb(214, 209, 66));
            PointF[] f1  = 
            {
                transformed[0], transformed[1], transformed[2],
            };
            field1.AddCurve(f1);
            g.FillPath(fieldColor, field1);           
            g.DrawPath(pen, field1);

            

        }
    }
}
