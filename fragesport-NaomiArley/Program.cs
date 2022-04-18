using System;

namespace fragesport_NaomiArley
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();

            string welcome = @"
 ___________________________________/\\\\\\___________________________________________________________________        
 __________________________________\////\\\___________________________________________________________________       
  _____________________________________\/\\\___________________________________________________________________      
   __/\\____/\\___/\\_____/\\\\\\\\_____\/\\\________/\\\\\\\\_____/\\\\\_______/\\\\\__/\\\\\_______/\\\\\\\\__     
    _\/\\\__/\\\\_/\\\___/\\\/////\\\____\/\\\______/\\\//////____/\\\///\\\___/\\\///\\\\\///\\\___/\\\/////\\\_    
     _\//\\\/\\\\\/\\\___/\\\\\\\\\\\_____\/\\\_____/\\\__________/\\\__\//\\\_\/\\\_\//\\\__\/\\\__/\\\\\\\\\\\__   
      __\//\\\\\/\\\\\___\//\\///////______\/\\\____\//\\\________\//\\\__/\\\__\/\\\__\/\\\__\/\\\_\//\\///////___  
       ___\//\\\\//\\\_____\//\\\\\\\\\\__/\\\\\\\\\__\///\\\\\\\\__\///\\\\\/___\/\\\__\/\\\__\/\\\__\//\\\\\\\\\\_ 
        ____\///__\///_______\//////////__\/////////_____\////////_____\/////_____\///___\///___\///____\//////////__                                                                                                                                                                                                         
            ";

            string abc = @"
 __                            _     _     __
(_     _  __ _    __  _  _|   |_| / |_) / /  
__)\_/(_| | (_|   |||(/_(_|   | |/  |_)/  \__                                    
            ";
            Console.WriteLine(welcome);
            Console.WriteLine("Frågesport om geografi! (5 frågor) ");
            Console.WriteLine("_________________________________________________________________________________________");
            int poäng;
            int round = 0;
            while (true)
            {
                round++;  //räknar antal runder som användaren kör
                poäng = 0; //ställer poäng antal till 0 i början av varje ny rundaa
                Console.WriteLine($" Rond {round}! ");
                while (true) //gör så att samma fråga spelas om varje gång användaren svarar med något som inte är a/b/c
                {
                    Console.WriteLine($"Vad är Spaniens huvudstad?");
                    Console.WriteLine("A -- Barcelona");
                    Console.WriteLine("B -- Malaga");
                    Console.WriteLine("C -- Madrid");
                    string spanien = Console.ReadLine().ToLower();
                    if (spanien == "c")
                    {
                        poäng++; //adderar poäng till int variabeln om man har svarrt rätt
                        Console.WriteLine("Rätt");
                    }
                    if (spanien == "a" || spanien == "b" || spanien == "c")
                    {
                        break; //bryter while loopen om svaret är tillåten
                    }
                    else
                    {
                        Console.WriteLine(abc); //skriver ut lite fint ascii art
                    }
                }
                while (true)
                {
                    Console.WriteLine("Vad är Stor Britanniens huvudstad?");
                    Console.WriteLine("A -- London");
                    Console.WriteLine("B -- Manchester");
                    Console.WriteLine("C -- Birmingham");
                    string uk = Console.ReadLine().ToLower();
                    if (uk == "a")
                    {
                        Console.WriteLine("Rätt");
                        poäng++; 
                    }
                    if (uk == "a" || uk == "b" || uk == "c")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(abc);
                    }
                }
                while (true)
                {
                    Console.WriteLine("Vad är USAs huvustad?");
                    Console.WriteLine("A -- California");
                    Console.WriteLine("B -- New York");
                    Console.WriteLine("C -- Washington DC");
                    string usa = Console.ReadLine().ToLower();
                    if (usa == "c")
                    {
                        Console.WriteLine("Rätt");
                        poäng++;
                    }
                    if (usa == "a" || usa == "b" || usa == "c")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(abc);
                    }
                }
                while (true)
                {
                    Console.WriteLine("Vad är Tysklands huvustad?");
                    Console.WriteLine("A -- Francfort");
                    Console.WriteLine("B -- Hamburg");
                    Console.WriteLine("C -- Berlin");
                    string tyskland = Console.ReadLine().ToLower();
                    if (tyskland == "c")
                    {
                        Console.WriteLine("Rätt");
                        poäng++;
                    }
                    if (tyskland == "a" || tyskland == "b" || tyskland == "c")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(abc);
                    }
                }
                while (true)
                {
                    Console.WriteLine("Vad är polens huvustad?");
                    Console.WriteLine("A -- Gdansk");
                    Console.WriteLine("B -- Warzaw");
                    Console.WriteLine("C -- Wroclaw");
                    string polen = Console.ReadLine().ToLower();
                    if (polen == "b")
                    {
                        Console.WriteLine("Rätt");
                        poäng++;
                    }
                    if (polen == "a" || polen == "b" || polen == "c")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(abc);
                    }
                }
                Console.WriteLine("Vill du testa igen? (j/n)"); //frågar användaren om hen vill köra igen programmet
                string spela = Console.ReadLine();
                if (spela == "n")
                {
                    break; //om svaret är nej så avbryts hela while loopen
                }
                
            }//skriver ut ascii art beroende på antal poäng användaren har fått 
            Console.WriteLine($"Du fick {poäng} poäng!");
            if (poäng < 3)
            {
                string lose = @"
                     __
                w  c(..)o   (      Monkey
                 \__(-)    __)            Brain
                     /\   (
                    /(_)___)
                   w /|
                    | \
                   m  m";
                Console.WriteLine(lose); 
            }
            if (poäng >= 2)
            {
                string frog = @"
           .--._.--.
          ( O     O )
          /   . .   \
         .`._______.'.
        /(           )\     B  R  A
      _/  \  \   /  /  \_
   .~   `  \  \ /  /  '   ~.
  {    -.   \  V  /   .-    }
_ _`.    \  |  |  |  /    .'_ _
>_       _} |  |  | {_       _<
 /. - ~ ,_-'  .^.  `-_, ~ - .\
         '-'|/   \|`-`
         
         ";
                
                Console.WriteLine(frog);
            }
        }
    }
}
