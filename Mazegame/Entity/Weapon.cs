///////////////////////////////////////////////////////////
//  Weapon.cs
//  Implementation of the Class Weapon
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

namespace Mazegame.Entity {
	public class Weapon : Item {

		public Mazegame.Entity.Dice m_Dice;

		public Weapon(string label, int worth, int weight, string description) : base(label, worth, weight, description)
         
        {
            
		}

	}//end Weapon

}//end namespace Entity