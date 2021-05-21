using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Sqr2 {

        public Rect2 rect { get; set; }

        public int Perimeter() {
            return rect.Perimeter();
        }

        public int Area() {
            return rect.Area();
        }


        public Sqr2(int s) {
            rect = new Rect2(s, s);
        }
    }
}
