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
        public void XandO()
        {
            char[] board = new char[10];
            int max = 2;
            for (int i = 1; i < board.Length + 1; i++)
            {
                Console.WriteLine("User Enter X or O");
                char chr;
                chr = Console.ReadKey().KeyChar;
               
                char[] alphabet = { 'X','O' };
                
                Random random = new Random();
                String res = "";
                res = res + alphabet[(int)(random.Next(0, max))];
                Console.WriteLine("\nComputer Enters");
                Console.WriteLine(res);

            }
        }
    }
}
