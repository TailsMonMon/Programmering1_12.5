using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_12._5 {
    class Program {
        static void Main(string[] args) {

            //      CREATING VECTOR
            string[,] gameGrid = new string[5,5]{ {" ", " 1", " 2", " 3", " 4"},
                                                  {"1", "  ", "  ", "  ", "  "},
                                                  {"2", "  ", "  ", "  ", "  "},
                                                  {"3", "  ", "  ", "  ", "  "},
                                                  {"4", "  ", "  ", "  ", "  "} };

            //      USERS INPUT
            int yInput = 0;
            int xInput = 0;

            //      COUNTS NUMBERS OF ATTEMPTS
            int countAttempts = 0;

            //      RANDOM WHERE THE WIN COORDINATES ARE
            Random winWin = new Random();
            int yWin = winWin.Next(1, 4);
            int xWin = winWin.Next(1, 4);

            //Console.WriteLine("xWin: " + xWin);
            //Console.WriteLine("yWin: " + yWin);
            // Controll of the xWin and yWin

            //      THE GAME
            do {
                for(int i = 0; i < gameGrid.GetLength(0); i++) {
                    for(int j = 0; j < gameGrid.GetLength(0); j++) {
                        Console.Write(gameGrid[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //      USER INPUT
                Console.WriteLine("Nytt skott! ");
                Console.Write("Ange Y-kordinat: ");
                yInput = Convert.ToInt32(Console.ReadLine());
                // Skipped for time:  Exception handling

                Console.Write("Ange X-kordinat: ");
                xInput = Convert.ToInt32(Console.ReadLine());
                // Skipped for time:  Exception handling

                Console.WriteLine(); // Who doen't love some space?

                gameGrid[yInput, xInput] = " *";

                countAttempts++; // adding 1 for every loop

            } while(yInput != yWin || xInput != xWin);
            Console.WriteLine("Hejja dig! Du vann! Det tog dig {0} försök!", countAttempts);
            Console.ReadKey();
        }
    }
}
