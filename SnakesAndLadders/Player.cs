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
        public int id;
        public int position;
        public Point positionOnBoard;
        public Player(int playerNumber)
        {
            id = playerNumber;
            position = 0;
            positionOnBoard = new Point(-55, 650);
        }
    }
}
