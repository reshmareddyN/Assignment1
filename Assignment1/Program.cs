using System;
using System.Threading;
class VirtualPet
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }
    public VirtualPet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 5;
        Happiness = 5;
        Health = 5;
    }
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the Virtual Pet Simulator!");
        Console.WriteLine($"You have a {Type} named {Name}.");
    }
    public void DisplayStats()
    {
        Console.WriteLine($"Pet Stats - Hunger: {Hunger}/10, Happiness: {Happiness}/10, Health: {Health}/10");
    }
    public void Feed()
    {
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased, and health slightly increased.");
    }
    public void Play()
    {
        if (Hunger >= 3)
        {
            Happiness = Math.Min(10, Happiness + 2);
            Hunger = Math.Min(10, Hunger + 1);
            Console.WriteLine($"{Name} has played. Happiness increased, and hunger slightly increased.");
        }
        public void TimePasses()
        {
            Hunger = Math.Min(10, Hunger + 1);
            Happiness = Math.Max(0, Happiness - 1);
            Health = Math.Max(0, Health - 1);
            Console.WriteLine("An hour has passed. Hunger increased, and happiness and health decreased slightly.");
        }