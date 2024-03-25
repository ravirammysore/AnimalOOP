namespace MyApplication.Animals;

public abstract class Bird(string name) : Animal(name)
{
    //we dont know how the climb actly looks
    public void Fly()
    {
        Console.WriteLine($"{Name} is Flying!");
    }
    
    //sing()
}
