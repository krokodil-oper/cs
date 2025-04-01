namespace SevenWonders
{
    public abstract class Wonder
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Чудо: {Name}");
            Console.WriteLine($"Описание: {Description}");
        }
    }
}