using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;


namespace Taylors_Dungeon
{
    class stats
    {
        public int counter = 0;
        public int encounter_counter = 0;

        public string[] enemyarray = new string[] { "witch", "warlock", "goblin", "baby dragon", "bandit", "evil elf", "ghost", "mummy" };
        public string[] loot = new string[] { "dragon warhammer", "attack experience scroll", "helmet", "bronze plate armour", "coins ", "10 coins", "experience lamp", "bones", "shield","" };
        private int userdamage;
        public bool warham = false;
        public bool bronzeplatearmour = false;
        public bool shield = false;
        public bool helmet = false;
        public string Name { get; set; }
        public string difficultylevel { get; set; }
        public string warriortype { get; set; }

        public int magiclevel { get; set; }

        public int prayerlevel { get; set; }

        public int attacklevel { get; set; }

        public int deffencelevel { get; set; }
        public int hitpoints { get; set; }

        public int playercoins = 0;

        public void CharacterCreation()
        {

            if (warriortype == "barbarian")
            {
                attacklevel = 20;
                deffencelevel = 20;
                prayerlevel = 5;
                magiclevel = 3;
                hitpoints = 100;
                playercoins = 0;
            }

            if (warriortype == "holy shaman")
            {
                attacklevel = 5;
                deffencelevel = 15;
                prayerlevel = 25;
                magiclevel = 1;
                hitpoints = 100;
                playercoins = 0;
            }

            if (warriortype == "mage")
            {
                attacklevel = 5;
                deffencelevel = 15;
                prayerlevel = 1;
                magiclevel = 25;
                hitpoints = 100;
                playercoins = 0;
            }

        }

        public void outputstats()
        {
            Console.WriteLine("Your attack level is " + attacklevel);
            Console.WriteLine("Your deffence level is " + deffencelevel);
            Console.WriteLine("Your prayer level is " + prayerlevel);
            Console.WriteLine("Your magic level is " + magiclevel);
            Console.WriteLine("Your hitpoints level is " + hitpoints + ".");
            Console.WriteLine("And you have " + playercoins +" coins.");
            Console.WriteLine("You have killed " + encounter_counter + " enemies.\n");

        }

        public void start()
        {
            
            Console.WriteLine("You enter the dungeon....\n");
            Console.WriteLine("It's really dark and eery in here. As you slowly walk in you feel a shiver down your spine.\n");
            Console.WriteLine("It's too late to back out now.......or is it?\n");
            string answer;
            do
            {
                Console.WriteLine("Turn around and run out of the dungeoun? or Continue? (Please either enter '0' to abort the misson, or '1' to continue)");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == "0")
                {
                    Console.WriteLine("As you attempt to run out of the dungeon the door slams shut. As your adrenaline spikes you feel a cold sweat drip down your face.." +
                        "You turn around in shock. A 7 foot tall cyclops stands before you. Before you can even begin to defend yourself you faint...........\n");
                    Console.WriteLine("You wake up in a cage in complete darkness. \n");
                    Console.WriteLine("You climb the cage....\n");
                    Console.WriteLine("You try to be as quiet as possible\n");
                    outputstats();
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    outputstats();
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    outputstats();
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints); 
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                }
                else if (answer == "1")
                {
                    Console.WriteLine("Would you like to adventure up the seemingly never ending winding stair case straight accross from you, go down the stairs on the other side of the dungeon," +
                        "or enter the dungeon doors that seem to haven't been opened in centuries? \n(Enter '0' to go up the winding stair case, '1' to go down the stairs, or '2' to enter the dungeon door)");
                    string decision = Console.ReadLine();
                    if (decision == "1")
                    {
                        outputstats();
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        outputstats();
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        outputstats();
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                        hitpoints = enemyencounter(warriortype, magiclevel, deffencelevel, attacklevel, prayerlevel, hitpoints);
                    }
                }
            }
            while (answer != "0" && answer != "1");

         
        }


        public int enemyencounter(string warriortype, int magiclevel, int defencelevel, int attacklevel, int prayerlevel, int hitpoints)
        {

            int enemystrength =0;
            int enemyhitpoints=0;
            Random r = new Random();
            int genRand = r.Next(0,8);
            if (enemyarray[genRand] == "warlock")
            {
                if (warriortype == "holy shaman")
                {
                    enemystrength = 3;
                    enemyhitpoints = 60;
                }
                else if (warriortype == "mage")
                {
                    enemystrength = 3;
                    enemyhitpoints = 60;
                }
                else
                {
                    enemystrength = 20;
                    enemyhitpoints = 60;
                }
            }
            else if(enemyarray[genRand] == "witch")
            {
                if (warriortype == "holy shaman")
                {
                    enemystrength = 3;
                    enemyhitpoints = 60;
                }
                else if (warriortype == "barbarian") { 
                
                }
                enemystrength = 3;
                enemyhitpoints = 60;
                {
                    enemystrength = 30;
                    enemyhitpoints = 70;
                }
            }
            else if (enemyarray[genRand] == "baby dragon")
            {
                enemystrength = 10;
                enemyhitpoints = 20;
            }
            else if (enemyarray[genRand] == "mummy")
            {
                enemystrength = 15;
                enemyhitpoints = 35;
            }
            else if (enemyarray[genRand] == "ghost")
            {
                enemystrength = 5;
                enemyhitpoints = 30;
            }
            else if (enemyarray[genRand] == "evil elf")
            {
                if (warriortype == "mage")
                {
                    enemystrength = 3;
                    enemyhitpoints = 60;
                }
                else if (warriortype == "barbarian")
                {
                    enemystrength = 3;
                    enemyhitpoints = 60;
                }
                else
                {
                    enemystrength = 35;
                    enemyhitpoints = 70;
                }
            }
            else if (enemyarray[genRand] == "goblin")
            {
                enemystrength = 12;
                enemyhitpoints = 40;
            }
            else if (enemyarray[genRand] == "bandit")
            {   
                enemystrength = 15;
                enemyhitpoints = 40;
            }
            string choice2 ="3";
            Console.WriteLine("Uh oh... You came accross a "+ enemyarray[genRand] +"!\n");
            do
            {
                Console.WriteLine("Run away and find cover, or take on the enemy head on? \n(Enter '0' to bail, or '1' to fight the enemy!)");
                Console.WriteLine("Remember.....You can only bail on three enemies, choose wisely " + Name + ".");
                choice2 = Console.ReadLine();
            }
            while(choice2 != "0" && choice2 != "1");
            if (choice2 == "0")
            {
                if (counter > 2) // change this to allow more bails
                {
                    Console.WriteLine("As you attempt to flee you are frozen by the magical force of the dungeon. You must fight. Even if it means risking our life.\n");
                    hitpoints = battle(enemyarray[genRand], enemystrength, enemyhitpoints, magiclevel, defencelevel, attacklevel, prayerlevel, hitpoints);
                    return hitpoints;
                }
                Console.WriteLine("You turn around and run as fast as you can....\n");
                Console.WriteLine("You stop and catch your breath... The coast seems to be clear.\n");
                counter++;
                return hitpoints;
            }
            else 
            {
                hitpoints = battle(enemyarray[genRand], enemystrength, enemyhitpoints, magiclevel, defencelevel, attacklevel, prayerlevel, hitpoints);
                return hitpoints;
            }
        }

        public void lootdrop ()
        {
            Random lo = new Random();
            string experiencelampanswer;
            int genRand = lo.Next(0, 10);
            int lootrand = genRand;

            if (loot[lootrand] == "bones")
            {
                Console.WriteLine("You recieved bones. You gain 2 prayer experience points.");
                prayerlevel = prayerlevel + 2;
            }
            else if (loot[lootrand] == "attack experience scroll")
            {
                Console.WriteLine("You recieved an attack experience scroll. You gain 2 experience points in attack.");
                attacklevel = attacklevel + 2;
            }
            else if (loot[lootrand] == "dragon warhammer")
            {
                if (warham == false)
                {
                    Console.WriteLine("You recieved a dragon warhammer. You equipt it and gain 2 experience points in attack.");
                    attacklevel = attacklevel + 2;
                    warham = true;
                }
                else {
                    Console.WriteLine("You recieved a dragon warhammer. But since you already have this item you perform alchemny and recieve 5 coins.");
                    playercoins = playercoins + 5;
                }
            }
                else if (loot[lootrand] == "bronze plate armour")
            {
                if (bronzeplatearmour == false)
                {
                    deffencelevel = deffencelevel + 1;
                    Console.WriteLine("You recieved bronze plate armour. You equipt it and gain 1 experience point in deffence.");
                    bronzeplatearmour = true;
                }
                else
                {
                    Console.WriteLine("You recieved bronze plate armour. But since you already have this item you perform alchemny and recieve 5 coins.");
                    playercoins = playercoins + 5;
                }
            }
            else if (loot[lootrand] == "shield")
            {
                if (shield == false)
                {
                    Console.WriteLine("You recieved a shield. You equipt it and gain 1 experience point in deffence.");
                    deffencelevel = deffencelevel + 1;
                    shield = true;
                }
                else
                {
                    Console.WriteLine("You recieved shield. But since you already have this item you perform alchemny and recieve 5 coins.");
                    playercoins = playercoins + 5;
                }
            }
            else if (loot[lootrand] == "helmet")
            {
                if (helmet == false)
                {
                    Console.WriteLine("You recieved a helmet. You equipt it and gain 1 experience point in deffence.");
                    deffencelevel = deffencelevel + 1;
                    helmet = true;
                }
                else
                {
                    Console.WriteLine("You recieved a helmet. But since you already have this item you perform alchemny and recieve 5 coins.");
                    playercoins = playercoins + 5;
                }
            }
            else if (loot[lootrand] == "10 coins")
            {
                Console.WriteLine("You recieved 10 coins. You add them to your coin pouch.");
                playercoins = playercoins + 10;
            }
            else if (loot[lootrand] == "coins")
            {
                Console.WriteLine("You recieved 25 coins. You add them to your coin pouch.");
                playercoins = playercoins + 25;
            }
            else if (loot[lootrand] == "experience lamp")
            { do
                {
                    Console.WriteLine("You recieved an experience lamp.\n" +
                        "Which skill would you like to raise your experience 1 point in? ('0' for attack, '1' for deffence, '2' for prayer,'3' for magic, or '4' to restore 20 hitpoints.");
                    experiencelampanswer = Console.ReadLine();
                } while (experiencelampanswer == "");
                if (experiencelampanswer == "0")
                {
                    attacklevel++;

                }
                else if (experiencelampanswer == "1")
                {
                    deffencelevel++;
                }
                else if (experiencelampanswer == "2")
                {
                    prayerlevel++;
                }
                else if (experiencelampanswer == "3")
                {
                    magiclevel++;
                }
                else if (experiencelampanswer == "4")
                {
                    hitpoints = hitpoints + 20 ;
                }
            }
            else 
            {
                Console.WriteLine("You thought you saw something but you were wrong. The enemy didn't drop any loot.\n");
            }
        }

        public int battle(string enemy, int enemystrength, int enemyhitpoints, int magiclevel, int defencelevel, int attacklevel, int prayerlevel, int hitpoints ) {
            do
            {
                Random num = new Random();
                Random numdamage = new Random();
                int actualdamage = numdamage.Next(0, 30);

                if (enemy == "goblin" || enemy == "bandit" || enemy == "baby dragon" || enemy == "ghost" || enemy == "mummy" || enemy == "evil elf"  || enemy == "witch" || enemy == "warlock")
                {
                    int damage = num.Next(0, 2);
                    Console.WriteLine("The " + enemy + " attacks.");
                    if (damage == 0)
                    {
                        Console.WriteLine("The enemy dealt 0 damage");
                        Console.WriteLine("Your health is now " + hitpoints+".\n");
                    }
                    else if (damage != 0){
                        //int damagedealt = 5;      //this was for testing (change this for each eneemy to hit 5 each time, to test that hitpoints returns properly)
                        int damagedealt = (actualdamage + (enemystrength)) / (defencelevel / 2);
                        hitpoints = hitpoints - damagedealt;
                        Console.WriteLine("The enemy dealt " + damagedealt + " damage.");
                        Console.WriteLine("Your health is now "+ hitpoints+".\n");
                    }
                    Console.WriteLine("Your turn.\n");
                    Console.WriteLine("What kind of attack are you going to use against the enemy?.");
                    string attacktype = "3";
                    do
                    {
                        Console.WriteLine("Enter '0' to use your sword. Enter '1' to use a magic attack. Enter '2' to use piety (your prayer attack).");

                        attacktype = Console.ReadLine(); } 
                    while (attacktype != "0" && attacktype != "1" && attacktype != "2");
                    

                        if (attacktype == "0")
                        {
                            //userdamage = 100;    // change this to change and kill 100% each hit tofor testing
                            userdamage = (attacklevel * actualdamage) / 15;
                            if (userdamage > 12)
                               userdamage = userdamage / 2;
                        }
                        else if (attacktype == "1")
                        {
                            userdamage = (magiclevel * actualdamage) / 15;
                            if (userdamage > 12)
                                userdamage = userdamage / 2;
                        }
                        else if (attacktype == "2")
                        {
                            userdamage = (prayerlevel * actualdamage) / 15;
                            if (userdamage > 12)
                                userdamage = userdamage / 2;
                        }
                    } 
                    enemyhitpoints = enemyhitpoints - userdamage;
                    if (enemyhitpoints <= 0)
                    {
                        enemyhitpoints = 0;
                    }
                Console.WriteLine("You attack the enemy.");
                Console.WriteLine("You hit " + userdamage);
                    Console.WriteLine("Enemy's health is now " + enemyhitpoints + ".\n");
                
                



                Console.ReadLine();
            } while (enemyhitpoints > 0) ;
            Console.WriteLine("Goodjob. You slayed the enemy.\n");
            encounter_counter++;
            Console.WriteLine("The monster seems to have dropped something.....\n");
            lootdrop();
            Console.WriteLine("Your health is " + hitpoints + ".\n");
            outputstats();
            return hitpoints;
        
        }


    }
}
