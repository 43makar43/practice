using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Animation
{
    public class Object
    {
        protected List<PointF> source;
        protected List<PointF> transformed;

        protected double xc;
        protected double yc;

        protected string name;
        protected double x;
        protected double y;

        protected double angle;

        protected double scaleX;
        protected double scaleY;

        protected Matrix scaleMatrix;
        protected Matrix translationMatrix;
        protected Matrix rotationMatrix;

        protected Matrix resultMatrix;

        public Object(string name,int scaleX,int scaleY, int x, int y)
        {
            // исходные точки из единичного квадрата
            source = new List<PointF>();
            // преобразованные точки, по которым рисуется объект
            transformed = new List<PointF>();

            // координаты центра
            xc = 0;
            yc = 0;

            // угол поворота
            angle = 0;

            // матрицы преобразования
            scaleMatrix = new Matrix();
            translationMatrix = new Matrix();
            rotationMatrix = new Matrix();

            // результирующая матрица преобразования
            resultMatrix = new Matrix();

            this.name = name;
            this.x = x;
            this.y = y;
            this.scaleX = scaleX;
            this.scaleY = scaleY;
        }

        protected void CreateTransformedPoints()
        {
            // создание списка преобразованных точек
            transformed.Clear();
            for (int i = 0; i < source.Count; i++)
                transformed.Add(new PointF());
        }

        public double X
        {
            set { x = value; }
            get { return x; }
        }

        public double Y
        {
            set { y = value; }
            get { return y; }
        }

        public double Angle
        {
            set { angle = value; }
            get { return angle; }
        }

        public double ScaleX
        {
            set { scaleX = value; }
            get { return scaleX; }
        }

        public double ScaleY
        {
            set { scaleY = value; }
            get { return scaleY; }
        }

        public void Draw(Graphics g, Matrix viewportMatrix)
        {
            // Выполнить преобразование
            Transform(viewportMatrix);

            // Нарисовать объект
            DrawObject(g);
        }

        protected virtual void Transform(Matrix viewportMatrix)
        {
            // Создать точки для преобразования
            if (transformed.Count != source.Count)
                CreateTransformedPoints();

            // Результирующая матрица преобразования
            resultMatrix.Identity();

            // Включить перенос объекта в центр
            translationMatrix.Translate(-xc, -yc);
            resultMatrix.AppendLeft(translationMatrix);

            // Включить масштабирование объекта
            scaleMatrix.Scale(scaleX, scaleY);
            resultMatrix.AppendLeft(scaleMatrix);

            // Включить поверот объекта
            rotationMatrix.Rotation(angle * Math.PI / 180);
            resultMatrix.AppendLeft(rotationMatrix);

            // Включить перенос объекта в точку x,y
            translationMatrix.Translate(x, y);
            resultMatrix.AppendLeft(translationMatrix);

            // Выполнить преобразование в экран
            resultMatrix.AppendLeft(viewportMatrix);

            // Выполнить полное пребразование исходных точек в экран
            for (int i = 0; i < source.Count; i++)
                transformed[i] = resultMatrix.Transform(source[i]);
        }

        protected virtual void DrawObject(Graphics g)
        {
            // виртуальная функция - переопределяется в наследниках
        }
    }
}
