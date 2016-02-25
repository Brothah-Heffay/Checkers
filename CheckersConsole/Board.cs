using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Board
    {
        Space[,] board = new Space[8,8];

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bool white = true;
                    if ((i + j) % 2 == 1) { white = false; }
                    board[i, j] = new Space(white);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(!(board[i,j].isSpaceWhite))
                    {
                        board[i, j].addPiece(false);
                    }                    
                }
            }
            for (int i = 5; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!(board[i, j].isSpaceWhite))
                    {
                        board[i, j].addPiece(true);
                    }
                }
            }
        }

        public void display()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j].character);
                }
                Console.Write("\n");
            }
        }
    }
}
