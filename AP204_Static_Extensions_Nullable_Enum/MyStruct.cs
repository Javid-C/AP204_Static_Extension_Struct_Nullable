using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Static_Extensions_Nullable_Enum
{
    struct MyStruct
    {
        public int X;
        public int Y;


        public MyStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Area(int a,int b)
        {
            return a * b;
        }
    }
}
