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
        private Items _mace;
        private Items _hammer;

        //roles


        //companions
        private Character _player1partner;
        private Character _player2partner;

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
            _longSword.statName = "Long Sword";
            _dagger.statBoost = 10;
            _dagger.statName = "Dagger";
            _ax.statBoost = 13;
            _ax.statName = "Ax";
            _staff.statBoost = 14;
            _staff.statName = "Staff";
            _mace.statBoost = 17;
            _mace.statName = "Mace";
            _hammer.statBoost = 9;
            _hammer.statName = "Hammer";
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


        public void GetInput(out char input, string option1, string option2, string option3, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
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

        public void SelectLoadout(Player player)
        {
            Console.Clear();
            Console.WriteLine("Loadout 1:");
            Console.WriteLine(_longSword.statName);
            Console.WriteLine(_dagger.statName);
            Console.WriteLine(_ax.statName);

            Console.WriteLine("\nLoadout 2:");
            Console.WriteLine(_staff.statName);
            Console.WriteLine(_mace.statName);
            Console.WriteLine(_hammer.statName);

            char input;
            GetInput(out input, "Loadout 1", "Loadout 2", "Welcome! CHOOSE YOUR WEAPON!");

            if (input == '1')
            {
                player.AddItemToInventory(_longSword, 0);
                player.AddItemToInventory(_dagger, 1);
                player.AddItemToInventory(_ax, 2);
            }
            if (input == '2')
            {
                player.AddItemToInventory(_staff, 0);
                player.AddItemToInventory(_mace, 1);
                player.AddItemToInventory(_hammer, 2);
            }
        }

        //Role
        public void SelectRoles(Player player)
        {
            

        }

        //Name
        public Player CreateCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player player = new Player(name, 100, 10, 3);
            //SelectItems(player);
            SelectLoadout(player);
            SelectRoles(player);
            return player;
        }

        public void SwitchWeapons(Player player)
        {
            Items[] inventory = player.GetInventory();

            char input = ' ';
            //utilize Length, one more entry then what is actually in the array
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + inventory[i].statName + "\n Damage: " + inventory[i].statBoost);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        player.EquipItem(0);
                        Console.WriteLine("\nYou equiped " + player.GetInventory()[0].statName);
                        Console.WriteLine("Main damage increased by " + player.GetInventory()[0].statBoost);
                        break;
                    }
                case '2':
                    {
                        player.EquipItem(1);
                        Console.WriteLine("\nYou equiped " + player.GetInventory()[1].statName);
                        Console.WriteLine("Main damage increased by " + player.GetInventory()[1].statBoost);
                        break;
                    }
                case '3':
                    {
                        player.EquipItem(2);
                        Console.WriteLine("\nYou equiped " + player.GetInventory()[2].statName);
                        Console.WriteLine("Main damage increased by " + player.GetInventory()[2].statBoost);
                        break;
                    }
                default:
                    {
                        player.UnequipItem();
                        Console.WriteLine("You accidently dropped your weapon! \nHow unfortunate!");
                        break;
                    }
            }
        }


        public void StartBattle()
        {
            Console.WriteLine("FIGHT TILL ONE DIES!!!!!!");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i+1) + ". ");
            }
            Console.WriteLine("Go!");

            while (_player1.GetIsAlive() && _player2.GetIsAlive())
            {
                //prints player one and two's stat
                Console.WriteLine("Player one");
                _player1.PrintStats();
                Console.WriteLine("Player two");
                _player2.PrintStats();

                char input;

                //Player One
                GetInput(out input, "Attack", "Peace", "Open Invatory", "\nPlayer one! What do you wish to do?");

                if (input == '1')
                {
                    _player2.Attack(_player1);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer one went with a peaceful option! Hopefully Player two feels the same!");

                }
                if(input == '3')
                {
                    SwitchWeapons(_player1);
                }

                Continue();

                //Player Two
                GetInput(out input, "Attack", "Peace", "Open Inventory", "Player two! What do you wish to do?");

                if (input == '1')
                {
                    _player1.Attack(_player2);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer two went with a peaceful option! Hopefully Player one feels the same!");

                }
                if (input == '3')
                {
                    SwitchWeapons(_player2);
                }


                Continue();
            }

            //implenting highscore




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
            _player1partner = new Wizard(128, 20, 100, "Wizard Lizard");
            _player2partner = new Wizard(120, 20, 100, "Hary Wizard101"); // remember this!!!
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
            Console.WriteLine("Press [Enter] to close game.");
            Console.ReadKey();
        }
    }
}
