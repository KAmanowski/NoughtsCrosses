using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
    class Program
    {
        private static string _p1Name, _p2Name; // player names
        private static string[,] _boardpos = new string[3, 3]; // positions on the board


        static void Main(string[] args)
        {
            string input, _nameError = "Please enter a valid name."; // input and error message

            ClearBoard();

            Console.WriteLine("Welcome to the Noughts & Crosses game.");

            for (int x = 1; x < 3; x++)
            {
                Console.Write("Player {0} name:", x);
                input = Console.ReadLine();

                if (ValidateStringInput(input))
                {
                    if (x == 1)
                        _p1Name = input;
                    if (x == 2)
                        _p2Name = input;
                }
                else { x--; }
            }
            Console.Clear();
            DisplayPlayerNames();
            Console.ReadLine();

        }

        static void DisplayPlayerNames() // displays player names
        {
            Console.WriteLine("Player 1: {0}        Player 2: {1}", _p1Name, _p2Name);
        }

        static void Draw() // draws the board
        {
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 0], _boardpos[1, 0], _boardpos[2, 0]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 1], _boardpos[1, 1], _boardpos[2, 1]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", _boardpos[0, 2], _boardpos[1, 2], _boardpos[2, 2]);

        }

        static void ClearBoard() // clears the board
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    _boardpos[x, y] = " ";
                }

            }
        }

        static bool ValidateStringInput(string input) // validates whether or not the entered string is valid
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
