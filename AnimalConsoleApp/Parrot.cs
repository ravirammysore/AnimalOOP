namespace MyApplication.Animals;

public class Parrot(string name) : Bird(name), ISingable
{    
    public override void Climb()
    {
        Console.WriteLine($"{Name} is climbing on a tree!");
    }

    public void Sing()
    {
        Console.WriteLine($"{Name} is singing...");
    }
}
