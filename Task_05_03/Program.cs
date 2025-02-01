namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Даны два массива, заполненные символами английского алфавита размером 3 * 3.Проверить, являются ли матрицы равными, если
            //да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            //элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
            //Пример:
            //            f h h f c h
            //w g k m g z
            //a f j a o d
            //=>
            //f h h f c h
            //w g k m g z
            //a f j a o d

            /*Вынесла повторяющиеся части кода в отдельные методы GenerateRandomMatrix, PrintMatrices PrintRow, AreMatricesEqual, PrintHighlightedDifferences, PrintHighlightedRow чтобы код был понятен*/
            char[,] namb1 = GenerateRandomMatrix();
            char[,] namb2 = GenerateRandomMatrix();
            PrintMatrices(namb1, namb2);
            Console.WriteLine("--------------");

            if (AreMatricesEqual(namb1, namb2)) /*Упростила проверку на равенство матриц с помощью AreMatricesEqual*/
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                PrintHighlightedDifferences(namb1, namb2);
            }
        }
        static char[,] GenerateRandomMatrix()
        {
            char[,] matrix = new char[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = (char)('a' + rnd.Next(0, 27)); // генерирую случайные символы от 'a' до 'z'
            return matrix;
        }
        static void PrintMatrices(char[,] m1, char[,] m2)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                PrintRow(m1, i);
                Console.Write("   ");
                PrintRow(m2, i);
                Console.WriteLine();
            }
        }
        static void PrintRow(char[,] matrix, int rowIndex)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[rowIndex, j] + " ");
        }
        static bool AreMatricesEqual(char[,] m1, char[,] m2)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
                for (int j = 0; j < m1.GetLength(1); j++)
                    if (m1[i, j] != m2[i, j]) return false;
            return true;
        }
        static void PrintHighlightedDifferences(char[,] m1, char[,] m2)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                PrintHighlightedRow(m1, m2, i);
                Console.Write("   ");
                PrintHighlightedRow(m2, m1, i);
                Console.WriteLine();
            }
        }
        static void PrintHighlightedRow(char[,] m1, char[,] m2, int rowIndex)
        {
            for (int j = 0; j < m1.GetLength(1); j++)
            {
                if (m1[rowIndex, j] == m2[rowIndex, j])
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                Console.Write(m1[rowIndex, j] + " ");
                Console.ResetColor(); // чтобы сбрасывать цвета после каждого элемента
            }

        }
    }
}
