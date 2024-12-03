using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fan 1
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "Yellow";
            fan1.On = true;

            //Fan 2
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            fan2.Radius = 5;
            fan2.Color = "Blue";
            fan2.On = false;

            Console.WriteLine("Fan 1: " + fan1);
            Console.WriteLine("Fan 2: " + fan2);
            Console.ReadKey();
        }
    }

    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public Fan()
        {
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        { 
            get { return on; }
            set { on = value; } 
        }

        public double Radius
        { 
            get { return radius; }
            set { radius = value; } 
        }

        public string Color
        { 
            get { return color; }
            set { color = value; } 
        }

        public override string ToString()
        {
            if (on)
            {
                return $"Fan is on - Speed: {speed}, Color: {color}, Radius: {radius}";
            }
            else
            {
                return $"Fan is off - Color: {color}, Radius: {radius}";
            }
        }
    }
}
