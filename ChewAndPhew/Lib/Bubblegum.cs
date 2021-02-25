namespace ChewAndPhew.Lib
{
    public class Bubblegum
    {
        public Bubblegum(Bubblegum bubblegum)
        {
            Name = bubblegum.Name;
            Color = bubblegum.Color;
        }
        public Bubblegum(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; private set; }
        public string Color { get; private set; }

        public override string ToString()
        {
            return $"Bubble gum is {Name} and is colored {Color}";
        }
    }
}
