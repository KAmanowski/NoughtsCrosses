using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
    class Program
    {
        private static string _p1Name, _p2Name, _p1Symbol, _p2Symbol; // player names and symbols
        private static string[,] _boardpos = new string[3, 3]; // positions on the board


        static void Main(string[] args)
        {
            string input, _nameError = "Please enter a valid name."; // input and error message

            ClearBoard();

            Console.WriteLine("Welcome to the Noughts & Crosses game.");

            for (int x = 1; x < 3; x++) // loops twice to get 2 player names
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
                else { x--; } // if name is not valid, increments x to add extra loop
            }
            Console.Clear();
            for (int x = 1; x < 3; x++) // loops twice to gather both player symbols
            {
                Console.Write("Player {0} symbol:", x);
                input = Console.ReadLine();

                if (ValidateStringInput(input) && (input.ToUpper() == "X" || input.ToUpper() == "O" )) // checks if there is a strig and if it is valid
                {
                    if (x == 1)
                    {
                        _p1Symbol = input.ToUpper();
                    }
                    if (x == 2)
                    {
                        if (_p1Symbol == input.ToUpper()) // checks if it not the same as the first player's
                        {
                            Console.WriteLine("Please enter a valid input.");
                            x--;
                        }
                        else
                        {
                            _p2Symbol = input.ToUpper();
                        }
                    }
                }
                else {
                    Console.WriteLine("Please enter either an 'x' or an 'o'.");
                    x--; }
            }

            Console.ReadLine();

        }

        static void GameStart() // starts the game
        {
            DisplayPlayerNames();
            Draw();
            
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

        static bool ValidateStringInput(string input) // validates whether or not the entered string is empty
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
