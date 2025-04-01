namespace Capitals.Countries
{
    public class USA
    {
        public class WashingtonDC
        {
            public int Population { get; set; } = 705749;
            public string Name => "Вашингтон";

            public void DisplayInfo()
            {
                Console.WriteLine($"Столица: {Name}, Население: {Population}");
            }
        }
    }
}