public class Car
{
    // Свойства
    public string LicensePlate { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public double CurrentSpeed { get; set; }

    // Константа для максимальной скорости
    private const double MaxSpeed = 150;
    // Конструкторы
    public Car()
    {
        LicensePlate = "В888ВВ";
        Brand = "Mercedes";
        Color = "Розовый";
        CurrentSpeed = 120;
    }
    public Car(string licensePlate, string brand, string color, double currentSpeed)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Color = color;
        CurrentSpeed = currentSpeed;
    }
    //Методы
    public void Accelerate(double increment)
    {
        CurrentSpeed += increment;
        if (CurrentSpeed > MaxSpeed)
        {
            Console.WriteLine("Скорость превышает допустимую! Остановка автомобиля.");
            CurrentSpeed = 0; // Остановка автомобиля при превышении скорости
        }
        Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
    }
    public void Brake()
    {
        if (CurrentSpeed > 0)
        {
            Console.WriteLine("Автомобиль тормозит...");
            CurrentSpeed = 0; // Остановка автомобиля
            Console.WriteLine("Автомобиль остановлен.");
        }
        else
        {
            Console.WriteLine("Автомобиль уже остановлен.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Номер авто: {LicensePlate}");
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
    }
}
