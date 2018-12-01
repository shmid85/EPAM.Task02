using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task02._2._1.ROUND
{
    class Point
    {
        public Point() : this(0, 0)
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }   
}
