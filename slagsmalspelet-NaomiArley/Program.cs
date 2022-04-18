using System;

namespace slagsmalspelet_NaomiArley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett slagmålspel");
            Console.WriteLine("Vad heter hjälten ");
            string hjälte = Console.ReadLine().ToUpper();
            Console.WriteLine("Vad heter fienden ");
            string fiende = Console.ReadLine().ToUpper();

            //Gamestate för våra spelare
            int hjälteHP = 100;
            int fiendeHP = 100;

            while (hjälteHP > 0 && fiendeHP > 0)
            {
                //skapa ett slumptalsgenerator
                Random generator = new Random();
                //slumpa fram ett slag
                int slag = generator.Next(1, 21);
                int slag2 = generator.Next(1, 21);


                //slaget
                hjälteHP -= slag;
                Console.WriteLine($"{hjälte} har nu {hjälteHP} HP");
                fiendeHP -= slag2;
                Console.WriteLine($"{fiende} har nu {fiendeHP} HP");


                //pausar mellan varje slag

                Console.WriteLine("Tryck på ENTER för att forsätta");
                Console.WriteLine("________________________________________________________");
                Console.ReadKey();


            }
            if (fiendeHP < 0 && hjälteHP < 0)
            {

                Console.WriteLine("matchen oavgjord!");
            }
            else if (fiendeHP < hjälteHP)
            {
                Console.WriteLine($"{hjälte} vann slagsmålet");
            }
            else if (fiendeHP > hjälteHP)
            {
                Console.WriteLine($"{fiende} vann slagsmålet");
            }
            else
            {
                Console.WriteLine("matchen oavgjord!");
            }




            /*I den här uppgiften ska du skapa en slagsmålssimulator med **två** inblandade slagskämpar
             * Simulatorn ska hålla reda på slagskämparnas **namn** och **hp**
             * Det ska finnas en **while-loop** som körs så länge båda slagskämparna har hp kvar
             * Varje gång loopen körs – varje “runda” – så ska slagskämpe A slå B, och B ska slå A
             * Ett slag innebär att motståndaren blir av med en **slumpmässig** mängd hp
             * När striden är slut, **presentera** vinnaren – eller om båda slagskämparna kom under 0 samtidigt, förklara att det blev **oavgjort**
             * Observera alltså att i denna grundversion av "spelet" så kan spelaren inte påverka något – hela processen är **automatisk**
             * När du är färdig kan du gå vidare och göra den uppgiften Slagsmålspelet v2
              */
        }
    }
}
