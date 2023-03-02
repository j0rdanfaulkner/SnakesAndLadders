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
        public int id;                  // unique player number
        public string name;             // name entered before game starts
        public int position;            // the number of the square the player is currently at on the game board
        public Point positionOnBoard;   // the X & Y co-ordinates of the player label on the board
        public Player(int playerNumber, string playerName)
        {
            id = playerNumber;
            name = playerName;
            position = 0;
            positionOnBoard = new Point(-55, 650);
        }
    }
}
