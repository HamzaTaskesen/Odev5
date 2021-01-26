using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GameManager
    {

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Game Added Price: " + game.GamePrice);
        }

        public void Sell(Game game, Player player)
        {
            int new_price = game.GamePrice - 30;
            Console.WriteLine(game.GameName + " Games  sold to" + player.NickName + " Price : " + new_price);
        }
    }
}
