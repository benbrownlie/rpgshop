using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        private bool _gameOver = false;
        private Player _player;
        private Shop _shop;
        private Item _bread;
        private Item _loaf;
        private Item _grain;
        private Item _shopInventory;
        //private shopInvetory.Item[];

        private void InitializeItems()
        {
            _bread.cost = 25;
            _bread.name = "Bread";
            //
            _loaf.cost = 25;
            _loaf.name = "Loaf";
            //
            _grain.cost = 25;
            _grain.name = "Grain";
        }


        private void OpenShopMenu()
        {
            Console.WriteLine("Welcome to my shop!");
            Console.WriteLine("What are you interested in today?");
            Console.WriteLine("1. " + _bread.name + "Cost: " + _bread.cost);
            Console.WriteLine("2. " + _loaf.name + "Cost: " + _loaf.cost);
            Console.WriteLine("3. " + _grain.name + "Cost: " + _grain.cost);
            char input = Console.ReadKey().KeyChar;
            
            {
                if(input == '1')
                {
                    _player.AddItemInventory(_bread, 0);
                    _shop.Sell(_player, 0, 0);
                    _player.Buy(_bread, 25);
                }
                else if (input == '2')
                {
                    _player.AddItemInventory(_loaf, 1);
                    _shop.Sell(_player, 1, 0);
                    _player.Buy(_loaf, 25);
                }
                else if (input == '3')
                {
                    _player.AddItemInventory(_grain, 2);
                    _shop.Sell(_player, 2, 0);
                    _player.Buy(_grain, 25);
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            _player.GetInventory(); 

        }

       public Item PrintInventory(Item[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Item._shopInventory[i] = inventory[i];
                
            }
        }

        //Run the game
        public void Run()
        {
            Start();

            while(_gameOver == false)
            {
                Update();
            }

            End();
            
        }

        //Performed once when the game begins
        public void Start()
        {
            
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
