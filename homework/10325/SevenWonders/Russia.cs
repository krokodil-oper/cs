namespace Capitals.Countries
{
    public class Russia
    {
        public class Moscow
        {
            public int Population { get; set; } = 13010000;
            public string Name => "Москва";

            public void DisplayInfo()
            {
                Console.WriteLine($"Столица: {Name}, Население: {Population}");
            }
        }
    }
}