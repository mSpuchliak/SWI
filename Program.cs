using System;

namespace SWI
{
    public abstract class Shape
    {
        public abstract int getArea();
    }
    public class Rectangle :Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int getArea()
        {
            return Height * Width;
        }
    }
    public class Square :Shape
    {
        public int Sides { get; set; }
        public override int getArea()
        {
            return Sides * Sides;
        }

    }
    class LSP
    {
        static public void Main(String[] args)
        {
            var rect = new Rectangle{Height=4,Width=6};
            var square = new Square{Sides=3};
    
            Console.WriteLine("Rectangle area: " + rect.getArea());
            Console.WriteLine("Square area: " + square.getArea());
        }
    }
}