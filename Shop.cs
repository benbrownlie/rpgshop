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
            
        }

        public Shop(string nameVal, int costVal)
        {

        }

        public bool Sell(Player player, int gold, int cost)
        {
            bool purchase = false;

            if (purchase == true)
            {
                gold += 25;
                return true;
            }
            return false;
        }

        public void CheckPlayerFunds(Player player)
        {

        }

        
    }
}
