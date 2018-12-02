using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task02._2._2.TRIANGLE
{
    class Program
    {
        private static int n;
        private static Triangle[] array;
        private bool exists = false;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            GenerateArrayOfTriangles();
            ShowTriangles();
            Console.ReadLine();
        }

        public static int AskN()
        {
            do
            {
                Console.WriteLine(new String('_', 50));
                Console.WriteLine("Введите количество треугольников: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (!(n > 0));
            return n;
        }

        public static double AskSide(int i, string sidename)
        {
            double side;
            do
            {
                Console.WriteLine($"Введите сторону {sidename} треугольника № {i + 1}");
                double.TryParse(Console.ReadLine(), out side);
            } while (!(side > 0));
            return side;
        }

        public static Triangle[] GenerateArrayOfTriangles()
        {
            array = new Triangle[AskN()];
            for (int i = 0; i < n; i++)
            {
                double a = 0;
                double b = 0;
                double c = 0;
                do {
                    a = AskSide(i, "a");
                    b = AskSide(i, "b");
                    c = AskSide(i, "c");
                    if (!Triangle.triangleExist(a, b, c)) Console.WriteLine("Такой треугольник не существует");

                } while (!Triangle.triangleExist(a, b, c));
                
                 array[i] = new Triangle(a, b, c);
                 Console.WriteLine($"Треугольник № {i + 1} создан");
                
                Console.WriteLine(new String('_', 50));
            }
            return array;
        }

        public static void ShowTriangles()
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine($"Треугольник №{i + 1}:");
                    Console.WriteLine($"Сторона А = {array[i].A}, " +
                        $"cторона B = {array[i].B}, " +
                        $"cторона C = {array[i].C}");
                    Console.WriteLine($"Площадь = {array[i].CalculaterSquare().ToString(".00")}, " +
                        $"Периметр = {((array[i].CalculateHalfPerimeter()) * 2).ToString(".00")}");
                    Console.WriteLine(new String('_', 50));
                }
            }
        }
    }
}
