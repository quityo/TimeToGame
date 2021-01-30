using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampainManager : ICampainService
    {
        public void BuyWithDiscount(Game game, Campain campain, Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " buy the " + game.GameName + ".");
        }
    }
}
