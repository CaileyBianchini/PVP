using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Items
    {
        public int statBoost;
        public string statName;
    }

    class Multiplayer
    {
        bool _gameOver = false;

        private Player _player1;
        private Player _player2;

        //weapons
        private Items _longSword;
        private Items _dagger;
        private Items _ax;
        private Items _staff;

        //roles
        private Items _hero;
        private Items _assassin;
        private Items _wizard;
        private Items _barbarian;



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
            Console.WriteLine("\nPress [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void InitializeItems()
        {
            _longSword.statBoost = 15;
            _dagger.statBoost = 10;
            _ax.statBoost = 13;
            _staff.statBoost = 14;
        }

        public void InitializeRole()
        {
            _hero.statBoost = 20;
            _hero.statName = "Hero";
            _assassin.statBoost = 13;
            _assassin.statName = "Assassin";
            _wizard.statBoost = 5;
            _wizard.statName = "Wizard";
            _barbarian.statBoost = 25;
            _barbarian.statName = "Barbarian";
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

        //Weapons
        public void SelectItems(Player player)
        {
            char input;
            GetInput(out input, "Long Sword", "Dagger", "Ax", "Staff", "Welcome! CHOOSE YOUR WEAPON!");

            if (input == '1')
            {
                player.EquipItem(_longSword);
            }
            if (input == '2')
            {
                player.EquipItem(_dagger);
            }
            if (input == '3')
            {
                player.EquipItem(_ax);
            }
            if (input == '4')
            {
                player.EquipItem(_staff);
            }

        }

        //Role
        public void SelectRoles(Player player)
        {
            char input;
            GetInput(out input, "Hero", "Assassin", "Wizard", "Barbarian", "CHOOSE YOUR CLASS!");

            if (input == '1')
            {
                player.EquipRole(_hero);
            }
            if (input == '2')
            {
                player.EquipRole(_assassin);
            }
            if (input == '3')
            {
                player.EquipRole(_wizard);
            }
            if (input == '4')
            {
                player.EquipRole(_barbarian);
            }

        }

        //Name
        public Player CreateCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player player = new Player(name, "Peasant", 100, 10);
            SelectItems(player);
            SelectRoles(player);
            return player;
        }




        public void StartBattle()
        {
            Console.WriteLine("Now......GO! FIGHT TO THE DEATH!");

            while (_player1.GetIsAlive() && _player2.GetIsAlive())
            {
                //prints player one and two's stat
                Console.WriteLine("Player one");
                _player1.PrintStats();
                Console.WriteLine("Player two");
                _player2.PrintStats();

                char input;

                //Player One
                GetInput(out input, "Attack", "Peace", "\nPlayer one! What do you wish to do?");

                if (input == '1')
                {
                    _player2.Attack(_player1);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer one went with a peaceful option! Hopefully Player two feels the same!");

                }

                Continue();

                //Player Two
                GetInput(out input, "Attack", "Peace", "Player two! What do you wish to do?");

                if (input == '1')
                {
                    _player1.Attack(_player2);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer two went with a peaceful option! Hopefully Player one feels the same!");

                }


                Continue();
            }

            if (_player1.GetIsAlive())
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
            InitializeRole();
        }

        //Repeated until the game ends
        public void Update()
        {
            _player1 = CreateCharacter();
            _player2 = CreateCharacter();
            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Battle Over!");
        }
    }
}
