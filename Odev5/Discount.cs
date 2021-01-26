using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class Discount : ICampaign
    {
        public void Add(Game game)
        {
            Console.WriteLine("Discount " + game.GameName + " Added your game.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Discount " + game.GameName + " Deleted your game.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Discount " + game.GameName + "Updated your game.");
        }
    }
}
