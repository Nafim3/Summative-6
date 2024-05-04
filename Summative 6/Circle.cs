using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summative_6
{
     class Circle
     {
        private static int lastID = 0;
        private int ID;
        private double radius;

        public Circle(double radius)
        {
            SetRadius(radius);
            ID = ++lastID;
        }

        public Circle() : this(1) { } // Default constructor with a radius of 1

        public void SetRadius(double newRadius)
        {
            if (newRadius >= 0)
            {
                radius = newRadius;
            }
            else
            {
                Console.WriteLine("Radius cannot be negative. Radius set to 0.");
                radius = 0;
            }
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public int GetID()
        {
            return ID;
        }
     }
}
