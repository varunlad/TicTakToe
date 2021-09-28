using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakToeGame
{
    public class TikTakToeGame
    {
        public void EmptyArray()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length+1; i++)
            {
                board[i] = ' ';
            }           
        }
    }
}
