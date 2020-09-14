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

   

    struct Items
    {
        public int statBoost;
    }


    class Game
    {
        bool _gameOver = false;

        Player _player1 = new Player("Karen", 177, 013);
        Player _player2 = new Player("Bob", 420, 69);
        Items longSword;
        Items dagger;


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

        public void Continue()
        {
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        //public void InitializePlayers()
        //{
        //    _player1.health = 100;
        //    _player1.damage = 5;

        //    _player2.health = 100;
        //    _player2.damage = 5;
        //}

        public void InitializeItems()
        {
            longSword.statBoost = 15;
            dagger.statBoost = 10;
        }

        public void PrintStats(Player player)
        {
            Console.WriteLine("Health: " + player.health);
            Console.WriteLine("Damage: " + player.damage);
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

        }

        public void EquipItems()
        {
            char input;

            //player 1
            GetInput(out input, "Long Sword", "Dagger", "Welcome! Player one CHOOSE YOUR WEAPON!");

            if (input == '1')
            {
                _player1.damage += longSword.statBoost;
            }
            if (input == '2')
            {
                _player1.damage += dagger.statBoost;
            }
            Console.WriteLine("\nPlayer One.");
            PrintStats(_player1);

            //player 2
            GetInput(out input, "Long Sword", "Dagger", "\nWelcome! Player two CHOOSE YOUR WEAPON!");

            if (input == '1')
            {
                _player2.damage += longSword.statBoost;
            }
            if (input == '2')
            {
                _player2.damage += dagger.statBoost;
            }

            Console.WriteLine("\nPlayer two.");
            PrintStats(_player2);

            Continue();
        }


        public void StartBattle()
        {
            Console.WriteLine("Now......GO! FIGHT TO THE DEATH!");

            while(_player1.health > 0 &&  _player2.health > 0)
            {
                //prints player one and two's stat
                Console.WriteLine("Player one");
                PrintStats(_player1);
                Console.WriteLine("Player two");
                PrintStats(_player2);

                char input;

                //Player One
                GetInput(out input, "Attack", "Peace", "\nPlayer one! What do you wish to do?");

                if(input == '1')
                {
                    _player2.health -= _player1.damage;
                    Console.WriteLine("\nPlayer one dealt " + _player1.damage + " damage to Player two!");
                }
                if(input == '2')
                {
                    Console.WriteLine("\nPlayer one went with a peaceful option! Hopefully Player two feels the same!");

                }

                Continue();

                //Player Two
                GetInput(out input, "Attack", "Peace", "Player two! What do you wish to do?");

                if (input == '1')
                {
                    _player1.health -= _player2.damage;
                    Console.WriteLine("\nPlayer two dealt " + _player2.damage + " damage to Player one!");
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer two went with a peaceful option! Hopefully Player one feels the same!");

                }

                Continue();
            }

            if(_player1.health > 0)
            {
                Console.WriteLine("WINNER! PLAYER ONE!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("WINNER! PLAYER TWO!!!!!!!!!!!!");
            }
            _gameOver = true;
        }



        //Performed once when the game begins
        public void Start()
        {
            //InitializePlayers();
            InitializeItems();
        }

        //Repeated until the game ends
        public void Update()
        {
            EquipItems();
            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}
