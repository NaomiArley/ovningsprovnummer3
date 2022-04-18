using System;

namespace ovningInforProv
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Kolla att användaren matar in ett tal elelr inte
                Console.Write("Mata in ett tal 1-100 ");

                //ger alltid en string
                string stringTal = Console.ReadLine();

                //kolla om det går att omvandla från string till ett tal
                int tal = 0;
                //bool lyckadesParsa = int.TryParse(stringTal, out tal);

                if (int.TryParse(stringTal, out tal))
                {
                    Console.WriteLine("Ja, användaren matade ");
                    break;
                }
                else
                {
                    Console.WriteLine("Nej, användaren matade inte in etet tal");

                }
            }
        }
    }
}
