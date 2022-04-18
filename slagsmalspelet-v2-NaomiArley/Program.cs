using System;

namespace slagsmalspelet_v2_NaomiArley
{
    class Program
    {
        static void Main(string[] args)
        {
            //tärning
            Random generator = new Random();

            Console.Clear();
            Console.WriteLine("Detta är ett slagmålspel");
            //matar in namnet på hjälten 
            Console.WriteLine("Vad heter hjälten ");
            string hjälte = Console.ReadLine().ToUpper();
            //kontrollerar så att namnet inte är kort eller för lång isåfall fråga igen
            while (hjälte.Length < 2 || hjälte.Length > 8)
            {
                Console.WriteLine("Vad heter hjälten (välj ett namn mellan 2 och 9 bokstäver)");
                hjälte = Console.ReadLine().ToUpper();
            }
            //genererar en slump tal


            int randomname = generator.Next(0, 3);
            //SLumpar fram fiendens namn (3 förslag)    
            string[] fiendeNamn = { "Juan", "Camilo", "Maria" };
            string fiende = fiendeNamn[randomname];

            Console.WriteLine($"Din fiende heter: {fiende}");

            Console.WriteLine("________________________________________________________");

            while (true)
            {

                //Gamestate för våra spelare
                int hjälteHP = 100;
                int fiendeHP = 100;

                while (hjälteHP > 0 && fiendeHP > 0)
                {

                    //slumpa fram ett slag
                    int slag = generator.Next(1, 17);//svag men träffar varje slag 
                    int slag2 = generator.Next(25, 51);//stark men mindre chans
                    int fiendeslag = generator.Next(5, 17);
                    int hitormiss = generator.Next(0, 11);

                   

                    int attack = 0;
                    bool korrekt = false;

                    while (korrekt != true)
                    {
                        Console.WriteLine("Vilken attack vill du göra? (Svara endast med 1-2) ");
                        Console.WriteLine("1: Stor skada mindre chans att träffa");
                        Console.WriteLine("2: Mindre skada men stor chans att träffa");
                       string  attackstring = Console.ReadLine();
                        Console.WriteLine("________________________________________________________");
                        korrekt = int.TryParse(attackstring, out attack);

                    //strong attack 60% chans att träffa
                    if (attack ==2)
                    {

                        fiendeHP -= slag;
                        hjälteHP -= fiendeslag;
                        Console.WriteLine($"{hjälte} har nu {hjälteHP} HP");
                        Console.WriteLine($"{fiende} har nu {fiendeHP} HP");
 
                    }
                    else if (attack == 1 && hitormiss < 7)
                    {
                        //slaget
                        Console.WriteLine("HIT!");
                        fiendeHP -= slag2;
                        hjälteHP -= fiendeslag;
                        Console.WriteLine($"{hjälte} har nu {hjälteHP} HP");
                        Console.WriteLine($"{fiende} har nu {fiendeHP} HP");

                    }
                    else if (attack == 1 && hitormiss !< 7)
                    {
                        Console.WriteLine("MISS");
                         hjälteHP -= fiendeslag;
                        Console.WriteLine($"{hjälte} har nu {hjälteHP} HP");
                        
                       
                    }
                    }






                    //pausar mellan varje slag

                    Console.WriteLine("Tryck på ENTER för att forsätta");
                    Console.WriteLine("________________________________________________________");
                    Console.ReadKey();

                }

                if (fiendeHP < 0 && hjälteHP < 0)
                {

                    Console.WriteLine("matchen oavgjord!");

                }
                else if (fiendeHP < hjälteHP && fiendeHP < 0)
                {
                    Console.WriteLine($"{hjälte} mördade {fiende}");

                }
                else if (fiendeHP > hjälteHP && hjälteHP < 0)
                {
                    Console.WriteLine($"{fiende} mördade {hjälte}");

                }
                else
                {
                    Console.WriteLine("matchen oavgjord!");

                }

                Console.WriteLine("vILL DU SPELA IGEN?(j/n)");
                string spelaOM = Console.ReadLine();

                while (spelaOM != "j" || spelaOM != "n")
                {

                    Console.WriteLine("vILL DU SPELA IGEN?(j/n)");
                    spelaOM = Console.ReadLine();
                    if (spelaOM == "n" || spelaOM == "j")
                    {
                        break;
                    }
                }
                if (spelaOM == "n")
                {
                    break;
                }




            }
        }
    }
}

