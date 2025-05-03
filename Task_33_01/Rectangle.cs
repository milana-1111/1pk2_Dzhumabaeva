using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;
internal class Rectangle : IDrawable
{
    private int height;
    public int Height
    {
        get => height;
        set
        {
            if (value < 1)
                throw new ArgumentException("высота не должна быть меньше или равна 1");
            else
                height = value;
        }
    }
    public Rectangle(int height)
    {
        Height = height;
    }

    public void Draw()
    {
        Console.WriteLine();
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}