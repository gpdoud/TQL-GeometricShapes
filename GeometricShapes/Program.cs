using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var sqr1 = new Sqr2(2);
            Console.WriteLine($"Perimeter is {sqr1.Perimeter()}");
            var rect1 = new Rect(4, 7);
            Console.WriteLine($"Perimeter is {rect1.Perimeter()}");
            var rect2 = new Rect2(4, 7);
            Console.WriteLine($"Perimeter is {rect2.Perimeter()}");

            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"Perimeter is {quad1.Perimeter()}");

            var quad2 = new Quad();
            quad2.Side1 = 3;
            quad2.Side2 = 4;
            quad2.Side3 = 5;
            quad2.Side4 = 6;
        }
    }
}
