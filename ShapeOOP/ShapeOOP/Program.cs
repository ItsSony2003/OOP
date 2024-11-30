using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOOP
{
    internal class Program
    {
        public class Rectangle
        {
            double width, height;

            public Rectangle() { }

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double GetArea() 
            { 
                return this.width * this.height;
            }

            public double GetPerimeter()
            {
                return (this.width + this.height) * 2;
            }

            public string Display()
            {
                return "\nYour Rectangle {" + "width = " + width + ", height = " + height + "}";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("" + rectangle.Display());
            Console.WriteLine("\nPerimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
            Console.ReadKey();
        }
    }
}
