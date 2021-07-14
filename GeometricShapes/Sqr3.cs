using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Sqr3 : Rect3 {

        public string WhatAmI() {
            return "Sqr";
        }

        public Sqr3(int s) : base(s, s) {

        }
    }
}
