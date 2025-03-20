using Task_12_02;

namespace Task_12_02
{
    class Animal
    {
        public string Name { get; set; }
        public int TailLength { get; set; }
        public int BodyLength { get; set; }
        public int Age { get; set; }

        public Animal(string name, int tailLength, int bodyLength, int age)
        {
            Name = name;
            TailLength = tailLength;
            BodyLength = bodyLength;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}\nДлина хвоста: {TailLength} см\nДлина тела: {BodyLength} см\nВозраст: {Age} лет");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int tailLength, int bodyLength, int age)
            : base(name, tailLength, bodyLength, age) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Информация о кошке:");
            base.DisplayInfo();
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int tailLength, int bodyLength, int age)
            : base(name, tailLength, bodyLength, age) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Информация о собаке:");
            base.DisplayInfo();
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Буся", 25, 60, 3);
        Dog dog = new Dog("Шарик", 10, 100, 5);

        cat.DisplayInfo();
        Console.WriteLine();
        dog.DisplayInfo();
    }
}
