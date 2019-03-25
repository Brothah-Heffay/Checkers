using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Game
    {
        Player p1; //black
        Player p2; //white
        Board b;
        bool gameOver = false;
        bool blacksTurn = true;

        public Game()
        {
            b = new Board();
            b.display();
            playerSetUp();
            //gameTurns();
        }

        public void playerSetUp()
        {
            Console.WriteLine("\nEnter the name of the player playing the black pieces: ");
            string name1 = Console.ReadLine();
            p1 = new Player(name1, true);
            Console.WriteLine("\nEnter the name of the player playing the white pieces: ");
            string name2 = Console.ReadLine();
            p2 = new Player(name2, false);
            Console.WriteLine("{0} (Black) vs {1} (White):", p1.Name, p2.Name);
        }

        public void gameTurns()
        {
            while (!(gameOver))
            {
                //go back and forth player turns, starting with black
                takeTurn(blacksTurn);
                blacksTurn = !blacksTurn;
            }
            //declare game over and winner
        }

        public void takeTurn(bool blacksTurn)
        {
            //check for compulsory jump(s) [implement last]

            //check for legal move (if none, game over)

            //bool legalMove = checkForLegalMove(blacksTurn);
            //if (!legalMove)
            {
                //gameOver
            }

            //enter the space to move from
            //possible outcomes from above: "you don't have a piece there", "please enter space in correct format. ex: "b4"",
            //  "that piece has no legal moves", "which space do you want to move the piece at %space to? (type "back" to move a different piece)"
        }

        //takes whose turn it is (true = blacks turn, false = whites turn), returns true if there is a legal move, false otherwise
        public bool checkForLegalMove(bool blacksTurn)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Game g = new Game();

            Console.ReadLine();
        }
    }
}
