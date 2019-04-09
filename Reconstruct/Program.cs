
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDrawboard
{
    public class Drawboard
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("hello, world!!");
            Drawboard store = new Drawboard();
            store.Board(3, 3);
        }

        // Properties used for the board 
        string charspacing = " ";
        char width = '|';
        string height = "++";


        public void Board(int h, int w)
        {
            int n = w * 2;

            // Rows, in width
            for (int i = 0; i < n; i++)
            {

                Console.Write("\n");

                // Columns, in height
                for (int j = 0; j < h; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(height);
                    }

                    if (i % 2 == 0)
                    {
                        Console.Write(charspacing + width);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}