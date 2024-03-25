namespace MyApplication.Animals;

public class Eagle(string name) : Bird(name)
{
    public override void Climb()
    {
        Console.WriteLine($"{Name} is climbing a tower...");
    }
}
