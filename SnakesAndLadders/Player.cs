using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class Player
    {
        public int playerID;
        public int playerPosition;
        public Player(int playerID)
        {
            Player player = new Player(playerID);
            player.playerPosition = 0;
        }
    }
}
