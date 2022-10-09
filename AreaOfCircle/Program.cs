using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1 = 5, r2 = 6;

            Circle c1 = new Circle(r1);
            Circle c2 = new Circle(r2);

            // Skriver ut arean av de 2 cirklarna, l.e^2(LängdEnheter i kvadrat)
            Console.WriteLine("Första cirkeln med radie {0} har arean {1:F2} l.e^2", r1, c1.getArea());
            Console.WriteLine("Andra cirkeln med radie {0} har arean {1:F2} l.e^2", r2, c2.getArea());

            Console.WriteLine();

            // Skriver ut omkretsen av de 2 cirklarna, l.e(LängdEnheter)
            Console.WriteLine("Första cirkeln med radien {0} har omkretsen {1:F2} l.e", r1, c1.getCircumfrance());
            Console.WriteLine("Andra cirkeln med radien {0} har omkretsen {1:F2} l.e", r2, c2.getCircumfrance());

        }
    }
}
