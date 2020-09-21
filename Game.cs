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
            Console.WriteLine("1. " + _loaf.name + "Cost: " + _loaf.cost);
            Console.WriteLine("1. " + _grain.name + "Cost: " + _grain.cost);
            char input = ' ';
            {
                if(input == '1')
                {
                    _player.AddItemInventory(_bread, 0);
                    _shop.Sell(_player, 100, 25);
                }
                else if (input == '2')
                {
                    _player.AddItemInventory(_loaf, 1);
                    _shop.Sell(_player, 100, 25);
                }
                else if (input == '3')
                {
                    _player.AddItemInventory(_grain, 2);
                    _shop.Sell(_player, 100, 25);
                }
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
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
