﻿namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<object> encounters = new List<object>
        {
            new Hare(),
            new Wolf(),
            new Bear(),
            new Fox(),
            new Rock(),
            new Mud(),
        };

            foreach (var encounter in encounters)
            {
                if (!kolobok.IsAlive) break;

                kolobok.Roll();

                if (encounter is Animal animal)
                {
                    kolobok.MeetAnimal(animal);
                }
                else if (encounter is Obstacle obstacle)
                {
                    kolobok.MeetObstacle(obstacle);
                }

                // Восстановление скорости после препятствия (опционально)
                if (encounter is Obstacle)
                {
                    kolobok.RestoreSpeed();
                }
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}