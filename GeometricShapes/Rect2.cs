using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Rect2 {

        public Quad quad { get; set; }

        public int Perimeter() {
            return Convert.ToInt32(quad.Perimeter());
        }

        public int Area() {
            return Convert.ToInt32(quad.Side1 * quad.Side2);
        }

        public Rect2(int s1, int s2) {
            quad = new Quad(s1, s2, s1, s2);
        }
    }
}
