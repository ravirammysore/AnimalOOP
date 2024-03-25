namespace MyApplication.Animals;

public class Dog(string name) : Animal(name)
{
    public override void Climb()
    {
        Console.WriteLine($"{Name} is climbing on steps!");
    }
}
