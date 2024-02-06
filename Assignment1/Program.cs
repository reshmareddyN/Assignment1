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
    public void DisplayStats()
    {
        Console.WriteLine($"Pet Stats - Hunger: {Hunger}/10, Happiness: {Happiness}/10, Health: {Health}/10");
    }