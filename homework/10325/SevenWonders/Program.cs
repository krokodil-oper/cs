using SevenWonders;

public class EntryPoint
{
    public static void Main(string[] args)
    {
        List<Wonder> wonders = new List<Wonder>()
        {
            new GreatPyramid(),
            new StatueOfZeus(),
            new TempleOfArtemis(),
            new MausoleumAtHalicarnassus(),
            new ColossusOfRhodes(),
            new LighthouseOfAlexandria()
        };

        foreach (var wonder in wonders)
        {
            wonder.DisplayInfo();
            Console.WriteLine();
        }
    }
}