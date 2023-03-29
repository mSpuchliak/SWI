using System;

namespace SWI
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
    public class Square
    {
        public int Sides { get; set; }
    }
    class LSP
    {
        static public void Main(String[] args)
        {
            var rect = new Rectangle{Height=4,Width=6};
            var square = new Square{Sides=3};
    
            Console.WriteLine("Rectangle area: " + rect.Height * rect.Width);
            Console.WriteLine("Square area: " + square.Sides * square.Sides);
        }
    }
}