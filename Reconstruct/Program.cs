using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GameBoard

namespace DCC_3_GameBoard
{

    public class BoardGame
    {

        int width = 0;
        int height = 0;

        public void CallSize()
        {
            Console.Write("Enter a width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a height: ");
            height = Convert.ToInt32(Console.ReadLine());

            Draw(width, height);
        }


        static void Main(string[] args)
        {
            BoardGame dataStorage = new BoardGame();
            dataStorage.CallSize();
        }

        public void Draw(int w, int h)
        {
            char arrayCount = 'A';

            do
            {
                for (int column = 0; column < w; column++)
                {
                    Console.Write(" {0} ", arrayCount++);
                    if (column == w - 1)
                    {
                        break;
                    }
                    Console.Write("|");
                }
                h--;
                Console.WriteLine();

                if (h > 0)
                {
                    for (int row = 0; row < w; row++)
                    {
                        Console.Write("---");
                        if (row == w - 1)
                        {
                            break;
                        }
                        Console.Write("+");
                    }
                    Console.WriteLine();
                }
            }
            while (h > 0);
        }
    }

    

    class Connect4GameSetUp
    {
        int tokenLocation = 0;
        string userColumnSelect = null;
        List<int> arrayRed = new List<int> { };
        List<int> arrayBlue = new List<int> { };
        IDictionary<int, string> boardPieces = new Dictionary<int, string>();
        List<string> columnA = new List<string> { };
        bool isSpaceTaken = false;
    }
}