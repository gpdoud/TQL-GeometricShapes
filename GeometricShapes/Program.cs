using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            Quad q = new Sqr3(9);

            var sqr35 = new Sqr3(5);
            var sqr37 = new Sqr3(7);
            var rect31 = new Rect3(4,7);
            var rect32 = new Rect3(3, 5);
            var rect33 = new Rect3(9, 11);
            var quad10 = new Quad(1, 2, 3, 4);

            var shapes = new Quad[] { sqr35, sqr37, rect31, rect32, rect33, quad10 };

            foreach(var shape in shapes) {
                Console.WriteLine($"{shape.WhatAmI()} perimeter is {shape.Perimeter()}");
            }










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
