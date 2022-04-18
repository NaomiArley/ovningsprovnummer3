using System;
using Raylib_cs;

namespace vinterprojekt_NaomiArley
{
    class Program
    {
        static int fönsterB = 800;
        static int fönsterH = 450;
        static Random generator = new Random();
        static Rectangle spaceship = new Rectangle(50, 300, 30, 30);
        static Rectangle planet = new Rectangle(1, 1, 100, 100);

        static Rectangle[] asteroider = new Rectangle[10];
        static Rectangle bullet = new Rectangle(0, 0, 20, 15);
        static Rectangle bulletTemp;
        static bool shoot = false;
        static bool planetBool = false;
        static int poäng = 0;
        static int liv = 3;
        static int planetHastighet;

        static void Main(string[] args)
        {
            // Initialisering
            
            //--------------------------------------------------------------------------------------
            Raylib.InitWindow(fönsterB, fönsterH, "spaceinvaders");
            Raylib.SetTargetFPS(60);
            // TODO: Infoga variabler och objekt här
            int[] hastigheter = new int[10];
            //--------------------------------------------------------------------------------------
            //loopa igenom arrayen och fyll med asteroider
            for (int i = 0; i < asteroider.Length; i++)
            {
                asteroider[i] = new Rectangle(0, 0, 30, 30);
                asteroider[i].x = generator.Next(0, fönsterB) + fönsterB;
                asteroider[i].y = generator.Next(0, fönsterH);
            }
            //loopa igenom arrayen hastigheter och fyll i asteroider hastighet
            for (int i = 0; i < asteroider.Length; i++)
            {
                hastigheter[i] = generator.Next(1, 3);
            }
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                bulletTemp.y = spaceship.y;
                
                //loop för att varje asteroid ska ha olika hastigheter
                for (int i = 0; i < asteroider.Length; i++)
                {
                    asteroider[i].x -= hastigheter[i];
                    if (asteroider[i].x < 0)
                    {
                        asteroider[i].x = fönsterB;
                    }
                }
                
                Input(); //spelarens input 


                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

               if (liv != 0)
               {
               
                   
                    //collison detection
                
                Planet();
                   CollisionDetection();
              
                Shooting();

                Raylib.DrawRectangleRec(spaceship, Color.BLUE);
                Raylib.DrawText($"Score: {poäng}", 10,10,20,Color.WHITE);
                Raylib.DrawText($"Lives: {liv}", fönsterB-100,10,20,Color.WHITE);
               
                   

               }
                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
                static void Input()
                {
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                    {
                        if (spaceship.x < fönsterB - 10)
                        {
                            spaceship.x += 4;

                        }
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                    {
                        if (spaceship.x > 0)
                        {
                            spaceship.x -= 4;
                        }
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                    {
                        if (spaceship.x < fönsterB - 10)
                        {
                            spaceship.y -= 4;

                        }
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                    {
                        if (spaceship.x < fönsterB - 10)
                        {
                            spaceship.y += 4;

                        }
                    }
                }
                static void Shooting()
                {

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                    {
                        shoot = true;
                        bullet.y =  spaceship.y+10;
                        bullet.x =  spaceship.x;
    
                    }
                    if (shoot)
                    {
                        Raylib.DrawRectangleRec(bullet, Color.RED);
                        bullet.x += 5;

                    }
                }
                static void CollisionDetection()
                {
                for (int i = 0; i < asteroider.Length; i++)
                {
                    Raylib.DrawRectangleRec(asteroider[i], Color.WHITE);
                    if (bullet.y == fönsterB)
                    {
                        bullet.y = spaceship.y;
                        bullet.x = spaceship.x;
                        shoot = false;
                    }
                    if (Raylib.CheckCollisionRecs(asteroider[i], bullet))
                    {
                        asteroider[i].x = fönsterB + 200;
                        bullet.y = spaceship.y;
                        bullet.x = spaceship.x;
                        shoot = false;
                        poäng += 100;
                    }
                }
            }
            static void Planet(){
                

                    if (planet.y < fönsterH-100 && planet.y > 0 )
                    {
                    planetBool = true; 
                    
                    }
                if (liv != 0 && planetBool)
                {
                    Raylib.DrawRectangleRec(planet,Color.DARKBLUE);
                    
                      for (int i = 0; i < asteroider.Length; i++)
                {
                 if (Raylib.CheckCollisionRecs(asteroider[i], planet))
                 {
                      asteroider[i].x = fönsterB + 200;
                      liv-=1;
                 }
                 else if (planet.y < 2)
                 {                 
                   planetHastighet = 1;  
                 }           
                 else if ( planet.y > fönsterH-100)
                 {                  
                   planetHastighet = -1;  
                 } 
                 }
                    planet.y += planetHastighet; 
                }
                }
            }
        }
    }
}

