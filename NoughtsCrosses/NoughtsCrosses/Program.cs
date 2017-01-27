using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] _boardpos = new string[3, 3]; //positions on the board
            string input;

            ClearBoard(ref _boardpos);
            Draw(_boardpos);
            Console.ReadLine();

        }

        static void Draw(string[,] _boardpos)
        {
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 0], _boardpos[1, 0], _boardpos[2, 0]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 1], _boardpos[1, 1], _boardpos[2, 1]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 2], _boardpos[1, 2], _boardpos[2, 2]);

        }

        static void ClearBoard(ref string[,] _boardpos)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    _boardpos[x, y] = " ";
                }

            }
        }
    }
}
