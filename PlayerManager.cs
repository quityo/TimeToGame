using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IPlayerValidationService _playerValidationService;

        public PlayerManager(IPlayerValidationService playerValidationService)
        {
             _playerValidationService = playerValidationService;
        }

        public void Add(Player player)
        {

            if (_playerValidationService.Validate(player) == true) 
            {
                Console.WriteLine("Joined");
            }
            else
            {
                Console.WriteLine("Please Try Again");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated");
        }
    }
}
