using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Player
    {
        string name;
        bool isPlayer1AndBlack; //Black starts, and thus is player1. Player2 is white and goes after player1
        bool hasWon;

        public Player(string name, bool isBlack)
        {
            this.name = name;
            isPlayer1AndBlack = isBlack;
            hasWon = false;
        }

        public string Name { get { return name; } }
        public bool IsPlayer1AndBlack { get { return isPlayer1AndBlack; } }
        public bool HasWon { get { return hasWon; } set { hasWon = value; } }
    }
}
