using System;

namespace Advanced_Lesson_1_OOP
{
    public static partial class Lesson
    {

        public static void InheritanceTransportExample()
        {
            Transport transport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            var transport2 = new Transport { Distance = 34, MaxSpeed = 5 };

            Transport unknowedTransport = new Transport { Distance = 34, MaxSpeed = 5 };
            unknowedTransport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            //var fuel = unknowedTransport.Fuel;

            FuelCar maserati = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            Transport winner = maserati;
            FuelCar firstPlace = (FuelCar)winner;

            //A.L1.P5/6.

            FuelCar infiniti = new FuelCar() { Engine = 340 };
            FuelCar hyundaiI10 = new FuelCar() { Engine = 87 };
            СomparisonPower(infiniti, hyundaiI10);
        }
        private static void СomparisonPower(FuelCar car1, FuelCar car2)
        {
            var equalPower = car1 > car2 ? "Infinity car is more powerful" : "Hyundai I 10 car is more powerful";
            var equalPower_2 = car1 == car2 ? "Power cars are equal" : "Power cars are not equal";
            Console.WriteLine(equalPower);
            Console.WriteLine(equalPower_2);
        }
    }

    public class Transport
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public int MaxSpeed { get; set; }
        public float Distance { get; set; }

        public virtual void Move(float km)
        {
            this.Distance += km;
        }
    }

    public class Car : Transport
    {
        public float Engine { get; set; }
    }

    public class FuelCar : Car
    {
        public int Tank { get; set; }
        public float Fuel { get; set; }
        public float FuelUsage { get; set; }

        public override void Move(float km)
        {
            base.Move(km);
            this.Fuel -= km * FuelUsage / 100;
        }
        public static bool operator >(FuelCar car_1, FuelCar car_2)
        {
            return car_1.Engine > car_2.Engine;
        }
        public static bool operator <(FuelCar car_1, FuelCar car_2)
        {
            return car_1.Engine < car_2.Engine;
        }
        public static bool operator ==(FuelCar car_1, FuelCar car_2)
        {
            return car_1.Equals(car_2);
        }
        public static bool operator !=(FuelCar car_1, FuelCar car_2)
        {
            return !car_1.Equals(car_2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is FuelCar))
                return false;
            return ((FuelCar)obj).Engine == this.Engine;
        }

        public override int GetHashCode()
        {
            return this.Engine.GetHashCode();
        }
    }

    public class ElectroCar : Car
    {
        public int Battery { get; set; }
        public float Charged { get; set; }
        public float DistanceBattery { get; set; }

        public override void Move(float km)
        {
            base.Move(km);
            this.Charged -= Battery * km / DistanceBattery;
        }
    }
}
