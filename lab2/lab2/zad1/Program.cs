using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            list.Add(new Rectangle());
            list.Add(new Triangle());
            list.Add(new Circle());
            Console.WriteLine(list[0].Draw());
            Console.WriteLine(list[1].Draw());
            Console.WriteLine(list[2].Draw());
        }       
    }
}
