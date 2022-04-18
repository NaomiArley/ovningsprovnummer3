using System;
using Raylib_cs;

namespace dodgers
{
    class Program
    {
        static int fönsterB = 800;
        static int fönsterH = 600;

        static Random generator = new Random();
        static Rectangle mynt1 = new Rectangle(400, 0, 50, 50);
        static Rectangle mynt2 = new Rectangle(200, -500, 50, 50);
        static Rectangle monster = new Rectangle(300, -1000, 50, 50);
        static Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);

        static int poäng = 0;
        static int liv = 3;
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------


            Raylib.InitWindow(fönsterB, fönsterH, "dodgers");
            Raylib.SetTargetFPS(60);
            // TODO: Infoga variabler och objekt här
            //gamestate variabler
            int hastighet = 2;
            float tid = 0;




            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                tid += Raylib.GetFrameTime();
                if (tid >= 10)
                {
                    hastighet = 4;
                }
                // Updatering
                //räkna upp tiden
                //hastigheter och nedre gräns
                hastigheter(hastighet);

                //lyssna på tangenten
                Input();

                //collission detection
                kollisioner();

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(mynt1, Color.GOLD);
                Raylib.DrawRectangleRec(mynt2, Color.GOLD);
                Raylib.DrawRectangleRec(monster, Color.RED);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);

                Raylib.DrawText($"Poäng:{poäng}    Liv:{liv}   Tid:{(int)tid}", 10, 10, 20, Color.WHITE);


                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------

            }
        }
        static void Input()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                if (spelare.x < fönsterB - 100)
                {
                    spelare.x += 4;

                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                if (spelare.x > 0)
                {
                    spelare.x -= 4;
                }
            }
        }
        static void hastigheter(int hastighet)
        {
            mynt1.y += hastighet;
            if (mynt1.y > fönsterH)
            {
                mynt1.y = -100;
                mynt1.x = generator.Next(0, fönsterB);
            }
            mynt2.y += hastighet;
            if (mynt2.y > fönsterH)
            {
                mynt2.y = -100;
                mynt2.x = generator.Next(0, fönsterB);
            }
            monster.y += hastighet;
            if (monster.y > fönsterH)
            {
                monster.y = -100;
                monster.x = generator.Next(0, fönsterB);
            }
        }
        static void kollisioner()
        {
            if (Raylib.CheckCollisionRecs(spelare, mynt1))
            {
                mynt1.y = 0;
                mynt1.x = generator.Next(0, fönsterB - 50);
                poäng += 1;
            }
            if (Raylib.CheckCollisionRecs(spelare, mynt2))
            {
                mynt2.y = 0;
                mynt2.x = generator.Next(0, fönsterB - 50);
                poäng += 1;
            }
            if (Raylib.CheckCollisionRecs(spelare, monster))
            {
                monster.y = 0;
                monster.x = generator.Next(0, fönsterB);
                liv -= 1;
            }
        }
    }

}