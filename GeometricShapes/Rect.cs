using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Rect {

        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public int Perimeter() {
            return 2 * (Side1 + Side2);
        }

        public Rect(int s1, int s2) {
            Side1 = s1;
            Side2 = s2;
        }
    }
}
