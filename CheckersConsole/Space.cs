using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Space
    {
        public bool hasPiece { get; set; }       //True: space has piece, false: otherwise
        public bool isSpaceWhite { get; }        //True: space is white, false: black
        public bool isPieceWhite { get; set; }   //True: piece is white, false: black
        public char character { get; set; }      //a char that represents the space
        
        //Constructor
        public Space(bool isWhite, bool hasPiece = false, bool isPieceWhite = false)
        {
            isSpaceWhite = isWhite;
            this.hasPiece = hasPiece;
            this.isPieceWhite = isPieceWhite;
            character = ' ';
        }

        //Adds a piece to the space, and then assigns it a color
        public void addPiece(bool isPieceWhite)
        {
            if (hasPiece == false)
            {
                hasPiece = true;
                this.isPieceWhite = isPieceWhite;
                if (isPieceWhite)
                {
                    character = 'W';
                }
                else
                {
                    character = 'B';
                }
            }
        }

        //Removes piece from the space
        public void removePiece()
        {
            if(hasPiece == true)
            {
                hasPiece = false;
                character = ' ';
            }
        }
    }
}
