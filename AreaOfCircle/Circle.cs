using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfCircle
{
    class Circle
    {

        private double radius;
        private readonly double PI = 3.14f;
        public Circle(double radius) 
        {

            this.radius = radius;
        
        }
        public double getArea()
        {

            double area = Math.Pow(radius, 2) * PI;
            return area;


        }
        public double getCircumfrance()
        {

            double circumfrance = (2*radius) * PI;
            return circumfrance;


        }

    }
}
