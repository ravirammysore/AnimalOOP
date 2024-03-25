namespace MyApplication.Animals;

public abstract class Animal(string name)
{
    public string Name { get; } = name;

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating...");
    }

    public abstract void Climb();
}
