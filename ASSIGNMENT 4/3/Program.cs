using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=20,y=35;
            x=y++ + x++;
            y=++y + ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
