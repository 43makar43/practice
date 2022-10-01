using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_Volkov_Makarov_
{
    public class Vector
    {
        double[] elements;

        public Vector(int n)
        {
            elements = new double[n];
        }

        public Vector(Vector v)
        {
            elements = new double[v.elements.Length];
            for (int i = 0; i < v.elements.Length; i++)
                elements[i] = v.elements[i];
        }

        public double Length
        {
            get
            {
                double len = 0;
                for (int i = 0; i < elements.Length; i++)
                    len += elements[i] * elements[i];

                len = Math.Sqrt(len);
                return len;
            }
        }
        public double this[int index]
        {
            set
            {
                elements[index] = value;
            }
            get
            {
                return elements[index];
            }
        }
        public int Size
        {
            get { return elements.Length; }
        }

        public void Mult(double a)
        {
            for (int i = 0; i < elements.Length; i++)
                elements[i] *= a;
        }

        public void Normalize()
        {
            double len = Length;
            if (len > 0)
            {
                len = 1.0 / len;
                Mult(len);

                /*
                for (int i = 0; i < elements.Length; i++)
                    elements[i] /= len; */
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            // '1 2 3'
            for (int i = 0; i < elements.Length - 1; i++)
            {
                str.Append(elements[i]);
                str.Append(' ');
            }
            str.Append(elements[elements.Length - 1]);

            return str.ToString();
        }
    }
}
