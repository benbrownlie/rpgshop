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

        public bool Buy(Item bread, Item loaf, Item grain, int cost)
        {
            bool purchase = false;

            if ( purchase == true)
            {
                _gold -= 25;
                return true;
            }
            return false;
        }

        public void DisplayInventory()
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                _inventory[i].name[i];
            }

        }

        
    }
}
