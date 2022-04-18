using System;

namespace övning3_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
      /*       //använda metoden-
            Print32();
            //använd metod 2
            PrintText32("Hej världen!");

            // använd metod 3
            Console.WriteLine("mata in ett tal 5-10");
            string stringTal  = Console.ReadLine();
            int tal = läsInHeltal(stringTal);

            //använd metod 3 igen
            Console.WriteLine("mata in ett tal 5-10");
            int tal2 = läsInHeltal(Console.ReadLine()); */

            // en metod som returnerar True om användaren matar in ett heltal annars False.
            Console.WriteLine("mata in ett heltal");
            int heltal = HeltalTrueOrFalse(Console.ReadLine());
            
}
//Skapa en metod som returnerar True om användaren matar in ett heltal annars False.
static int  HeltalTrueOrFalse(string Heltal)
{
    int heltal = 0;
    while (!int.TryParse(Heltal, out heltal))
    {
        Console.WriteLine("false");
        Heltal = Console.ReadLine();
        
    }
    Console.WriteLine("true");
    return heltal;
}


        //skapar en metod som, när den anropas skriver ut "Hello World!" 32 gånger
        static void Print32()
        {
            string text = "Hello World!";
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine($"{text} - {i}");

            }
        }
        static void PrintText32(string texten)
        {
             texten = Console.ReadLine();
            
            }
        static int läsInHeltal(string stringTal)
        {
            int tal= 0;
            while (!int.TryParse(stringTal, out tal))
            {
                Console.WriteLine("Du måste mata in ett heltal. VG försök igen");
                stringTal = Console.ReadLine();
                
            }
            return tal;
        }
    }
}
