﻿using System;

namespace BitToBit
{
    class BitToBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            string bitString = "";
            string currString = "";

            for ( int i = 0; i< number; i++)
            {
                currString = "";
                currString= Console.ReadLine();
                currString = Convert.ToString(Convert.ToInt32( currString), 2);
                currString = currString.PadLeft(32, '0');
                bitString += currString.Substring(2, 30);
            }

            int currZeros = 0, maxZeros = 0;
            int currOnes = 0, maxOnes = 0;
            char prevBit = ' ';

            foreach (var currBit in bitString)
            {
                if ( currBit== '0')
                {
                    if (prevBit == '1')
                    {
                        currZeros = 0;
                    }
                    currZeros++;
                }

                if (currBit == '1')
                {
                    if (prevBit == '0')
                    {
                        currOnes = 0;
                    }
                    currOnes++;
                }

                if ( currZeros> maxZeros) { maxZeros = currZeros; }
                if ( currOnes > maxOnes) { maxOnes = currOnes; }

                prevBit = currBit;
            }
            
            Console.WriteLine(maxOnes);
            Console.WriteLine(maxZeros);
        }
    }
}
