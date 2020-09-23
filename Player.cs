using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
            _gold = 100;

        }

        public Player(int goldVal, int inventorySize)
        {
            _gold = goldVal;
            _inventory = new Item[inventorySize];
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        public void AddItemInventory(Item item, int index)
        {
            _inventory[index] = item;
        }

        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        public bool Buy(Item stock, int inventoryIndex)
        {
            if(_gold >= stock.cost)
            {
                //subtracts gold
                _gold -= stock.cost;
                //places item in inventory
                _inventory[inventoryIndex] = stock;
                return true;

            }
            return false;
        }

        public int GetGold()
        {
            return _gold;
        }

        
    }
}
