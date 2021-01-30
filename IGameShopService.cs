using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGameShopService
    {
        void shopGame(Game game, Player player);
    }
}
