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
        public string name;
        public int position;
        public Point positionOnBoard;
        public Player(int playerNumber, string playerName)
        {
            id = playerNumber;
            name = playerName;
            position = 0;
            positionOnBoard = new Point(-55, 650);
        }
    }
}
