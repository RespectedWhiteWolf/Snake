﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake Snake = new Snake(p, 4 , Direction.RIGHT);
            Snake.Drow();
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);
            Snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
