using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class Space
    {
        public int id;                  // number of the space
        public Point position;          // co-ordinates of space
        public string eventType;        // whether space is the start of a snake or ladder
        public Space(int x, int y)
        {
            position = new Point(x, y);
        }
        public int GetSpaceID(int spaceX, int spaceY)
        {
            int n = 0;
            id = n;
            return id;
        }
        public string GetSpaceEventType(int spaceX, int spaceY)
        {
            string type = "";
            switch (id)
            {
                case 1:
                    type = "ladder";
                    break;
                case 2:
                    type = "";
                    break;
                case 3:
                    type = "";
                    break;
            }
            eventType = type;
            return eventType;
        }
    }
}
