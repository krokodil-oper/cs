using Capitals.Countries;

public class CapitalsComparison
{
    public static void Main(string[] args)
    {
        Russia.Moscow moscow = new Russia.Moscow();
        USA.WashingtonDC washington = new USA.WashingtonDC();
        France.Paris paris = new France.Paris();

        Console.WriteLine("Информация о столицах:");

        Console.Write("Россия: ");
        moscow.DisplayInfo();

        Console.Write("США: ");
        washington.DisplayInfo();

        Console.Write("Франция: ");
        paris.DisplayInfo();

        Console.WriteLine("\nСравнение населения:");

        if (moscow.Population > washington.Population && moscow.Population > paris.Population)
        {
            Console.WriteLine("Москва - самая населенная столица.");
        }
        else if (washington.Population > moscow.Population && washington.Population > paris.Population)
        {
            Console.WriteLine("Вашингтон - самая населенная столица.");
        }
        else if (paris.Population > moscow.Population && paris.Population > washington.Population)
        {
            Console.WriteLine("Париж - самая населенная столица.");
        }
        else
        {
            Console.WriteLine("Население нескольких столиц одинаково или нельзя однозначно определить самую населенную.");
        }
    }
}