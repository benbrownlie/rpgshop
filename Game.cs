using System;

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
        private Item[] _shopInventory;

        private void InitializeItems()
        {
            _bread.cost = 25;
            _bread.name = "Bread";
            //
            _loaf.cost = 50;
            _loaf.name = "Loaf";
            //
            _grain.cost = 15;
            _grain.name = "Grain";
            //
            _shopInventory = new Item[3];
        }


        private void OpenShopMenu()
        {
            Console.WriteLine("Welcome to my shop!");
            Console.WriteLine("What are you interested in today?");

            PrintInventory(_shopInventory);
            int itemIndex = -1;
            char input = Console.ReadKey().KeyChar;
            
            
            switch (input)
            {
                case '1':
                {
                    itemIndex = 0;
                    break;
                }
                case '2':
                {
                    itemIndex = 1;
                    break;
                }
                case '3':
                {
                    itemIndex = 2;
                    break;
                }
                default:
                {
                    return;
                }
            }
                
            if(_player.GetGold() < _shopInventory[itemIndex].cost)
            {
                Console.WriteLine("You cant afford this");
                return;
            }

            Console.WriteLine("Choose a slot to replace");

            PrintInventory(_player.GetInventory());

            input = Console.ReadKey().KeyChar;

            int playerIndex = -1;

            switch (input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            _shop.Sell(_player, itemIndex, playerIndex);

        }

       public void PrintInventory(Item[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost);
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
            _gameOver = false;
            _player = new Player();
            InitializeItems();
            _shopInventory = new Item[] { _bread, _loaf, _grain };
            _shop = new Shop(_shopInventory);
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
