namespace Task_13_02
{
    internal class Pet
    {
        static void Main(string[] args)
        {
            //создать класс питомца
            //свойства:
            //кличка, вид животного, возраст, вес, отметка о состонии здоровья(здоров / нездоров)
            //методы:
            //вывод информации об объекте
            //изменение значения веса животного
            //изменение отметки о состоянии здоровья
            //конструторы:
            // предусмотрите разные варианты инициализации объектов
        }
            // Свойства
            public string Nickname { get; set; }
            public string AnimalType { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public string HealthStatus { get; set; }
            // Конструктор
            public Pet()
            {
                Nickname = "Максик";
                AnimalType = "Кот";
                Age = 2;
                Weight = 3;
                HealthStatus = "Здоров";
            }
            // Конструктор с параметрами
            public Pet(string nickname, string animalType, int age, double weight, string healthStatus)
            {
                Nickname = nickname;
                AnimalType = animalType;
                Age = age;
                Weight = weight;
                HealthStatus = healthStatus;
            }
            // Методы
            public void DisplayInfo()
            {
                Console.WriteLine($"Кличка: {Nickname}");
                Console.WriteLine($"Вид животного: {AnimalType}");
                Console.WriteLine($"Возраст: {Age} лет");
                Console.WriteLine($"Вес: {Weight} кг");
                Console.WriteLine($"Состояние здоровья: {HealthStatus}");
            }
            public void ChangeWeight(double newWeight)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес питомца изменён на: {Weight} кг");
            }
            public void ChangeHealthStatus(string newStatus)
            {
                HealthStatus = newStatus;
                Console.WriteLine($"Состояние здоровья изменено на: {HealthStatus}");
            }
        }
    }