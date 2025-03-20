using Task_12_02;

namespace Task_12_02
{
}

internal class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        Cat cat = new Cat("Буся", 25, 60, 3);
        Dog dog = new Dog("Шарик", 10, 100, 5);

        cat.DisplayInfo();
        Console.WriteLine();
        dog.DisplayInfo();
    }
}
