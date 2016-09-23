///////////////////////////////////////////////////////////
//  HardCodedData.cs
//  Implementation of the Class HardCodedData
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

using System;
using Mazegame.Boundary;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace Mazegame
{
    public class HardCodedData : IMazeData
    {
        private Location startUp, westfield, bondi, shop, harbour, town, den;
        /*
        private Weapon katana, nunchaku, shuriken, kunai, dart;
        private Shield shield;
        private Armor armor;
        private Item crystal, berries, candy;
        */
        private AgilityTable agilityModifier;
        private StrengthTable strengthModifier;
        private WeightLimit weightLookup;

        public HardCodedData()
        {
            createLocations();
            createItem();
            PopulateAgilityTable();
            PopulateWeightLimit();
            PopulateStrengthTable();
            CreateNPC();
        }

        ~HardCodedData()
        {
        }

        public virtual void Dispose()
        {
        }


        public Location GetStartingLocation()
        {
            return startUp;
        }

        public String GetWelcomeMessage()
        {
            return "Welcome to the Mount Helanous";
        }
        private void CreateNPC()
        {
            NonPlayerCharacter npc = new NonPlayerCharacter("Jatinder");
            npc.Hostile = true;
            bondi.GetNonPlayerCharacterCollection().AddNonPlayerCharacter(npc);
        }
        private void createLocations()
        {
            startUp =
                new Location("You are standing at the mighty door",
                    "MIT Sydney");
             westfield =
                new Location("You see yourself straing at the tower of sydney",
                    "Westfield Tower");
             bondi = new Location("Look at all them beaches", "Bondi Beach");
             shop = new Shop("Let's spend them bucks! Get some gears!", "Central Station");
             harbour = new Location("Dear darling! Here you are!", "Darling Harbour");
             town = new Location("Here they are, all the big heads!", "Town hall");
             den = new Location("You are the chosen one! You are standing at the den of Geeks!", "Geek's Den");

            startUp.AddExit("east", new Exit("you see a high rise tower", westfield));
            westfield.AddExit("west", new Exit("you see the mighty door to the west", startUp));

            startUp.AddExit("west", new Exit("You see darlings waving at you!", harbour));
           harbour.AddExit("east", new Exit("you see the mighty door to the west", startUp));

            westfield.AddExit("east", new Exit("you see them gorgeous beaches", bondi));
            bondi.AddExit("west", new Exit("you see a high rise tower", westfield));

            westfield.AddExit("southwest", new Exit("you see yourself scratching your wallet", shop));
            shop.AddExit("northeast", new Exit("you see a high rise tower", westfield));

            harbour.AddExit("south", new Exit("Look at them, all the big heads", town));
            town.AddExit("east", new Exit("You see darlings waving at you!", harbour));

            town.AddExit("northeast", new Exit("You see there, That's where legends reside!", den));
            den.AddExit("southwest", new Exit("Look at them, all the big heads", town));

            shop.AddExit("west", new Exit("You see there, That's where legends reside!", den));
            den.AddExit("east", new Exit("you see yourself scratching your wallet", shop));
        }
      
        public void createItem()
        {
            bondi.GetInventory().AddMoney(60);
            bondi.GetInventory().AddItem(new Item("candy", 20, 10, "Eat as you go"));

            den.GetInventory().AddMoney(99999);
            shop.GetInventory().AddItem(new Item("nunchaku", 10, 11, "Two Stick Weapon"));
            town.GetInventory().AddItem(new Item("shuriken", 15, 15, "Small ninja throwables"));
            shop.GetInventory().AddItem(new Item("katana", 17, 20, "Sword"));
            westfield.GetInventory().AddItem(new Item("kunai", 15, 10, "A steel wedge"));
            town.GetInventory().AddItem(new Item("dart", 10, 10, "Poison darts"));
            harbour.GetInventory().AddItem(new Item("shield", 20, 20, "Protection against enemies"));
            shop.GetInventory().AddItem(new Item("armor", 25, 30, "Powerful than shield"));
            town.GetInventory().AddItem(new Item("berries", 10, 5, "Boost up your HP"));
            shop.GetInventory().AddItem(new Item("crystal", 30, 15, "Full Power"));
            harbour.GetInventory().AddMoney(50);
            /*
            nunchaku = new Weapon(500, 4, "Two Stick Weapon");
            shuriken = new Weapon(200, 1, "Small ninja throwables");
            katana = new Weapon(600, 1, "Sword");
            kunai = new Weapon(300, 2, "A steel wedge");
            dart = new Weapon(100, 1, "Poison Darts");
            shield = new Shield(1000, 5, "Protection against enemies");
            armor = new Armor(2000, 10, "Powerful than Sheild");
            candy = new Item(50, 1, "Eat as you go");
            berries = new Item(100, 1, "Boost up your HP");
            crystal = new Item(200, 1, "Full power");
            */
        }
        private void PopulateAgilityTable()
        {
            agilityModifier = AgilityTable.GetInstance();
            agilityModifier.SetModifier(1, -5);
            agilityModifier.SetModifier(2, -5);
            agilityModifier.SetModifier(3, -5);
            agilityModifier.SetModifier(4, -3);
            agilityModifier.SetModifier(5, -3);
            agilityModifier.SetModifier(6, -2);
            agilityModifier.SetModifier(7, -2);
            agilityModifier.SetModifier(8, -1);
            agilityModifier.SetModifier(9, -1);
            agilityModifier.SetModifier(10, 0);
            agilityModifier.SetModifier(11, 0);
            agilityModifier.SetModifier(12, 1);
            agilityModifier.SetModifier(13, 1);
            agilityModifier.SetModifier(14, 2);
            agilityModifier.SetModifier(15, 2);
            agilityModifier.SetModifier(16, 3);
            agilityModifier.SetModifier(17, 3);
            agilityModifier.SetModifier(18, 4);
            agilityModifier.SetModifier(19, 4);
            agilityModifier.SetModifier(20, 6);
            agilityModifier.SetModifier(21, 6);
            agilityModifier.SetModifier(22, 6);
            agilityModifier.SetModifier(23, 6);
            agilityModifier.SetModifier(24, 6);
            agilityModifier.SetModifier(25, 6);
            agilityModifier.SetModifier(26, 8);
            agilityModifier.SetModifier(27, 8);
            agilityModifier.SetModifier(28, 8);
            agilityModifier.SetModifier(29, 8);
            agilityModifier.SetModifier(30, 8);
            agilityModifier.SetModifier(31, 8);
            agilityModifier.SetModifier(32, 11);
        }

        private void PopulateWeightLimit()
        {
            weightLookup = WeightLimit.GetInstance();
            weightLookup.SetModifier(1, 6);
            weightLookup.SetModifier(2, 13);
            weightLookup.SetModifier(3, 20);
            weightLookup.SetModifier(4, 26);
            weightLookup.SetModifier(5, 33);
            weightLookup.SetModifier(6, 40);
            weightLookup.SetModifier(7, 46);
            weightLookup.SetModifier(8, 53);
            weightLookup.SetModifier(9, 60);
            weightLookup.SetModifier(10, 66);
            weightLookup.SetModifier(11, 76);
            weightLookup.SetModifier(12, 86);
            weightLookup.SetModifier(13, 100);
            weightLookup.SetModifier(14, 116);
            weightLookup.SetModifier(15, 133);
            weightLookup.SetModifier(16, 153);
            weightLookup.SetModifier(17, 173);
            weightLookup.SetModifier(18, 200);
            weightLookup.SetModifier(19, 233);
            weightLookup.SetModifier(20, 266);
            weightLookup.SetModifier(21, 306);
            weightLookup.SetModifier(22, 346);
            weightLookup.SetModifier(23, 400);
            weightLookup.SetModifier(24, 466);
            weightLookup.SetModifier(25, 533);
            weightLookup.SetModifier(26, 613);
            weightLookup.SetModifier(27, 693);
            weightLookup.SetModifier(28, 800);
            weightLookup.SetModifier(29, 933);
        }

        private void PopulateStrengthTable()
        {
            strengthModifier = StrengthTable.GetInstance();
            strengthModifier.SetModifier(1, -5);
            strengthModifier.SetModifier(2, -4);
            strengthModifier.SetModifier(3, -4);
            strengthModifier.SetModifier(4, -3);
            strengthModifier.SetModifier(5, -3);
            strengthModifier.SetModifier(6, -2);
            strengthModifier.SetModifier(7, -2);
            strengthModifier.SetModifier(8, -1);
            strengthModifier.SetModifier(9, -1);
            strengthModifier.SetModifier(10, 0);
            strengthModifier.SetModifier(11, 0);
            strengthModifier.SetModifier(12, 1);
            strengthModifier.SetModifier(13, 1);
            strengthModifier.SetModifier(14, 2);
            strengthModifier.SetModifier(15, 2);
            strengthModifier.SetModifier(16, 3);
            strengthModifier.SetModifier(17, 3);
            strengthModifier.SetModifier(18, 4);
            strengthModifier.SetModifier(19, 4);
            strengthModifier.SetModifier(20, 5);
            strengthModifier.SetModifier(21, 5);
            strengthModifier.SetModifier(22, 5);
            strengthModifier.SetModifier(23, 5);
            strengthModifier.SetModifier(24, 5);
            strengthModifier.SetModifier(25, 5);
            strengthModifier.SetModifier(26, 8);
            strengthModifier.SetModifier(27, 8);
            strengthModifier.SetModifier(28, 8);
            strengthModifier.SetModifier(29, 8);
            strengthModifier.SetModifier(30, 10);
            strengthModifier.SetModifier(31, 10);
            strengthModifier.SetModifier(32, 10);
            strengthModifier.SetModifier(33, 10);
            strengthModifier.SetModifier(34, 10);
            strengthModifier.SetModifier(35, 10);
            strengthModifier.SetModifier(36, 12);
            strengthModifier.SetModifier(37, 12);
            strengthModifier.SetModifier(38, 12);
            strengthModifier.SetModifier(39, 12);
            strengthModifier.SetModifier(40, 12);
            strengthModifier.SetModifier(41, 15);
            strengthModifier.SetModifier(42, 15);
            strengthModifier.SetModifier(43, 15);
            strengthModifier.SetModifier(44, 17);
            strengthModifier.SetModifier(45, 17);
            strengthModifier.SetModifier(46, 18);
        }
    } //end HardCodedData
} //end namespace Mazegame