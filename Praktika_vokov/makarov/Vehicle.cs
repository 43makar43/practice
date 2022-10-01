using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportApp
{
    //

    public enum VehicleTypes
    {
        Unknown,
        AirVehicle,
        WaterVehicle,
        LandVehicle

    }
    public class Vehicle
    {
        string name;
        double volume;
        double maxVolume;

        double x;
        double y;

        VehicleTypes type;

        public Vehicle()
        {
            name = string.Empty;
            volume = 0;
            maxVolume = 100;
            x = 0;
            y = 0;
        }
        public Vehicle(string name, double maxVolume)
        {
            this.name = name;
            this.maxVolume = maxVolume;
            x = 0;
            y = 0;

        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Volume
        {
            set
            {
                if (value < 0)
                    volume = 0;
                else if (volume > maxVolume)
                    volume = maxVolume;
                else
                    volume = value;
            }
            get
            {
                return volume;
            }
        }
        public double MaxVolume
        {
            set
            {
                if (value < 0)
                    maxVolume = 100;
                else maxVolume = value;

            }
            get
            {
                return maxVolume;
            }
        }
        public virtual void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
            
        }

        public virtual VehicleTypes GetVehicleType()
        {
            return VehicleTypes.Unknown;
        }
    }

    public class AirVehicle : Vehicle
    {
        int engines;
        public AirVehicle()
            : base()
        {
            engines = 1;

        }

        public AirVehicle(string name, double maxVolume, int engines )
            : base(name, maxVolume)
        {
            this.engines = engines;
        }

        public int Engines
        {
            set
            {
                if (engines < 1)
                    engines = 1;
                else
                    engines = value;

            }
            get { return engines; }
        }

        public void Fly( double x, double y)
        {
            
            Move(x, y);
        }

        public override VehicleTypes GetVehicleType()
        {
            return VehicleTypes.AirVehicle;

        }
    }

    public class WaterVehicle : Vehicle
    {
        double displacement;

        public WaterVehicle()
            : base()
        {
            displacement = 100;
        }
        public WaterVehicle(string name, double maxVolume, double displacement)
            : base(name, maxVolume)
        {
            this.displacement = displacement;
        }
        public double Displacement
        {
            set
            {
                if (value < 0)
                    displacement = 100;
                else
                    displacement = value;
            }
            get { return displacement; }
        }
        public void Sails(double x, double y)
        {
           
            Move(x, y);
        }
        public override VehicleTypes GetVehicleType()
        {
            return VehicleTypes.WaterVehicle;

        }
    }

    public class LandVehicle : Vehicle
    {
        int wheels;
        public LandVehicle()
            : base()
        {
            wheels = 2;
        }
        public LandVehicle(string name, double maxVolume, int wheels)
            : base (name, maxVolume)
        {
            this.wheels = wheels;
        }
        public int Wheels
        {
            set
            {
                if (value > 1)
                    wheels = 1;
                else wheels = value;

            }
            get { return wheels; }
        }

        public void Roll(double x, double y)
        {
            
            Move(x, y);
        }
        public override VehicleTypes GetVehicleType()
        {
            return VehicleTypes.LandVehicle;

        }
    }
    public class SpeadVehicle
    {

    }
    public class MaxSpeadVehicle
    {

    }
}
