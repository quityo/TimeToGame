using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerValidationManager : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            return player.DateOfBirth == 1990 && player.FirstName == "xxx"
                &&player.LastName =="yyy" && player.IdentityNumber==54321;
        }
    }
}
