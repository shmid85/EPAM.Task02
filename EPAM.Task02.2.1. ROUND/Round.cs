using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task02._2._1.ROUND
{
    class Round
    {
        private double radius;
        private Point center;
        private double square;
        private double length;
        public Round() { }
        public Round(double r, int x=0, int y=0) {
            Radius = r;
            center = new Point(x,y);
            square = 2 * Math.PI * Math.Pow(radius, 2);
            length = 2 * Math.PI * radius;
        }
        
        public double Radius {
            get => radius;
            private set {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус должен быльше нуля");
                }
                radius = value;
            }
        }
        public double LengthOfRound {
            get => length;
        }
        public double SquareOfRound {
            get => square;
        }

        public Point Center {
            get => center;
            set {
                center = value;
            }
        }
    }
}
