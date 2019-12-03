using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class Ship
    {
        byte lives;
        byte xPos, yPos;
        bool orientation;
        byte shipStatus;

        public Ship(byte lives)
        {
            this.lives = lives;
            //this.xPos = xPos;
            //this.yPos = yPos;
            //this.orientation = orientation;
            this.shipStatus = 3;
        }
        
        

    }
}
