using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var Board = new Board();
            var newboard = Board.GetBoard();

            var check = new RuleCheck();

            check.Solve(newboard);
            Console.ReadLine();

        }
    }
}
