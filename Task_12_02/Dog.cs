namespace Task_12_02
{
    internal class Dog : Animal
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
