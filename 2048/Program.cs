﻿using System;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ascii = new string[,] {
                {"  ᶤᶤᶤᶤ   "," ▢a▢b▢c  ","▢▢▢▢▢▢▢▢ "," ▢▢▢▢▢▢  ","  ▢▢▢▢  "}, //0
                {"/--------\\ ","|        | ","|  -01-  | ","|        | ","\\--------/ "}, //1
                {"/--------\\ ","|        | ","|  -02-  | ","|        | ","\\--------/ "}, //2
                {"/--------\\ ","|        | ","|  -04-  | ","|        | ","\\--------/ "}, //3
                {"/--------\\ ","|        | ","|  -08-  | ","|        | ","\\--------/ "}, //4
                {"/--------\\ ","|        | ","|  -16-  | ","|        | ","\\--------/ "}, //5
                {"/--------\\ ","|        | ","|  -32-  | ","|        | ","\\--------/ "}, //6
                {"/--------\\ ","|        | ","|  -64-  | ","|        | ","\\--------/ "}, //7
                {"/--------\\ ","|        | ","| -0128- | ","|        | ","\\--------/ "}, //8
                {"/--------\\ ","|        | ","| -0256- | ","|        | ","\\--------/ "}, //9
                {"/--------\\ ","|        | ","| -0512- | ","|        | ","\\--------/ "}, //10
                {"/--------\\ ","|        | ","| -1024- | ","|        | ","\\--------/ "}, //11
                {"/--------\\ ","|        | ","| -2048- | ","|        | ","\\--------/ "}  //12
            };

            int[,] map = new int[,] { { 0, 1, 2, 3 }, { 1, 2, 3, 4 }, { 2, 4, 5, 6 }, { 9, 10, 11, 12 } };

            for (var y = 0; y < 4; y++)
            {
                for (var n = 0; n < 5; n++)
                {
                    for (var x = 0; x < 4; x++)
                    {
                        Console.Write(ascii[map[y, x], n]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
