using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public string name;
        public int cost;
    }
    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        public Shop()
        {
            _gold = 100;
            _inventory = new Item[3];
        }

        public Shop(Item[] items)
        {
            _gold = 100;
            //Allows for multiple shop inventories to be made. Simply pass in items.
            _inventory = items;
        }

        public bool Sell(Player player, int shopIndex, int playerIndex)
        {
            //Find the item to buy in the inventory array
            Item itemtoBuy = _inventory[shopIndex];
            //Check to see if the player purchased the item successfully
            if (player.Buy(itemtoBuy, playerIndex))
            {
                //Increase shops item gold by cost to complete transaction
                _gold += itemtoBuy.cost;
                return true;
            }
            return false;
        }

        
    }
}
