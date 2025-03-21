using System;
using System.Runtime.CompilerServices;

public class Task1
{
    static void one () {  
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число должно быть двузначным.");
            return;
        }

        int digit1 = number / 10; 
        int digit2 = number % 10; 

        if (digit1 == 4 || digit1 == 7 || digit2 == 4 || digit2 == 7)
        {
            Console.WriteLine("В число входят цифры 4 или 7.");
        }
        else
        {
            Console.WriteLine("В число не входят цифры 4 или 7.");
        }

        if (digit1 == 3 || digit1 == 6 || digit1 == 9 || digit2 == 3 || digit2 == 6 || digit2 == 9)
        {
            Console.WriteLine("В число входят цифры 3, 6 или 9.");
        }
        else
        {
            Console.WriteLine("В число не входят цифры 3, 6 или 9.");
        }
    }



    static void two () {
        Console.Write("Введите натуральное число (n <= 9999): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 9999)
        {
            Console.WriteLine("Число должно быть от 0 до 9999.");
            return;
        }

        int[] digits = new int[4];
        digits[0] = n / 1000;
        digits[1] = (n % 1000) / 100;
        digits[2] = (n % 100) / 10;
        digits[3] = n % 10;

        int count = 0;
        for (int i = 0; i < 4; ++i)
        {
            int identicalCount = 0;
            for (int j = 0; j < 4; ++j)
            {
                if (digits[i] == digits[j])
                {
                    identicalCount++;
                }
            }
            if (identicalCount == 3)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine("Число содержит ровно три одинаковые цифры.");
        }
        else
        {
            Console.WriteLine("Число не содержит ровно три одинаковые цифры.");
        }
    }

    static void three () {
        Console.Write("Введите четыре вещественных числа (через пробел): ");
        string[] input = Console.ReadLine().Split(' ');

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double d = double.Parse(input[3]);

        int negativeCount = 0;

        if (a < 0) negativeCount++;
        if (b < 0) negativeCount++;
        if (c < 0) negativeCount++;
        if (d < 0) negativeCount++;

        Console.WriteLine("Количество отрицательных чисел: " + negativeCount);
    }


    static void four () {
        Console.Write("Введите коэффициенты квадратного уравнения (a, b, c): ");
        string[] input = Console.ReadLine().Split(' ');

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение (a должно быть не равно 0).");
            return;
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("Вещественных корней нет.");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Один вещественный корень: x = " + root.ToString("F2"));
        }
        else
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Два вещественных корня: x1 = " + root1.ToString("F2") + ", x2 = " + root2.ToString("F2"));
        }
    }
        public static double FindMiddle(double a, double b, double c)
    {
        double[] arr = { a, b, c };
        Array.Sort(arr);
        return arr[1];
    }



    static void five () {



        Console.Write("Введите первую тройку вещественных чисел (через пробел): ");
        string[] input1 = Console.ReadLine().Split(' ');
        double a1 = double.Parse(input1[0]);
        double b1 = double.Parse(input1[1]);
        double c1 = double.Parse(input1[2]);

        Console.Write("Введите вторую тройку вещественных чисел (через пробел): ");
        string[] input2 = Console.ReadLine().Split(' ');
        double a2 = double.Parse(input2[0]);
        double b2 = double.Parse(input2[1]);
        double c2 = double.Parse(input2[2]);

        double middle1 = FindMiddle(a1, b1, c1);
        double middle2 = FindMiddle(a2, b2, c2);

        double averageOfMiddle = (middle1 + middle2) / 2.0;

        Console.WriteLine("Среднее арифметическое средних чисел: " + averageOfMiddle.ToString("F2"));
    }



    static void six () {

        Console.Write("Введите порядковый номер дня недели (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "понедельник";
                break;
            case 2:
                dayName = "вторник";
                break;
            case 3:
                dayName = "среда";
                break;
            case 4:
                dayName = "четверг";
                break;
            case 5:
                dayName = "пятница";
                break;
            case 6:
                dayName = "суббота";
                break;
            case 7:
                dayName = "воскресенье";
                break;
            default:
                Console.WriteLine("Некорректный номер дня недели.");
                return;
        }

        Console.WriteLine("Этот день недели: " + dayName);
    }


    static void seven () {
        Console.Write("Введите порядковый номер месяца (1-12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        string season;

        switch (monthNumber)
        {
            case 12:
            case 1:
            case 2:
                season = "зима";
                break;
            case 3:
            case 4:
            case 5:
                season = "весна";
                break;
            case 6:
            case 7:
            case 8:
                season = "лето";
                break;
            case 9:
            case 10:
            case 11:
                season = "осень";
                break;
            default:
                Console.WriteLine("Некорректный номер месяца.");
                return;
        }

        Console.WriteLine("Этот месяц относится к времени года: " + season);
    }

    static void eight () {
        Console.WriteLine("Введите год, месяц и день рождения (через пробел):");
        string[] birthInput = Console.ReadLine().Split(' ');
        int birthYear = int.Parse(birthInput[0]);
        int birthMonth = int.Parse(birthInput[1]);
        int birthDay = int.Parse(birthInput[2]);

        Console.WriteLine("Введите текущий год, месяц и день (через пробел):");
        string[] currentInput = Console.ReadLine().Split(' ');
        int currentYear = int.Parse(currentInput[0]);
        int currentMonth = int.Parse(currentInput[1]);
        int currentDay = int.Parse(currentInput[2]);

        int age = currentYear - birthYear;

        if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
        {
            age--;
        }

        Console.WriteLine("Возраст человека: " + age + " полных лет.");
    }

    static void nine () {

        Console.WriteLine("а) Целые числа от 20 до 35:");
        for (int i = 20; i <= 35; ++i)
        {
            Console.WriteLine(i);
        }

        Console.Write("\nб) Введите b (b > 10): ");
        int b = int.Parse(Console.ReadLine());

        if (b <= 10)
        {
            Console.WriteLine("b должно быть больше 10.");
        }
        else
        {
            Console.WriteLine("Квадраты целых чисел от 10 до " + b + ":");
            for (int i = 10; i <= b; ++i)
            {
                Console.WriteLine(i * i);
            }
        }

        Console.Write("\nв) Введите a (a < 50): ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 50)
        {
            Console.WriteLine("a должно быть меньше 50.");
        }
        else
        {
            Console.WriteLine("Третьи степени целых чисел от " + a + " до 50:");
            for (int i = a; i <= 50; ++i)
            {
                Console.WriteLine(i * i * i);
            }
        }

        Console.Write("\nг) Введите a и b (b < a): ");
        string[] input = Console.ReadLine().Split(' ');
        int a_g = int.Parse(input[0]);
        int b_g = int.Parse(input[1]);

        if (b_g >= a_g)
        {
            Console.WriteLine("b должно быть меньше a.");
        }
        else
        {
            Console.WriteLine("Целые числа от " + a_g + " до " + b_g + ":");
            for (int i = a_g; i >= b_g; --i)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void ten () {

        const double R = 6370.0; 

        Console.WriteLine("Расстояние до линии горизонта от точки с высотой над Землей:");
        Console.WriteLine("Высота (км) | Расстояние до горизонта (км)");
        Console.WriteLine("----------------------------------------");

        for (int h = 1; h <= 10; ++h)
        {
            double d = Math.Sqrt(2 * R * h + h * h); 
            Console.WriteLine($"{h,8} | {d,29:F2}");
        }
    }

        public static void Main(string[] args) {
            Console.WriteLine("Введите номер задачи: ");
            Console.WriteLine("(от one до ten)");
            string number = Convert.ToString(Console.ReadLine());
            Console.WriteLine(number);
            switch (number) {
                case "one": {
                    one();
                    break;
                } case "two": {
                    two();
                    break;
                } case "three": {
                    three();
                    break;
                } case "four": {
                    four();
                    break;
                } case "five": {
                    five();
                    break;
                } case "six": {
                    six();
                    break;
                } case "seven": {
                    seven();
                    break;
                } case "eight": {
                    eight();
                    break;
                } case "nine": {
                    nine();
                    break;
                } case "ten": {
                    ten();
                    break;
                } default: {
                    Console.WriteLine("неверный ввод");
                    break;
                }
            }
        }
    }

            