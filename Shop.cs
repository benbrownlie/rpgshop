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
        }

        public Shop(Item[] items)
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                _inventory[i] = items[i];
            }
        }

        public bool Sell(Player player, int shopIndex, int playerIndex)
        {
            return player.Buy(_inventory[shopIndex], playerIndex);
        }

        //Optional
        public void CheckPlayerFunds(Player player)
        {

        }

        
    }
}
