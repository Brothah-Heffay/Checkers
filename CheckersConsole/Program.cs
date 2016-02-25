using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            b.display();
            Console.ReadLine();
        }
    }
}
