///////////////////////////////////////////////////////////
//  Item.cs
//  Implementation of the Class Item
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;

namespace Mazegame.Entity
{
    public class Item
    {
        private int worth;
        private int weight;
        private String description;
        private String label;

        public Item(string label, int worth, int weight, String description)
        {
            this.label = label;
            this.worth = worth;
            this.weight = weight;
            this.description = description;
        }
        public int Worth
        {
            get { return worth; }
            set { worth = value; }
        }
        
        public String Label
        {
            get { return label; }
            set { label = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
       

    } //end Item
} //end namespace Entity