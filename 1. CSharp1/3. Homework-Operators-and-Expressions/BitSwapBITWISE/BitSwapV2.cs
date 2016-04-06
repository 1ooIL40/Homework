﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwapV2
{
    class BitSwapV2
    {
        public class Bits
        {
            public int Value;
            public int Position;

            public Bits(int cvalue, int cPos)
            {
                this.Value = cvalue;
                this.Position = cPos;
            }
        }

        static void Main(string[] args)
        {
            //INPUT 
            uint numN = uint.Parse(Console.ReadLine());
            List<int> startPos = new List<int>();
            for (int i =0; i<2;i++)
            {
                startPos.Add(int.Parse(Console.ReadLine()));
            }
            int modK = int.Parse(Console.ReadLine());

            //Create Bits
            List<Bits>[] toSwap = new List<Bits>[startPos.Count];
            for (int i = 0; i < toSwap.Length; i++)
            {
                for (int b = startPos[i]; b < startPos[i] + modK; b++)
                {
                    Bits bit1 = new Bits(0, b);
                    toSwap[i] = new List<Bits>();
                    toSwap[i].Add(bit1);
                }
            }
            //Assign Value to all bits
            for (int i = 0; i < toSwap.Length; i++)
            {
                for(int b = 0; b< toSwap[i].Count; b++)
                {
                    toSwap[i][b].Value = GetValue(numN, toSwap[i][b].Position);
                }
            }
            //switch Bits
            for (int i = 0; i < toSwap.Length-1; i++)
            {
                for(int b = 0; b < toSwap[i].Count;b++ )
                {
                    numN = SwapBits(numN, toSwap[i][b].Value, toSwap[i + 1][b].Position);
                    numN = SwapBits(numN, toSwap[i+1][b].Value, toSwap[i][b].Position);
                }
               
            }

            Console.WriteLine((uint)numN);
        }

        static int GetValue(uint Number, int Position)
        {
            long theMask = 1 << Position;
            long result = Number & theMask;

            return (int)(result >> Position);
        }

        static uint SwapBits(uint Number, int newValue, int toPosition)
        {
            long newNumber;
            long mask = 1 << toPosition;
            long bitValue = Number & mask;
            bitValue >>= toPosition;

            if (bitValue != newValue)
            {
                newNumber = Number ^ mask;
                return (uint)newNumber;
            }
            else
            {
                return Number;
            }
        }
    }
}
