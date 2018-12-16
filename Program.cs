using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will show you difference\n",
            "between reading two-dimentional array\n",
            "by rows and columns.",
            "In the end you can look at optimized variant of reading array");
            int width = 0;
            int height = 0;
            while(true)
            {
                Menu();
                int variant = 0;
                while(!int.TryParse(Console.ReadLine(), out variant));
                switch(variant)
                {
                    case 0:
                    return;
                    case 1:
                    GetSize(ref width, ref height);
                    Arrays arrays1 = new Arrays(width, height);
                    unsafe { Console.WriteLine(arrays1.Optimal()); }
                    break;
                    case 2:
                    GetSize(ref width, ref height);
                    Arrays arrays2 = new Arrays(width, height);
                    Console.WriteLine(arrays2.ByRows());
                    break;
                    case 3:
                    GetSize(ref width, ref height);
                    Arrays arrays3 = new Arrays(width, height);
                    Console.WriteLine(arrays3.ByColumns());
                    break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("Input variant:");
            Console.WriteLine("0 Quit");
            Console.WriteLine("1 Use fastest variant");
            Console.WriteLine("2 Use reading by rows");
            Console.WriteLine("3 Use reading by columns");
        }
        static void GetSize(ref int width, ref int height)
        {
            width = 0;
            height = 0;
            Console.WriteLine("Input Width");
            while(!int.TryParse(Console.ReadLine(), out width));
            Console.WriteLine("Input Height");
            while(!int.TryParse(Console.ReadLine(), out height));
        }
    }
}
