using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task02._2._1.ROUND
{
    class Program
    {
        static int n;
        static Round[] array;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            GenerateArrayOfRouns();
            ShowRounds();
            Console.ReadLine();
            
        }

        public static Round[] GenerateArrayOfRouns() {
            array = new Round[AskN()];
            for (int i = 0; i < n; i++)
            {
                array[i] = new Round(AskRadius(i), AskCenterPoint(i, "X"), AskCenterPoint(i, "Y"));
                Console.WriteLine($"Круг № {i+1} создан");
                Console.WriteLine(new String('_', 50));
            }
            return array;
        }
        public static void ShowRounds() {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Круг №{i+1}:");
                Console.WriteLine($"Радиус =  {array[i].Radius}, Координаты центра: ({array[i].Center.X}, {array[i].Center.Y})");
                Console.WriteLine($"Площадь = {array[i].SquareOfRound.ToString(".00")}, Длинна окружности = {array[i].LengthOfRound.ToString(".00")}");
                Console.WriteLine(new String('_', 50));
            }
        }

        public static int AskN() {
            do
            {
                Console.WriteLine(new String('_', 50));
                Console.WriteLine("Введите количество кругов: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (!(n > 0));
            return n;
        }

        public static int AskCenterPoint(int i, string s) {
            int c;
            do
            {
                Console.WriteLine($"Введите коорднату {s} круга № {i+1}");
                int.TryParse(Console.ReadLine(), out c);
            } while (!(c > 0));
            return c;
        }

        public static double AskRadius(int i) {
            double r;
            do
            {
                Console.WriteLine($"Введите радиус круга №{i+1}");
                double.TryParse(Console.ReadLine(), out r);
            } while (!(r > 0));
            return r;
        }

    }
}
