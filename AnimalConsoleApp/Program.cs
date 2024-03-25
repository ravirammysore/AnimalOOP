
using MyApplication.Animals;

Animal[] animals = [
     new Eagle("Jack"),
     new Dog("Mike"),
     new Cat("Tom"),     
     new Parrot("Glory"),     
];

foreach (Animal animal in animals)
{
    Console.WriteLine($"{animal.Name} created!");

    animal.Eat();
    animal.Climb();    

    if(animal is Bird b)
      b.Fly();
    
    if(animal is ISingable s)
        s.Sing();
    Console.WriteLine();
}

