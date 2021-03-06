﻿using System;

namespace Cube
{
    class Cube
    {
        static void Main()
        {

            var cube1 = Console.ReadLine();
            int cubeName = Convert.ToInt32(cube1);

            int cubeArrSize = (2 * cubeName) - 1;

            string[,] cubeArray = new string[cubeArrSize, cubeArrSize];

            //PRINT FACE
            for (int row = cubeName - 1; row < 2 * cubeName - 1; row++)
            {
                //TOP-BOT ROW
                if (row == cubeName - 1 || row == 2 * cubeName - 2)
                {
                    for (int col = 0; col < cubeName; col++)
                    {
                        cubeArray[col, row] = ":";
                    }
                }//END TOP-BOT ROW
                else//FILLER
                {
                    cubeArray[0, row] = ":";
                    for (int col = 1; col < cubeName - 1; col++)
                    {
                        cubeArray[col, row] = " ";
                    }
                    cubeArray[cubeName - 1, row] = ":";
                }
            }//END FACE

            ////PRINT TOP
            for (int row = 0; row < cubeName - 1; row++)
            {
                //TOP
                if (row == 0)
                {
                    for (int col = cubeName-1; col < cubeName*2 - 1; col++)
                    {
                        cubeArray[ col, row] = ":";
                    }
                }//END TOP
                else //FILLER
                {
                    cubeArray[(2 * cubeName - 2) - row, row ] = ":"; 
                    for (int col = (2 * cubeName - 1) - row - 2; col > cubeName - row - 1; col--)
                    {
                        cubeArray[col, row] = "/";
                    }
                    cubeArray[ (2 * cubeName - 1) - row - cubeName , row] = ":";
                }
            }//END TOP

            ////PRINT SIDE - TOP
            for (int row = 1; row < cubeName; row++)
            {
                if (row == 1)
                {
                    cubeArray[2 * cubeName - 2, row] = ":";
                }
                else
                {
                    cubeArray[2 * cubeName - 2, row] = ":";
    
                    for (int col = 1; col < row; col++)
                    {
                        cubeArray[2 * cubeName - 2 - col, row] = "X";
                    }
                }
            }//END SIDE TOP

            ////PRINT SIDE BOT
            int modifier = 2;
            for (int row = cubeName; row < 2 * cubeName - 2; row++)
            {
                if (row != 2 * cubeName - 3)
                {

                    for (int col = cubeName; col < 2 * cubeName - 1 - modifier; col++)
                    {
                        cubeArray[col, row] = "X";
                    }
                    cubeArray[2 * cubeName - 1 - modifier, row] = ":";
                }
                else
                {
                    cubeArray[cubeName, row] = ":";
                }
                modifier++;
            }//

            //Print
            for ( int x = 0; x< cubeName*2-1; x++)
            {
                for(int y = 0; y < cubeName*2-1; y++)
                {
                    if (cubeArray[y, x] == null)
                    {
                        cubeArray[y, x] = " ";
                    }
                    Console.Write(cubeArray[y, x]);
                }
                Console.Write("\n");
            }
            //Console.ReadLine();
        }
    }
}
