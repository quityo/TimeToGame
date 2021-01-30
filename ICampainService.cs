using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICampainService
    {
        void BuyWithDiscount(Game game, Campain campain, Player player);
    }
}
