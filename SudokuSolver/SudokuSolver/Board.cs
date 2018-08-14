using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Board
    {
        public int[,] GetBoard()
        {
            return new int[9, 9]
            {
                { 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                { 0, 0, 4, 0, 0, 8, 7, 0, 0 },
                { 0, 2, 0, 3, 0, 0, 9, 0, 0 },
                { 6, 0, 2, 0, 0, 3, 0, 4, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 5, 0, 6, 0, 0, 3, 0, 1 },
                { 0, 0, 3, 0, 0, 5, 0, 8, 0 },
                { 0, 0, 8, 2, 0, 0, 5, 0, 0 },
                { 0, 0, 9, 7, 0, 0, 0, 0, 0 }
            };
        }
    }
}
