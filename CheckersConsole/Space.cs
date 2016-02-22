using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Space
    {
        bool hasPiece { get; set; }
        bool isSpaceWhite { get; }        //True: space is white, false: black
        bool isPieceWhite { get; set; }   //True: piece is white, false: black
        
        public Space(bool isWhite, bool hasPiece = false, bool isPieceWhite = false)
        {
            isSpaceWhite = isWhite;
            this.hasPiece = hasPiece;
            this.isPieceWhite = isPieceWhite;
        }

        public void addPiece(bool isPieceWhite)
        {
            if (hasPiece == false)
            {
                hasPiece = true;
                this.isPieceWhite = isPieceWhite;
            }
        }

        public void removePiece()
        {
            if(hasPiece == true)
            {
                hasPiece = false;
            }
        }
    }
}
