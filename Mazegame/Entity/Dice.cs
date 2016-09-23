///////////////////////////////////////////////////////////
//  Dice.cs
//  Implementation of the Class Dice
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:36 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;

namespace Mazegame.Entity
{
    public class Dice
    {
        private static readonly Random generator = new Random();
        private int sides;

        public Dice(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            return generator.Next(sides) + 1;
        }

        public int Sides
        {
            get { return sides; }
            set { sides = value; }
        }
    } //end Dice
} //end namespace Entity