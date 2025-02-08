using AnimalHierarchy;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        Console.WriteLine($"{dog.name} have age {dog.age} year");
        dog.MakeSound();

        Cat cat = new Cat();

        Console.WriteLine($"{cat.name} have age {cat.age} year");
        cat.MakeSound();

        Bird bird = new Bird();
        Console.WriteLine($"{bird.name} have the age {bird.age} year");

        bird.MakeSound();
    }
}