using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Anim : UserControl
    {
        int size;
        int angle;
        int x;
        int y;

        List<Object> objects;

        int sceneSize;
        Matrix viewMatrix;

            Field flied0 = new Field("Поле", 700, 400, 1700, 300);
            Field flied1 = new Field("Поле", 700, 400, 1000, 300);
            Field flied2 = new Field("Поле", 700, 400, 1500, 300);
            Field flied3 = new Field("Поле", 700, 400, 700, 300);
            Field flied4 = new Field("Поле", 700, 400, 200, 300);
            Field flied5 = new Field("Поле", 700, 400, 500, 300);

            Grass grass0 = new Grass("Куст", 100, 125, 700, 275);
            Grass grass1 = new Grass("Куст", 150, 105, 300, 275);
            Grass grass2 = new Grass("Куст", 180, 205, 500, 210);
            Grass grass3 = new Grass("Куст", 100, 125, 100, 215);
            Grass grass4 = new Grass("Куст", 100, 125, 900, 255);
            Grass grass5 = new Grass("Куст", 100, 125, 1700, 275);
            Grass grass6 = new Grass("Куст", 150, 105, 1300, 275);
            Grass grass7 = new Grass("Куст", 180, 205, 1500, 210);
            Grass grass8 = new Grass("Куст", 100, 125, 1100, 215);
            Grass grass9 = new Grass("Куст", 100, 125, 1900, 255);

            Tree tree0 = new Tree("Дерево", 200, 200, 200, 250);
            Tree tree1 = new Tree("Дерево", 150, 150, 100, 300);
            Tree tree2 = new Tree("Дерево", 230, 230, 400, 250);
            Tree tree3 = new Tree("Дерево", 100, 100, 500, 300);
            Tree tree4 = new Tree("Дерево", 200, 200, 650, 250);
            Tree tree5 = new Tree("Дерево", 130, 130, 850, 280);
            Tree tree6 = new Tree("Дерево", 200, 200, 800, 220);
            Tree tree7 = new Tree("Дерево", 200, 200, 1000, 250);
            Tree tree8 = new Tree("Дерево", 150, 150, 1100, 300);
            Tree tree9 = new Tree("Дерево", 200, 200, 1200, 250);
            Tree tree10= new Tree("Дерево", 230, 230, 1400, 250);
            Tree tree11 = new Tree("Дерево", 100, 100, 1500, 300);
            Tree tree12 = new Tree("Дерево", 200, 200, 1650, 250);
            Tree tree13 = new Tree("Дерево", 130, 130, 1850, 280);

            House house0 = new House("Дом", 200, 200, 2150, 230);
            House house1 = new House("Дом", 200, 200, 1900, 250);
            House house2 = new House("Дом", 200, 200, 1650, 240);
            House house3 = new House("Дом", 200, 200, 1400, 260);
            House house4 = new House("Дом", 200, 200, 1150, 270);

            Tablet tablet = new Tablet("Табличка", 300, 300, 1150, 300);

            Row row = new Row("Дорога", 100, 50, 20, 10);

            Car car = new Car("Машина", 300, 300, 160, 200);

            Wheel wheel1 = new Wheel("Колесо", 33, 33, 134, 72);
            Wheel wheel2 = new Wheel("Колесо", 33, 33, 395, 72);

            Cloud o0 = new Cloud("Облако", 250, 250, 500, 555);
            Cloud o1 = new Cloud("Облако", 230, 230, 300, 515);
            Cloud o2 = new Cloud("Облако", 210, 210, 700, 565);
            Cloud o3 = new Cloud("Облако", 180, 180, 900, 505);
            Cloud o4 = new Cloud("Облако", 150, 150, 100, 525);
            Cloud o5 = new Cloud("Облако", 250, 250, 1500, 555);
            Cloud o6 = new Cloud("Облако", 230, 230, 1300, 515);
            Cloud o7 = new Cloud("Облако", 210, 210, 1700, 565);
            Cloud o8 = new Cloud("Облако", 180, 180, 1900, 505);
            Cloud o9 = new Cloud("Облако", 150, 150, 1100, 525);


        public Anim()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            // Двойная буферизация
            DoubleBuffered = true;

            // Объекты
            objects = new List<Object>();

            objects.Add(flied0); 
            objects.Add(flied1); 
            objects.Add(flied2); 
            objects.Add(flied3); 
            objects.Add(flied4); 
            objects.Add(flied5); 

            objects.Add(grass0);
            objects.Add(grass1);
            objects.Add(grass2);
            objects.Add(grass3);
            objects.Add(grass4);
            objects.Add(grass5);
            objects.Add(grass6);
            objects.Add(grass7);
            objects.Add(grass8);
            objects.Add(grass9);

            objects.Add(tree13);
            objects.Add(tree1);
            objects.Add(tree0);
            objects.Add(tree2);
            objects.Add(tree3);
            objects.Add(tree4);
            objects.Add(tree5);
            objects.Add(tree6);
            objects.Add(tree7);
            objects.Add(tree8);
            objects.Add(tree9);
            objects.Add(tree10);
            objects.Add(tree11);
            objects.Add(tree12);

            objects.Add(house0);
            objects.Add(house1);
            objects.Add(house2);
            objects.Add(house3);
            objects.Add(house4);

            objects.Add(tablet);


            objects.Add(row);

            objects.Add(car);

            objects.Add(wheel1);
            objects.Add(wheel2);

            objects.Add(o0);
            objects.Add(o1);
            objects.Add(o2);
            objects.Add(o3);
            objects.Add(o4);
            objects.Add(o5);
            objects.Add(o6);
            objects.Add(o7);
            objects.Add(o8);
            objects.Add(o9);
            
            // матрица для преобразования из координат сцены в координаты экрана
            viewMatrix = new Matrix();
        }

        public Timer Timer
        {
            get { return timer; }
        }

        public int ObjectSize
        {
            set { size = value; }
        }

        public int ObjectAngle
        {
            set { angle = value; }
        }

        public int ObjectX
        {
            set { x = value; }
        }

        public int ObjectY
        {
            set { y = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            sceneSize = ClientRectangle.Width;

            // рисование объектов
            Draw(e.Graphics, ClientRectangle);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // перерисовка при изменении размеров экрана (элемента управления)
            Invalidate();
        }

        protected void Draw(Graphics g, Rectangle bound)
        {
            // заполнение фона
            SolidBrush brush = new SolidBrush(Color.FromArgb(59, 81, 84));

            PointF[] airBackgroundArray =
            {
                new PointF(0, 0),
                new PointF(ClientRectangle.Width, 0),
                new PointF(ClientRectangle.Width, ClientRectangle.Height / 2),
                new PointF(0, ClientRectangle.Height / 2),
            };
            g.FillPolygon(Brushes.Aqua, airBackgroundArray);

            PointF[] earthBackgroundArray =
            {
                new PointF(0, ClientRectangle.Height / 2 - 40), 
                new PointF(0, ClientRectangle.Height), 
                new PointF(ClientRectangle.Width, ClientRectangle.Height), 
                new PointF(ClientRectangle.Width, ClientRectangle.Height / 2 - 40), 
            };
            g.FillPolygon(Brushes.DarkGreen, earthBackgroundArray);

            PointF[] rowBackgroundArray =
           {
                new PointF(0, ClientRectangle.Height / 2 + 150),
                new PointF(0, ClientRectangle.Height - 35),
                new PointF(ClientRectangle.Width, ClientRectangle.Height - 35),
                new PointF(ClientRectangle.Width, ClientRectangle.Height / 2 +150),
            };
            g.FillPolygon(brush, rowBackgroundArray);



            // соотношение сторон экрана
            double a = (double)bound.Width / bound.Height;
                // высота сцены
                double sceneHeight = sceneSize / a;

                // матрица преобразования
                viewMatrix.Viewport(0, sceneSize, bound.Left, bound.Right,
                    0, sceneHeight, bound.Bottom, bound.Top);

            // Выделенный объект
            for (int i = 0; i < objects.Count; i++)
            {
                Object obj = objects[i];
                // Рисование объекта
                obj.Draw(g, viewMatrix);
            }
       
        }

        double speed = 0.01;
        double speeda = 0.008;
        int max = 3;
        int sec = 0;
        int value = 0;
        int min = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();

            value++;
            sec = value / 100;
            //ускорение
            if (speed < max && sec < 20)
            {
                speed += speeda;
            }

            //замедление
            if (speed > min && sec > 20)
            {
                speed -= speeda;

            }

            //отстановка
            if (speed < min )
            {
                speed = 0;

            }



            //колеса
            if (sec < 25)
            {
                wheel1.Angle -= speed;
                wheel2.Angle -= speed;
            }

            //поля 
            if (sec < 25)
            {
                flied0.X -= speed / 10;
                flied1.X -= speed / 10;
                flied2.X -= speed / 10;
                flied3.X -= speed / 10;
                flied4.X -= speed / 10;
                flied5.X -= speed / 10;

                if (flied0.X < -2500) { flied0.X = 3000; }
                if (flied1.X < -2500) { flied1.X = 3000; }
                if (flied2.X < -2500) { flied2.X = 3000; }
                if (flied3.X < -2500) { flied3.X = 3000; }
                if (flied4.X < -2500) { flied4.X = 3000; }
                if (flied5.X < -2500) { flied5.X = 3000; }
            }

            //кусты деревья
            if (sec < 20)
            {
                grass0.X -= speed;
                grass1.X -= speed;
                grass2.X -= speed;
                grass3.X -= speed;
                grass4.X -= speed;
                grass5.X -= speed;
                grass6.X -= speed;
                grass7.X -= speed;
                grass8.X -= speed;
                grass9.X -= speed;

                tree0.X -= speed;
                tree1.X -= speed;
                tree2.X -= speed;
                tree3.X -= speed;
                tree4.X -= speed;
                tree5.X -= speed;
                tree6.X -= speed;
                tree7.X -= speed;
                tree8.X -= speed;
                tree9.X -= speed;
                tree10.X -= speed;
                tree11.X -= speed;
                tree12.X -= speed;
                tree13.X -= speed;
                if (sec < 15)
                {
                    if (grass0.X < -350) { grass0.X = 1200; }
                    if (grass1.X < -350) { grass1.X = 1200; }
                    if (grass2.X < -350) { grass2.X = 1200; }
                    if (grass3.X < -350) { grass3.X = 1200; }
                    if (grass4.X < -350) { grass4.X = 1200; }
                    if (grass5.X < -350) { grass5.X = 1200; }
                    if (grass6.X < -350) { grass6.X = 1200; }
                    if (grass7.X < -350) { grass7.X = 1200; }
                    if (grass8.X < -350) { grass8.X = 1200; }
                    if (grass9.X < -350) { grass9.X = 1200; }

                    if (tree0.X < -350) { tree0.X = 1200; }
                    if (tree1.X < -350) { tree1.X = 1200; }
                    if (tree2.X < -350) { tree2.X = 1200; }
                    if (tree3.X < -350) { tree3.X = 1200; }
                    if (tree4.X < -350) { tree4.X = 1200; }
                    if (tree5.X < -350) { tree5.X = 1200; }
                    if (tree6.X < -350) { tree6.X = 1200; }
                    if (tree7.X < -350) { tree7.X = 1200; }
                    if (tree8.X < -350) { tree8.X = 1200; }
                    if (tree9.X < -350) { tree9.X = 1200; }
                    if (tree10.X < -350) { tree10.X = 1200; }
                    if (tree11.X < -350) { tree11.X = 1200; }
                    if (tree12.X < -350) { tree12.X = 1200; }
                    if (tree13.X < -350) { tree13.X = 1200; }
                }



            }

            //дома
            if (sec > 15 && sec < 25)
            {
                house0.X -= speed;
                house1.X -= speed;
                house2.X -= speed;
                house3.X -= speed;
                house4.X -= speed;
                if (sec < 25 && sec >15)
                {
                    if (house0.X < -150) { house0.X = 1250; }
                    if (house1.X < -150) { house1.X = 1250; }
                    if (house2.X < -150) { house2.X = 1250; }
                    if (house3.X < -150) { house3.X = 1250; }
                    if (house4.X < -150) { house4.X = 1250; }

                }


            }

            //табличка
            if (sec > 15)
            {
                tablet.X -= speed;
            }

            //облака
            if (sec < 25)
            {
                o0.X -= speed / 13;
                o1.X -= speed / 13;
                o2.X -= speed / 13;
                o3.X -= speed / 13;
                o4.X -= speed / 13;
                o5.X -= speed / 13;
                o6.X -= speed / 13;
                o7.X -= speed / 13;
                o8.X -= speed / 13;
                o9.X -= speed / 13;

                if (o0.X < -150) { o0.X = 1100; }
                if (o1.X < -150) { o1.X = 1100; }
                if (o2.X < -150) { o2.X = 1100; }
                if (o3.X < -150) { o3.X = 1100; }
                if (o4.X < -150) { o4.X = 1100; }
                if (o5.X < -150) { o5.X = 1100; }
                if (o6.X < -150) { o6.X = 1100; }
                if (o7.X < -150) { o7.X = 1100; }
                if (o8.X < -150) { o8.X = 1100; }
                if (o9.X < -150) { o9.X = 1100; }
            }

            //дорога
            if (sec < 25)
            {
                row.X -= speed;
                if (row.X < -577) { row.X = 20; }
            }

        }
    }
}
