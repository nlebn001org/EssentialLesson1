using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Task4
{
    class Point
    {

        public int Int1 { get; }
        public int Int2 { get; }
        public string Str { get; }

        public Point(string str, int int1, int int2)
        {
            Str = str;
            Int1 = int1;
            Int2 = int2;
        }
    }
}
