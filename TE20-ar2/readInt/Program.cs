using System;

namespace readInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tal1 = ReadInt();

            Console.WriteLine("tal2");
            int tal2 = ReadInt();

        }
        static int ReadInt()
        {
            int heltal;
            while (int.TryParse(Console.ReadLine(), out heltal) == false)
            {
                Console.WriteLine("false");
            }
            return heltal;
        }
    }
}
