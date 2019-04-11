using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_3_GameBoard
{
    public class GameBoardSetUp
    {
        int width = 0;
        int height = 0;

        static void Main(string[] args)
        {

            GameBoardSetUp stuff = new GameBoardSetUp();
            stuff.CallSize();

        }

        public void CallSize()
        {
            Console.Write("Enter a width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a height: ");
            height = Convert.ToInt32(Console.ReadLine());

            Draw(width, height);
        }

            public void Draw(int width, int height)
            {
                char arrayCount = 'A';

                do
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(" {0} ", arrayCount++);
                        if (column == width - 1)
                        {
                            break;
                        }
                        Console.Write("|");
                    }
                    height--;
                    Console.WriteLine();

                    if (height > 0)
                    {
                        for (int row = 0; row < width; row++)
                        {
                            Console.Write("---");
                            if (row == width - 1)
                            {
                                break;
                            }
                            Console.Write("+");
                        }
                        Console.WriteLine();
                    }
                }
                while (height > 0);
            }
        }

    }



public class Connect4GameSetUp
{
    public int location;
    public int coins;
    public bool Lockedin;

    public Connect4GameSetUp()
    {
        this.coins = 2;
        this.location = 0;
        this.LockedIn = true;
    }
        
        public void Location()
        {
            
        }
        
        public void Chips()
        {

        }

        public void Locked()
        {
            
        }

    }