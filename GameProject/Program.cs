using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { FirstName = "Jone", LastName = "Doe",IdentityNumber = 123});
        }
    }
}
