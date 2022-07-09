using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService

       
    {
        IUserValidationService iUserValidationService;

        public GamerManager(IUserValidationService iUserValidationService)
        {
            this.iUserValidationService = iUserValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (iUserValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer registered");
            }
            else
            {
                Console.WriteLine("validation failed registered failed..(");
            }

           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer uptaded");
        }
    }
}
