﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int f = numList[3];
            int p = numList[4];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Point q = pList[0];
            Point w = pList[1];

            Console.ReadLine();
        }
    }
}
