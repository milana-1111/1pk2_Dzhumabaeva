namespace Task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создайте класс автомобиля
            //ойства:
            //номер авто, марка, цвет, текущая скорость
            // методы:
            // езда(симитировать равномерное ускорение скорости автомобиля)
            // торможение(при превышении скорости автомобиля свыше допустимой - он должен остановиться)
            // конструторы
            // предусмотрите разные варианты инициализации объектов
            Car car1 = new Car();
            car1.DisplayInfo();
            Console.WriteLine();
            Car car2 = new Car("А123АА", "BMW", "Черный", 100);
            car2.DisplayInfo();
            Console.WriteLine();
            // Симуляция ускорения
            car2.Accelerate(30); // Увеличение на 30 км/ч
            car2.Accelerate(50); // Увеличение на 50 км/ч (должно привести к остановке)
            Console.WriteLine();
            // Торможение
            car2.Brake();
            Console.WriteLine();
            // Проверка текущей скорости после торможения
            car2.DisplayInfo();
        }
    }
}
