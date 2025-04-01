namespace Capitals.Countries
{
    public class France
    {
        public class Paris
        {
            public int Population { get; set; } = 2141000;
             public string Name => "Париж";

            public void DisplayInfo()
            {
                Console.WriteLine($"Столица: {Name}, Население: {Population}");
            }
        }
    }
}