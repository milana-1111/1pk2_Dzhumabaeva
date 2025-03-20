namespace Task_12_02
{
    //создайте проект с классом Cat и Dog, полностью самостоятельно продумайте данные для объектовклассаиихфункционал
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
}
