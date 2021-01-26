using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player()
            {
                CitizenNumber = 4569878,
                FirstName = "Hamza",
                LastName = "Taskesen",
                NickName = "Sailor",
                DateOfBirth = "1903"
            };

            User user1 = new User()
            {
                CitizenNumber = 45648654,
                FirstName = "Hamza",
                LastName = "Taskesen",
                DateOfBirth = "1903"
            };

            Game game1 = new Game()
            {
                GameName = " Ships Simulator ",
                GamePrice = 80
            };
            VerifyManager verifyManager = new VerifyManager();
            verifyManager.Verification(player1, user1);

            PlayerManager playerManager1 = new PlayerManager();
            playerManager1.Add(player1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            GameManager gameManager1 = new GameManager();
            gameManager1.Sell(game1, player1);
        }
    }
 
}
