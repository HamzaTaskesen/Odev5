using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("New Player Added: " + player.NickName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("User data updated: " + player.NickName + player.FirstName + player.LastName);
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.NickName + " users " + player.FirstName + " " + player.LastName + " Deleted.");
        }
    }
}
