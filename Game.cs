using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    //Cailey B.

    //this is van templete but i had to redo it and chose the wrong templete so i copied and pasted
    //create a turn based text rpg PVP
    //must loop till player is dead
    //upgrade their stats as structs


    class Game
    {
        bool _gameOver = false;


        public void Continue()
        {
            Console.WriteLine("\nPress [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        // INPUTS

        public void GetInput(out char input, string option1, string option2, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }

        public void GetInput(out char input, string option1, string option2, string option3, string option4, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("4. " + option4);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }


        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
            }
            End();
        }


        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome to The Game!");
        }

        //Repeated until the game ends
        public void Update()
        {
            char input;
            GetInput(out input, "Single Player", "PvP", "Which style do you wish to play?");


            //choice 1 being skipped right now :(
            if (input == '1')
            {
                Single single = new Single();
                //Run the Game
                single.Run();
                //Wait before closing
                Console.ReadKey();
            }
            if (input == '2')
            {
                Multiplayer multiplayer = new Multiplayer();
                //Run the Game
                multiplayer.Run();
                //Wait before closing
                Console.ReadKey();
            }
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank You for playing!");
        }
    }
}
