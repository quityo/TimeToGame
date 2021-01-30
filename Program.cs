using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player
            {
                PlayerId = 1,
                DateOfBirth = 1990,
                FirstName = "xxx",
                LastName = "yyy",
                IdentityNumber = 54321
            };
            Game game = new Game { 
                GameName = "Fallout", 
                GamePrice = 10, 
                GameType = "Role Play" };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campain campain = new Campain { CampainName = "You Are Not Chosen One!", BuyWithDiscount = "%23" };
            CampainManager campainManager = new CampainManager();
            campainManager.BuyWithDiscount(game, campain, player);
        }
    }
}

