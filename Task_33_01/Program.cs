using ConsoleApp3;
using System.Drawing;

namespace Task_33_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<IDrawable> list = new List<IDrawable>
                {
                       new Circle(5),
                       new Square(2,7),
                       new Circle(10),
                       new Rectangle(7),
                       new Circle(2),
                       new Rectangle(10)

                };


                foreach (var item in list)
                    item.Draw();

                list.Add(new Circle(0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}