namespace Task_20_06
{

    class Program
    {
        private static TrafficLightColor currentColor = TrafficLightColor.Red;
        private static readonly object lockObj = new object();
        private static bool isRunning = true;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Светофор запущен. Нажмите любую клавишу для ручного переключения цвета.");

            var automaticSwitchingTask = Task.Run(() => AutomaticSwitching());// Запуск автоматического переключения

            // Ожидание ручного переключения
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true); // Чтение нажатой клавиши
                    ManualSwitching();
                }
            }

            await automaticSwitchingTask;
        }

        private static async Task AutomaticSwitching()
        {
            while (isRunning)
            {
                await Task.Delay(3000); // Задержка 3 c
                SwitchColor();
            }
        }
        private static void ManualSwitching()
        {
            Console.WriteLine("Ручное переключение цвета:");
            SwitchColor();
        }
        private static void SwitchColor()
        {
            lock (lockObj)
            {
                currentColor = currentColor switch
                {
                    TrafficLightColor.Red => TrafficLightColor.Green,
                    TrafficLightColor.Green => TrafficLightColor.Yellow,
                    TrafficLightColor.Yellow => TrafficLightColor.Red,
                    _ => currentColor
                };

                Console.WriteLine($"Текущий цвет светофора: {currentColor}");
            }
        }
    }
}

