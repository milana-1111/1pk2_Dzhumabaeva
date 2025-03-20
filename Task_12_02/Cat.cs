namespace Task_12_02
{
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
}
