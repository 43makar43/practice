using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mironchik
{
    public class galactic
    {
        protected string Name;
        protected int mass;// масса
        protected int maxValue;

         public galactic()
        {

        }
        public galactic(string Name, int mass)
        {
            this.Name = Name;
            this.mass = mass;
            maxValue = 1000;

        }

        public string name
        {
            set {
                if (value.Length > 6)
                {
                    Console.WriteLine("Больше 6 символов");
                    return;
                }
                else
                    Name = value;
            }
            get { return Name; }
        }
        public int Mass
        {
            set
            {
                if (value>maxValue)
                {
                    Console.WriteLine("Больше 1000");
                    return;
                }
                else
                    mass = value;
            }
            get { return mass; }

        }
        public int MaxValue
        {
            get { return maxValue; }
        }


    }
    public class Planet:galactic
    {
        public int EarthMass;
        protected int maxEarthMass;
        public Planet()
            :base()
        {

        }
        public Planet(string Name, int mass, int EarthMass)
            :base(Name, mass)
        {
            this.Name = Name;
            this.mass = mass;
            this.EarthMass = EarthMass;
            maxEarthMass = 100;
        }

        public int earthMass
        {
            set
            {
                if (value > maxEarthMass)
                {
                    EarthMass = maxEarthMass;
                    return;
                }
                else
                    EarthMass = value;
            }
            get { return EarthMass; }
        }

        public int maxearthMass
        {
            get { return maxEarthMass; }
        }
    }

}
