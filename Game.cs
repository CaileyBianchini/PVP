﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    //Cailey B.

    //this is van templete but i had to redo it and chose the wrong templete so i copied and pasted
    //create a turn based text rpg PVP
    //must loop till player is dead
    //upgrade their stats as structs

    struct Player
    {
        // public string name1; do later
        public int health;
        public int damage;

    }


    struct Items
    {
        public int statBoost;



    }


    class Game
    {
        bool _gameOver = false;

        Player _player1;
        Player _player2;
        Items longSword;
        Items dagger;


        //Run the game
        public void Run()
        {

            Start();

            while (_gameOver == false) ;
            {
                Update();
            }
            End();
        }

        public void InitializePlayers()
        {
            _player1.health = 100;
            _player1.damage = 5;

            _player2.health = 100;
            _player2.damage = 5;
        }

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

            //player 2
            GetInput(out input, "Long Sword", "Dagger", "Welcome! Player two CHOOSE YOUR WEAPON!");

            if (input == '1')
            {
                _player2.damage += longSword.statBoost;
            }
            if (input == '2')
            {
                _player2.damage += dagger.statBoost;
            }


        }

        //Performed once when the game begins
        public void Start()
        {
            InitializePlayers();
            InitializeItems();
        }

        //Repeated until the game ends
        public void Update()
        {

        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}
