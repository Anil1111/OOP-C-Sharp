namespace Characters
{



    public class Warrior
    {
        private int height;
        private int weight;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }

        public void Greetings(Warrior warrior)
        {
            System.Console.WriteLine($@"Greetings, {warrior.Name}!");  //This $ lets you use variables directly in your string
        }
    }
}