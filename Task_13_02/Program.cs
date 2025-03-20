namespace Task_13_02
{

    class Program
        {
            static void Main(string[] args)
            {
                Pet pet1 = new Pet();
                pet1.DisplayInfo();
                Console.WriteLine();
                Pet pet2 = new Pet("Барсик", "Кот", 3, 4.5, "Болен");
                pet2.DisplayInfo();
                Console.WriteLine();
                pet2.ChangeWeight(5.0);
                pet2.ChangeHealthStatus("Здоров");
                Console.WriteLine();
                pet2.DisplayInfo();
            }
        }
    }