using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    
    class Rect3 : Quad {

        public int Area() {
            return Side1 * Side2;
        }

        public  string WhatAmI() {
            return "Rect";
        }

        public Rect3(int s1, int s2) : base(s1, s2, s1, s2) {
        }
    }
}
