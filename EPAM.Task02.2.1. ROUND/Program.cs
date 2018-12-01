using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task02._2._1.ROUND
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            GenerateArrayOfRouns();
        }

        public static Round[] GenerateArrayOfRouns() {
            Round[] array = new Round[AskN()];
            for (int i = 1; i <= n; i++)
            {
                array[i] = new Round(AskCenterPoint(i, "X"), AskCenterPoint(i, "Y"));
            }
            return array;
        }

        public static int AskN() {
            i
            Console.WriteLine("Введите количество кругов: ");
            do
            {
                int.TryParse(Console.ReadLine(), out n);
            } while (!(n > 0));
            return n;
        }

        public static int AskCenterPoint(int i, string s) {
            int c;
            Console.WriteLine($"Введите коорднату {s} круга № {i}");
            do
            {
                int.TryParse(Console.ReadLine(), out c);
            } while (!(c > 0));
            return c;
        }

    }
}
