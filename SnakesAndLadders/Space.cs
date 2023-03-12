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
        public Space(int spaceX, int spaceY)
        {
            position = new Point(spaceX, spaceY);
        }
        public void GetSpaceProperties(int spaceX, int spaceY)
        {
            int n = 0;
            string type = "";
            switch (spaceX, spaceY)
            {
                case (13, 650):
                    n = 1;
                    type = "ladder";
                    break;
                case (83, 650):
                    n = 2;
                    type = "";
                    break;
                case (153, 650):
                    n = 3;
                    type = "";
                    break;
                case (223, 650):
                    n = 4;
                    type = "ladder";
                    break;
                case (293, 650):
                    n = 5;
                    type = "";
                    break;
                case (363, 650):
                    n = 6;
                    type = "";
                    break;
                case (433, 650):
                    n = 7;
                    type = "";
                    break;
                case (503, 650):
                    n = 8;
                    type = "";
                    break;
                case (563, 650):
                    n = 9;
                    type = "ladder";
                    break;
                case (633, 650):
                    n = 10;
                    type = "";
                    break;
                case (633, 585):
                    n = 11;
                    type = "";
                    break;
                case (563, 585):
                    n = 12;
                    type = "";
                    break;
                case (503, 585):
                    n = 13;
                    type = "";
                    break;
                case (433, 585):
                    n = 14;
                    type = "";
                    break;
                case (363, 585):
                    n = 15;
                    type = "";
                    break;
                case (293, 585):
                    n = 16;
                    type = "";
                    break;
                case (223, 585):
                    n = 17;
                    type = "snake";
                    break;
                case (153, 585):
                    n = 18;
                    type = "";
                    break;
                case (83, 585):
                    n = 19;
                    type = "";
                    break;
                case (13, 585):
                    n = 20;
                    type = "";
                    break;
                case (13, 515):
                    n = 21;
                    type = "ladder";
                    break;
                case (83, 515):
                    n = 22;
                    type = "";
                    break;
                case (153, 515):
                    n = 23;
                    type = "";
                    break;
                case (223, 515):
                    n = 24;
                    type = "";
                    break;
                case (293, 515):
                    n = 25;
                    type = "";
                    break;
                case (363, 515):
                    n = 26;
                    type = "";
                    break;
                case (433, 515):
                    n = 27;
                    type = "";
                    break;
                case (503, 515):
                    n = 28;
                    type = "ladder";
                    break;
                case (563, 515):
                    n = 29;
                    type = "";
                    break;
                case (633, 515):
                    n = 30;
                    type = "";
                    break;
                case (633, 445):
                    n = 31;
                    type = "";
                    break;
                case (563, 445):
                    n = 32;
                    type = "";
                    break;
                case (503, 445):
                    n = 33;
                    type = "";
                    break;
                case (433, 445):
                    n = 34;
                    type = "";
                    break;
                case (363, 445):
                    n = 35;
                    type = "";
                    break;
                case (293, 445):
                    n = 36;
                    type = "";
                    break;
                case (223, 445):
                    n = 37;
                    type = "";
                    break;
                case (153, 445):
                    n = 38;
                    type = "";
                    break;
                case (83, 445):
                    n = 39;
                    type = "";
                    break;
                case (13, 445):
                    n = 40;
                    type = "";
                    break;
                case (13, 375):
                    n = 41;
                    type = "";
                    break;
                case (83, 375):
                    n = 42;
                    type = "";
                    break;
                case (153, 375):
                    n = 43;
                    type = "";
                    break;
                case (223, 375):
                    n = 44;
                    type = "";
                    break;
                case (293, 375):
                    n = 45;
                    type = "";
                    break;
                case (363, 375):
                    n = 46;
                    type = "";
                    break;
                case (433, 375):
                    n = 47;
                    type = "";
                    break;
                case (503, 375):
                    n = 48;
                    type = "";
                    break;
                case (563, 375):
                    n = 49;
                    type = "";
                    break;
                case (633, 375):
                    n = 50;
                    type = "";
                    break;
                case (633, 315):
                    n = 51;
                    type = "ladder";
                    break;
                case (563, 315):
                    n = 52;
                    type = "";
                    break;
                case (503, 315):
                    n = 53;
                    type = "";
                    break;
                case (433, 315):
                    n = 54;
                    type = "snake";
                    break;
                case (363, 315):
                    n = 55;
                    type = "";
                    break;
                case (293, 315):
                    n = 56;
                    type = "";
                    break;
                case (223, 315):
                    n = 57;
                    type = "";
                    break;
                case (153, 315):
                    n = 58;
                    type = "";
                    break;
                case (83, 315):
                    n = 59;
                    type = "";
                    break;
                case (13, 315):
                    n = 60;
                    type = "";
                    break;
                case (13, 245):
                    n = 61;
                    type = "";
                    break;
                case (83, 245):
                    n = 62;
                    type = "snake";
                    break;
                case (153, 245):
                    n = 63;
                    type = "";
                    break;
                case (223, 245):
                    n = 64;
                    type = "snake";
                    break;
                case (293, 245):
                    n = 65;
                    type = "";
                    break;
                case (363, 245):
                    n = 66;
                    type = "";
                    break;
                case (433, 245):
                    n = 67;
                    type = "";
                    break;
                case (503, 245):
                    n = 68;
                    type = "";
                    break;
                case (563, 245):
                    n = 69;
                    type = "";
                    break;
                case (633, 245):
                    n = 70;
                    type = "";
                    break;
                case (633, 175):
                    n = 71;
                    type = "ladder";
                    break;
                case (563, 175):
                    n = 72;
                    type = "";
                    break;
                case (503, 175):
                    n = 73;
                    type = "";
                    break;
                case (433, 175):
                    n = 74;
                    type = "";
                    break;
                case (363, 175):
                    n = 75;
                    type = "";
                    break;
                case (293, 175):
                    n = 76;
                    type = "";
                    break;
                case (223, 175):
                    n = 77;
                    type = "";
                    break;
                case (153, 175):
                    n = 78;
                    type = "";
                    break;
                case (83, 175):
                    n = 79;
                    type = "";
                    break;
                case (13, 175):
                    n = 80;
                    type = "ladder";
                    break;
                case (13, 105):
                    n = 81;
                    type = "";
                    break;
                case (83, 105):
                    n = 82;
                    type = "";
                    break;
                case (153, 105):
                    n = 83;
                    type = "";
                    break;
                case (223, 105):
                    n = 84;
                    type = "";
                    break;
                case (293, 105):
                    n = 85;
                    type = "";
                    break;
                case (363, 105):
                    n = 86;
                    type = "";
                    break;
                case (433, 105):
                    n = 87;
                    type = "snake";
                    break;
                case (503, 105):
                    n = 88;
                    type = "";
                    break;
                case (563, 105):
                    n = 89;
                    type = "";
                    break;
                case (633, 105):
                    n = 90;
                    type = "";
                    break;
                case (633, 35):
                    n = 91;
                    type = "";
                    break;
                case (563, 35):
                    n = 92;
                    type = "";
                    break;
                case (503, 35):
                    n = 93;
                    type = "snake";
                    break;
                case (433, 35):
                    n = 94;
                    type = "";
                    break;
                case (363, 35):
                    n = 95;
                    type = "snake";
                    break;
                case (293, 35):
                    n = 96;
                    type = "";
                    break;
                case (223, 35):
                    n = 97;
                    type = "";
                    break;
                case (153, 35):
                    n = 98;
                    type = "snake";
                    break;
                case (83, 35):
                    n = 99;
                    type = "";
                    break;
                case (13, 35):
                    n = 100;
                    type = "";
                    break;
                default:
                    n = 0;
                    type = "";
                    break;
            }
            id = n;
            eventType = type;
        }
        public Point GetSpacePosition(int n)
        {
            return position;
        }
    }
}
