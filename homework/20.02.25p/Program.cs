using System;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите длины трех сторон треугольника (целые числа, через пробел):");
                string input = Console.ReadLine();
                string[] sidesStr = input.Split(' ');

                if (sidesStr.Length != 3)
                {
                    throw new ArgumentException("Должно быть введено ровно три числа.");
                }

                int a = ParseSide(sidesStr[0]);
                int b = ParseSide(sidesStr[1]);
                int c = ParseSide(sidesStr[2]);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException("Длины сторон должны быть положительными.");
                }

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    throw new ArgumentException("Треугольник с такими сторонами не существует (сумма двух сторон должна быть больше третьей).");
                }
                string type = DetermineTriangleType(a, b, c);
                double perimeter = a + b + c;
                double s = perimeter / 2.0;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine("Тип треугольника: " + type);
                Console.WriteLine("Периметр: " + perimeter);
                Console.WriteLine("Площадь: " + area.ToString("F2")); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
        static int ParseSide(string sideStr)
        {
            if (string.IsNullOrEmpty(sideStr))
            {
                throw new ArgumentException("Одно или несколько полей ввода пусты.");
            }

            if (!int.TryParse(sideStr, out int side))
            {
                throw new FormatException("Некорректный формат числа. Введите целое число.");
            }

            return side;
        }
        static string DetermineTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                return "Равнобедренный";
            }
            else
            {
                int[] sides = { a, b, c };
                Array.Sort(sides);
                if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
                {
                    return "Прямоугольный";
                }
                else
                {
                    double angleA = Math.Acos((b * b + c * c - a * a) / (2.0 * b * c)) * 180 / Math.PI;
                    if (angleA < 90)
                    {
                        return "Остроугольный";
                    }
                    else
                    {
                        return "Тупоугольный";
                    }
                }
            }

            return "Разносторонний";
        }
    }
}