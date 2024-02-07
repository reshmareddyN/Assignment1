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
        Health = 8;
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
        Hunger = Math.Max(0, Hunger - 1);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased, and health slightly increased.");
    }
    public void Play()
    {
        if (Hunger <= 3)
        {
            Happiness = Math.Min(10, Happiness + 2);
            Hunger = Math.Min(10, Hunger + 1);
            Console.WriteLine($"{Name} has played. Happiness increased, and hunger slightly increased.");
        }
        else
        {
            Console.WriteLine($"{Name} is too hungry to play. Please feed the pet first.");
        }
    }
    public void Rest()
    {
        Health = Math.Min(10, Health + 2);
        Happiness = Math.Max(0, Happiness - 1);
        Console.WriteLine($"{Name} has rested. Health improved, and happiness slightly decreased.");
    }
    public void TimePasses()
        {
            Hunger = Math.Min(10, Hunger - 1);
            Happiness = Math.Max(0, Happiness + 1);
            Health = Math.Max(0, Health + 1);
            //Console.WriteLine("An hour has passed. Hunger increased, and happiness and health decreased slightly.");
        }
        public void CheckStatus()
        {
            if (Hunger <= 2 || Happiness <= 2 || Health <= 2)
            {
                Console.WriteLine("Warning: Pet is in critical condition. Please take care of it!");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");

            Console.Write("Enter pet type (e.g., cat, dog, rabbit): ");
            string petType = Console.ReadLine();

            Console.Write("Enter pet name: ");
            string petName = Console.ReadLine();

            VirtualPet pet = new VirtualPet(petType, petName);
            pet.DisplayWelcomeMessage();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect an action:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check Status");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Rest();
                        break;
                    case "4":
                        pet.CheckStatus();
                        pet.DisplayStats();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                // Simulate the passage of time after each action
                pet.TimePasses();
                Thread.Sleep(1000); // Simulate the wait time for an hour
            }

            Console.WriteLine("Thank you for playing the Virtual Pet Simulator!");
        }
    }