using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task02._2._1.ROUND
{
    class Round
    {
        public Round() { }
        public Round(double r, int x=0, int y=0) {
            Radius = r;
            Center.X = x;
            Center.Y = y;
        }


        public double Radius {
            get => Radius;
            private set {
                if (value > 0)
                {
                    Radius = value;
                }else throw new ArgumentException("Радиус должен быльше нуля");
            }
        }
        public double LengthOfRound {
            get => LengthOfRound;
            private set => LengthOfRound = 2 * Math.PI * Radius;
        }
        public double SquareOfRound {
            get => SquareOfRound;
            private set => SquareOfRound = 2 * Math.PI * Math.Pow(Radius, 2);
        }

        public Point Center {
            get => Center;
            set {
                Center = new Point();
            }
        }
    }
}
