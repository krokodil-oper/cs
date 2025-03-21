//1
using System;
using System.Linq;

public class Mainclass
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Введите предложение:");
        // string predl = Console.ReadLine();

        // predl = predl.Trim();

        // if (string.IsNullOrEmpty(predl))
        // {
        //     Console.WriteLine("Количество слов: 0");
        //     return;
        // }

        // string[] mas = predl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Console.WriteLine("Кол-во слов: " + mas.Length);


        //2


        // Console.WriteLine("Введите предложение:");
        // string rever = Console.ReadLine();

        // rever = rever.Trim();

        // string[] revermas = rever.Split(new char[] { ' ' });

        // string vivod = string.Join(" ", revermas.Select(reverfun));

        // Console.WriteLine(vivod);

        //3

        Console.WriteLine("Введите предложение: ");
        string predlo = Console.ReadLine();

        predlo = predlo.ToLower();

        int schet= 0;

        for(int i = 0; i < predlo.Length; i++ ){
            char odinsimvol = predlo[i];
        
        if (spisokglas(odinsimvol)){
                schet++;
            }
        }
        Console.WriteLine("Количество гласных букв: " + schet);
    }

    static string reverfun(string word)
    {
        return new string(word.ToCharArray().Reverse().ToArray());
    }
    static bool spisokglas(char c)
    {
        return (c == 'а' || c == 'я' || c == 'у' || c == 'ю' || c == 'о' || c == 'е' || c == 'ё' || c == 'э' || c == 'и' || c == 'ы' ||
                c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'); 
    }
}



  