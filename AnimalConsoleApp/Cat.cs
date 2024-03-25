namespace MyApplication.Animals;

public class Cat(string name) : Animal(name)
{  

    public override void Climb()
    {
        Console.WriteLine($"{Name} is climbing on a roof!");
    }
}
