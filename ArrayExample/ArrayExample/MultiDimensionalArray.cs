using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class MultiDimensionalArray
    {

        public static void TwoDArray()
        {
            //we are doing a 2d array that has equal legth and heigh for a checkerboard
            //could of been a char, string, new class, whatever but that's not important for the example
            bool?[,] checkerBoard = new bool?[8, 8];

            PopulateCheckerBoard(checkerBoard);
            PrintCheckerBoard(checkerBoard);
        }

        private static void PopulateCheckerBoard(bool?[,] board)
        {
            bool isChecker = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (isChecker)
                        board[i, j] = true;
                    isChecker = !isChecker;
                }
                isChecker = !isChecker;
            }
            for (int i = 5; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (isChecker)
                        board[i, j] = false;
                    isChecker = !isChecker;
                }
                isChecker = !isChecker;
            }
        }

        private static void PrintCheckerBoard(bool?[,] board)
        {
            Console.WriteLine("Checkerboard");
            Console.WriteLine("");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == true)
                        Console.Write("x");
                    if (board[i, j] == false)
                        Console.Write("o");
                    if (board[i, j] == null)
                        Console.Write("+");
                }
            }
            Console.WriteLine("");
        }
        
        public static void ThreeDArray()
        {
            //most languages let you do any X amount of dimensions in an array
            //the numbers don't have to be the same, you can have an array thats 3 by 5 sized, or 1 by 8 by 4, anything really
            char[,,] letters = new char[3,3,3];

            PopulateLetters(letters);
            PrintLetters(letters);

        }

        private static void PopulateLetters(char[,,] letters)
        {
            char letter = 'a';
            
            for (int x = 0; x < letters.GetLength(1); x++)
            {
                for (int y = 0; y < letters.GetLength(1); y++)
                {
                    for (int z = 0; z < letters.GetLength(2); z++)
                    {
                        letters[x, y, z] = letter;
                        letter++;
                    }
                }
            }
        }

        private static void PrintLetters(char[,,] letters)
        {
            Console.WriteLine("letters");
            Console.WriteLine("");

            string space = "";
            for (int x = 0; x < letters.GetLength(0); x++)
            {
                for (int y = 0; y < letters.GetLength(1); y++)
                {
                    Console.Write(space);
                    for (int z = 0; z < letters.GetLength(2); z++)
                    {
                        Console.Write(letters[x,y,z]);
                    }
                    Console.WriteLine("");
                }
                space += " ";
            }
            Console.WriteLine("");
        }


    }
}
