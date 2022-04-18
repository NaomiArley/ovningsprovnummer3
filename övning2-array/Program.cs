using System;

namespace övning2
{
    class Program
    {
        static void Main(string[] args)
        {
           //skapa en string-arry med namnen på fem olika leksaker
           string[] leksaker = {"boll","racket", "docka","hopprep","pussel"};

           //skriv ut innehållet i arrayen
           //alternativ 1
           for (int i = 0; i < leksaker.Length; i++)
           {
               Console.WriteLine(leksaker[i]);
           }

           //alternativ 2
           foreach (var leksak in leksaker)
           {
               Console.WriteLine(leksak);
           }
        }
    }
}
