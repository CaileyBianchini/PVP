using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Single
    {
        //void AfterAttack(int mana, float manaregen, float PlayerHealth, int tutorialbossattack, int rounds, float manarounds)
        //{
        //    mana = mana + (manaregen * manarounds);
        //    PlayerHealth = PlayerHealth + (tutorialbossattack * rounds);
        //}

        void PrintStats(int level, int charisma, float karma, int luck, float stealth, int defence, float mana, int playersattack, int specialattack, int goldcoins, int silvercoins, int coppercoins, string name, string role, string race, float PlayerHealth)
        {
            Console.WriteLine("Current level: " + level);
            Console.WriteLine("Hero role: " + role);
            Console.WriteLine("Race : " + race);
            Console.WriteLine("Health: " + PlayerHealth);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Attack: " + playersattack);
            Console.WriteLine("Special Attack: " + specialattack);
            Console.WriteLine("Stealth: " + stealth);
            //Console.WriteLine("Defence: " + defence);
            Console.WriteLine("Karma: " + karma);
            Console.WriteLine("Charisma: " + charisma);
            Console.WriteLine("Luck: " + luck);
            Console.WriteLine(goldcoins + " gold coins");
            Console.WriteLine(silvercoins + " silver coins");
            Console.WriteLine(coppercoins + " copper coins");
        }

        void AttackChoices(int rounds, float mana, float PlayerHealth, int enemyhealth, int playersattack, int specialattack, float manarounds)
        {
            Console.WriteLine("Round: " + rounds);
            Console.WriteLine(" ");
            Console.WriteLine("Your status:");
            Console.WriteLine("Mana left: " + mana);
            Console.WriteLine("Health left: " + PlayerHealth);
            Console.WriteLine("  ");
            Console.WriteLine("Enemy's status: ");
            Console.WriteLine("Enemy's health: " + enemyhealth);
            Console.WriteLine("");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Special Attack");
            //Console.WriteLine("3. Defend");
            Console.WriteLine("Enter the number for what you want to use!");
            string attackchoice = Console.ReadLine();

            if (attackchoice == "1")
            {
                enemyhealth = enemyhealth - playersattack;
                Console.WriteLine("Your attack was succeful! Enemy has been dealt " + playersattack + " damage!");
            }
            else if (attackchoice == "2" && mana > 9)
            {
                enemyhealth = enemyhealth - specialattack;
                mana = mana - 10;
                manarounds = manarounds + 1;
                Console.WriteLine("Congradulation! You delt " + specialattack + " damage by special attack!");

            }
            //when figured outy i will implement this!
            //else if (attackchoice == "3")
            //{
            //    int defendagainstattack = defence - tutorialbossattack;
            //    if (defence > tutorialbossattack)
            //    {
            //        Console.WriteLine("Your defence is higher! You suffered no damade!");
            //    }
            //}
            else
            {
                Console.WriteLine("You missed!");
            }
        }

        public void Run()
        {
            //Cailey Bianchini
            //Hello World
            //An text based rpg or a M.U.D

            //I need to have someone fix the grammer and spelling XD




            int enemyhealth = 100;

            //tutorial boss

            int tutorialbossattack = 1;


            //Demon King
            int demonkinghealth = 300;
            int demonkingattack = 50;
            int demonkingspecialattack = 75;
            int demonkingmana = 40;

            //character details

            //health 
            float PlayerHealth = 100.0f;
            float PlayerHealthRegen = 20.0f;
            //_________________________________________________________________________________________________
            //player atacks and such
            float mana = 50.0f;   //will figure out how to conbine with attack variables
            float manaregen = 10.0f;
            int playersattack = 20;
            int specialattack = 40; //minus 10 mana
            //_________________________________________________________________________________________________
            //levels
            int level = 0;
            //bool maxlevelreached = false;
            int maxlevel = 100;
            //_________________________________________________________________________________________________
            //other stats
            int charisma = 20;
            float karma = 2.0f;
            int luck = 5;
            float stealth = 2.0f;
            int defence = 5;

            //_________________________________________________________________________________________________
            //pet
            int petattack = 20;

            //_________________________________________________________________________________________________
            //Bag
            int goldcoins = 10;
            int silvercoins = 15;
            int coppercoins = 20;

            

            //maxlevelreached = level == maxlevel;

            //menu
            //bool ready = true;


            while (PlayerHealth > 0)
            {

                //start


                //story
                Console.WriteLine("~~~~~~~~~~");
                Console.WriteLine("The world is a violent one. Many creatures live in this world: Humans, Elves, Dwarfs, Spirits, and much more. This world use to be quite a peaceful one until the fowl Demons showed up. At first it was random killings, lone merchants traveling in between towns, farmers that where out on their feild.");
                Console.WriteLine("Everything changed when the Demon King appeared. They're random attacks became organized, the damage done tripled, and the causalties worsened. We were losing hope. That was until a prophecy was shared, 'Summon a Hero and the world shall be saved.' and thus a sliver of hope was born!"); //aparently i misspelled slimmer? How do I spell it then?
                Console.WriteLine("~~~~~~~~~~");

                //this can be copy and pasted to help out the screen
                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                //your begining
                Console.WriteLine("You awoke in a bright marble room, standing in front of you a tall and goddess like dark elf and her eyes had galxies in them. There was a halo behing her making her even more goddess like, she gives you small smile and open her arms.");
                Console.WriteLine("'What is your name Hero?' the woman asks.");
                string name = Console.ReadLine();
                Console.WriteLine("'You were brought to our world to save us Hero " + name + "!'");
                Console.WriteLine("  ");
                Console.WriteLine("Make sure you write the full word and all lower case!");
                Console.WriteLine("What type of Hero Class are you: ");
                string role = Console.ReadLine();
                Console.WriteLine("I'm sorry but I can't tell, what race are you?");
                string race = Console.ReadLine();
                Console.WriteLine("  ");
                Console.WriteLine("-Level Gained-");
                level = level + 1;
                Console.WriteLine("     ");

                //role

                //soon to be added

                //warlock

                //sorcerer
                //wizard


                //druid


                if (role == "mage")
                {
                    PlayerHealth = PlayerHealth - 50;
                    mana = mana + 30;
                    playersattack = playersattack - 10;
                    specialattack = specialattack + 30;
                    stealth = stealth + 1;
                    defence = defence - 2;

                }
                if (role == "knight")
                {
                    PlayerHealth = PlayerHealth + 60;
                    PlayerHealthRegen = PlayerHealthRegen + 10;
                    luck = luck + 5;
                    stealth = stealth - 1;
                    defence = defence + 10;
                }
                if (role == "necromancer")
                {
                    karma = karma - 1;
                    charisma = charisma - 5;
                    luck = luck - 3;
                    PlayerHealth = PlayerHealth - 45;
                    mana = mana + 30;
                    playersattack = playersattack - 10;
                    specialattack = specialattack + 20;
                    stealth = stealth + 3;
                    defence = defence - 2;
                }
                if (role == "bard")
                {
                    karma = karma + 3;
                    charisma = charisma + 5;
                    PlayerHealth = PlayerHealth - 75;
                    mana = mana + 15;
                    stealth = stealth + 1;

                }
                if (role == "monk")
                {
                    PlayerHealth = PlayerHealth + 30;
                    playersattack = playersattack + 20;
                    stealth = stealth + 3;
                }
                if (role == "cleric")
                {
                    charisma = charisma + 8;
                    specialattack = specialattack + 15;
                    karma = karma + 3;
                }
                if (role == "fighter")
                {
                    playersattack = playersattack + 30;
                    mana = mana / 2;
                }
                if (role == "rogue")
                {
                    karma = karma - 2;
                    specialattack = specialattack + 5;
                    stealth = stealth + 5;
                }
                if (role == "ranger")
                {
                    specialattack = specialattack + 3;
                    stealth = stealth + 5;
                }
                if (role == "barbarian")
                {
                    PlayerHealth = PlayerHealth + 30;
                    playersattack = playersattack + 30;
                }
                if (role == "druid")
                {
                    charisma = charisma + 5;
                    karma = karma + 2;
                    mana = mana + 10;
                    luck = luck + 2;
                }

                //race

                //soon to be added
                //orc
                //gnome
                //dragonborn
                //half orc
                //other halves
                //fae

                if (race == "human")
                {
                    PlayerHealth = PlayerHealth - 20;
                    mana = mana - 50;
                    specialattack = specialattack - 40;
                    defence = defence + 3;
                }
                if (race == "drawf")
                {
                    PlayerHealth = PlayerHealth + 20;
                    playersattack = playersattack + 20;
                    mana -= mana * 0.5f;
                    defence = defence + 5;
                }
                if (race == "elf")
                {
                    luck = luck + 3;
                    karma = karma + 3;
                    mana = mana * 2;
                    charisma = charisma + 2;
                    PlayerHealth = PlayerHealth + 40;
                    PlayerHealthRegen = PlayerHealthRegen + 10;
                    playersattack = playersattack / 2;
                    specialattack = specialattack + 30;
                    defence = defence - 3;

                }
                if (race == "halfling")
                {
                    PlayerHealth = PlayerHealth / 2;
                    stealth = stealth + 6;
                }
                if (race == "orc")
                {
                    PlayerHealth = PlayerHealth + 40;
                    playersattack = playersattack + 10;
                }

                //stats
                PrintStats(level, charisma, karma, luck, stealth, defence, mana, playersattack, specialattack, goldcoins, silvercoins, coppercoins, name, role, race, PlayerHealth);
                Console.WriteLine("Your goal is to reach the max level of " + maxlevel + " and defeat the Demon King with your new found powers! To save our world!");

                Console.WriteLine(" ");
                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("- Quest Recieved: Defeat the Demon King! - ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("- D A Y  O N E -");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("A bright light blinded you after you were given the quest by the woman. When the light finally cleared you realized you were in the center of a crowd.");
                Console.WriteLine("You look around and notice that the town was a mix of races: Elves, Humans, Drawfs, and more. The crowd then departs and an Ederly Dragon Born walks inbetween the parted group.");
                Console.WriteLine("Are you a Hero? Did Goddess Cecilia send you?");

                Console.WriteLine(" ");
                Console.WriteLine("Choose 1 or 2 for your answer.");
                Console.WriteLine(" ");

                Console.WriteLine("1. Answer him honestly about what you saw and what she said.");
                Console.WriteLine("2. A Goddess? Sorry I don't know who you are talking about.");

                string queston1 = Console.ReadLine();

                if (queston1 == "1")
                {
                    charisma = charisma + 3;
                    karma = karma + 4;
                    Console.WriteLine("Everyone around began cheering for finally the Hero sent by their Goddess Cecilia.");
                    Console.WriteLine("The Elder grabbed your arm happily 'Since you were sent by our goddess we must treat you well!' He handed you a bag of what you presume to be a bag of coins.");
                    Console.WriteLine("'Quickly we must show you to your room! And no worries its on us!' You followed the Elder to the tavern, and was greeted by the woman at the front desk.");
                    Console.WriteLine("'Welcome to the Kraken Tavern, for one room its 2 silver coins!' the elderly walked up to her, 'This young " + race + " is the hero sent by the Goddess! No need to make them pay the fee!'");
                    Console.WriteLine("The woman gased and quickly grabbed a set of keys behind her, 'Room 11 Hero....?' you realized that you haven't given them your name, '" + name + "' she nodded to herself 'Here you go Hero " + name + "!'");
                    Console.WriteLine("You found your room, entered it then layed onto the bed, waiting for the next day to come.");

                    Console.WriteLine("Press [Enter] to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    goldcoins = goldcoins + 1;
                    silvercoins = silvercoins + 2;
                    coppercoins = coppercoins + 3;

                    Console.WriteLine("Congradulations! You gained 2 charisma, 3 karma, 1 gold coin, 2 silver coins, and 3 copper coins!");
                }
                else if (queston1 == "2")
                {
                    karma = karma - 1;
                    Console.WriteLine("Everyone around you grew gloomy as you told them 'I do not know who you are talking about.' Even the Elders calm demeanor was shattered in his dissapointment.");
                    Console.WriteLine("You were quite uncomfortable with their gazes of awe but the gloom in the air is even much more unnerving. 'Do you have a place to stay?' you asked the Elder.");
                    Console.WriteLine("'We do.' He answered shortly. He pointed towards a tavern that seemed to have a second level. Perhaps the main floor was similar to a pub and the other floor may be a hotel. You bowed to the Elder and with a polite tone 'Thank you.'");
                    Console.WriteLine("You walked in. You were greeted by a woman at the front desk 'Welcome to the Kraken Tavern, for one room its 2 copper coins!' You walked up to her and handed her the 2 silver coins. 'Here you go! Room 11! May I know your name so I can put it in the Log Book!'");
                    coppercoins = coppercoins - 2;
                    Console.WriteLine("'" + name + "'");
                    Console.WriteLine("You found your room, entered it and then layed onto the bed, wating for the next day to come.");

                    Console.WriteLine("Press [Enter] to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("It's a sad day, you were taken to a world you do not know of, you had already used 2 silver coins and lost 2 karma points. Hopefully tommorrow would be better than it was today.");

                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You ignored The Elder, a terrible mistake on your part. The people around you grew a disdain towards you. The crowd departed and the Elder snarled at you and left.");
                    Console.WriteLine("You were left out in the middle of town all to your lonesome, you had no idea where to go and it seemed that everyone would ignore just as what you did to them.");
                    Console.WriteLine("As the seconds went by the sky began to darken. It then began to rain, you were drenched in water, you begin to feel sick. Health drops 5 percent.");
                    PlayerHealth = PlayerHealth * 0.95f;
                    Console.WriteLine("You look around and find a two story building with a plank on it saying 'Kraken Tavern'. You went inside.");
                    Console.WriteLine("");
                    Console.WriteLine("The man at the front desk is started by your apperance then smirks. You can tell that gears starts to run in his head. 'Welcome to the Kraken Tavern, its 4 coppers per room!' a rip off but you aren't complaing because of the situation your in.");
                    Console.WriteLine("He hands you a set of keys, Room 11. You look around for your room. You soon found a door with the matching numbers. Unlocking the door you step inside and shut the door close. You jump into bead absolutly tired.");

                    Console.WriteLine("Press [Enter] to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    coppercoins = coppercoins - 4;
                    Console.WriteLine("You lost 5% of your health and 4 copper coins. Today is just not your day. Hopefully tommorrow is better.");
                }

                Console.WriteLine("- E N D  O F  D A Y  O N E -");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                //my tutorial disapeared!!!!

                Console.WriteLine("- D A Y  T W O -");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Stats");
                PrintStats(level, charisma, karma, luck, stealth, defence, mana, playersattack, specialattack, goldcoins, silvercoins, coppercoins, name, role, race, PlayerHealth);

                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You awoke in an unfamiliar room, then you remembered what happened yesterday.");
                Console.WriteLine("You stand up and walk out of your room and head out of the tavern.");
                Console.WriteLine("Your objective for today is to learn how to attack! Across the street from you, you spot a soldier."); //I swear to god thats how you spell soldier, i am too angrey at my loss of my programing to worry about spelling >:(
                Console.WriteLine("Walking up to him you asked 'where is the training grounds?'");

                if (queston1 == "1")
                {
                    Console.WriteLine("The soldier gives you a bright smile ' Hero " + name + "! Ya came ta ask me! I'm blessed! It's down da road with da grey brick fencing!");
                    Console.WriteLine("You thank the soldier and follow his instructions.");
                }
                else
                {
                    Console.WriteLine("The soldier grumbles at you and points down the street, 'It's da grey bik fenced area.'");
                    Console.WriteLine("You wonder down the street that he pointed to looking out for an obvious training ground with the grey brick fencing around it.");
                }

                Console.WriteLine("You found the traing area and enter inside. You see a few dummies around, obvious for practice.");

                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("It's time for training!");
                Console.WriteLine("You have two types of attacks, a regular attack and a special attack.");
                Console.WriteLine("Your regular attack is relitivly low however you do not need mana!");
                Console.WriteLine("Your special attack tends to have high attack damage however if requires 10 mana.");
                Console.WriteLine("If you try to use your special attack but do not have enough mana you will fail your attack. When you do so depending on the situation the attack can back fire and cause you damage. Not only that but it will skip your turn but the enemy will not wait for you and attacik.");
                Console.WriteLine("This round the penilties will be minimal. Be careful however! This Dummy attacks!");
                //Console.WriteLine("If you want you can also defend yourself, but becareful! If you have less defence than the enemies attack then you will take what is left over!");
                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                int rounds = 0;
                float manarounds = 0.0f;

                while (PlayerHealth > 0 && enemyhealth > 0)
                {
                    AttackChoices(rounds, mana, PlayerHealth, enemyhealth, playersattack, specialattack, manarounds);
                    Console.WriteLine(" ");
                    Console.WriteLine("Enimeies Turn!");
                    Console.WriteLine("");
                    Console.WriteLine("Enemy delt: " + tutorialbossattack + " damage!");
                    PlayerHealth = PlayerHealth - tutorialbossattack;


                    rounds = rounds + 1;
                    if (PlayerHealth < 1)
                    {
                        break;
                    }

                    Console.WriteLine("Press [Enter] to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (PlayerHealth < 1)
                {
                    break;
                }
                else if (enemyhealth < 1)
                {
                    Console.WriteLine("- 1 Level Gained -");
                    level = level + 1;
                }

                Console.WriteLine("This time around you will get your health back to the way it was however next time you will need to rely on your Health Regen!");
                mana = mana + (manaregen * manarounds);
                PlayerHealth = PlayerHealth + (tutorialbossattack * rounds);


                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();



                Console.WriteLine("You've been traing for hours and realized how tired you so you decided to walk back to the tavern.");
                Console.WriteLine("On your way there you spot an old man sitting on a blanket by an ally way. In front of the old man is a sign that says 'Riddles' so you walk up to him, whats the harm?");

                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("Hoho, what requires you to break it before you use it?");
                    string guess1 = Console.ReadLine();


                    if (guess1 == "egg")
                    {
                        Console.WriteLine("Hahaha, yes yes! Your correct! Hahaha!");
                        Console.WriteLine("You gain 1 charisma, 1 karma and 1 luck!");
                        luck = luck + 1;
                        charisma = charisma + 1;
                        karma = karma + 1;
                        Console.WriteLine("Press [Enter] to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The old man laughs at you, 'Hoho so stupid!'");
                        Console.WriteLine("You obviously got it wrong.");
                        Console.WriteLine("'Hohoo try again!'");
                        Console.WriteLine("Press [Enter] to continue.");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    i = i + 1;
                    Console.WriteLine("You have " + (5 - i) + " tries remaining");
                    Console.WriteLine("Press [Enter] to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("You had fun playing the riddle game but you really needed to head back, the sun was about to set. You waved the man goodbye and left.");

                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You arived back at the Kraken Tavern. Your stomach rumbles. The Tavern does have food, so you decided to enter the tavern section and walked up to a table and sat down.");
                Console.WriteLine("A watress walks up to you with a business smile and tells you what they have on  the menu and its prices.");
                Console.WriteLine("1. Stew with bread - 1 copper");
                Console.WriteLine("2. Roast Pork - 3 copper");
                Console.WriteLine("3. Lasana and apple pie - 5 copper");
                Console.WriteLine("You have " + coppercoins + " copper coins!");

                string menuchoice1 = Console.ReadLine();

                if (menuchoice1 == "1" && coppercoins > 0)
                {
                    Console.WriteLine("They stew and bread filled your stomach, although the taste wasn't exceptional the warmth of the meal made you feel good.");
                    Console.WriteLine("Great job! You didn't loose any health!");
                    coppercoins = coppercoins - 1;
                }
                else if (menuchoice1 == "2" && coppercoins > 2)
                {
                    Console.WriteLine("The roast was delicious, the sauce might be what made it taste so good! This is exactly what you needed!");
                    PlayerHealth = PlayerHealth + 2;
                    Console.WriteLine("You gained 2 health points!");
                    coppercoins = coppercoins - 3;
                }
                else if (menuchoice1 == "3" && coppercoins > 4)
                {
                    Console.WriteLine("The Lasana and Apple Pie was amazing! It was exactly whay you needed! It made you quite full, you won't be needed to get any snacks later!");
                    coppercoins = coppercoins - 5;
                    Console.WriteLine("You gained 5 health points!");
                    PlayerHealth = PlayerHealth + 5;
                }
                else
                {
                    Console.WriteLine("You end up choosing just water but that did not end your hunger. You lost 2 health points!");
                    PlayerHealth = PlayerHealth - 2;
                }

                Console.WriteLine("After your meal you had to your room. You were tired from all that hard work you did during the day that as soon as you layed onto the bed you fell fast asleep.");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("- E N D  O F  D A Y  T W O -");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Your new stats!");
                PrintStats(level, charisma, karma, luck, stealth, defence, mana, playersattack, specialattack, goldcoins, silvercoins, coppercoins, name, role, race, PlayerHealth);


                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();

                //erase when putting more!! \/
                break;
                //erase!! /\


                //what should i do next? I mean in story wise? theres just sooooo much that i can do :"(




            }



            //End of Game

            Console.Clear();

            if (PlayerHealth < 1)
            {
                Console.WriteLine("G A M E   O V E R.");
                Console.WriteLine("You Died.");
                
            }
            else if (demonkinghealth < 1)
            {
                Console.WriteLine("Congradulations! You defeated the Demon King! ");
                //blah blah blah more dialogue
                
            }
            else
            {
                Console.WriteLine("Version 0.0.1");
                Console.WriteLine("You reached the end of what we have. This is an early version of the game. Thank you for playing!");

            }

            Console.WriteLine("Press [Enter] to End Game.");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
