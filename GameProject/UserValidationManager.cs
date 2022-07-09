using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Jone" && gamer.LastName == "Doe" && gamer.IdentityNumber == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
