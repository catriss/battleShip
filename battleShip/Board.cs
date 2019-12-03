using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class Board
    {
        byte xSize;
        byte ySize;
        int[,] board;

        public Board (byte xSize, byte ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;
        }

        public void boardSize()
        {
            board = new int[this.xSize, this.ySize];
            for (int i = 0; i < this.xSize; i++)
            {
                for (int j = 0; j < this.ySize; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
    }
}
