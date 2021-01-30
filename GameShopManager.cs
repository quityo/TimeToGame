using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class GameShopManager : IGameShopService
    {
        public void shopGame(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " buy " + game.GameName);
        }

        
    }
    
    
}
