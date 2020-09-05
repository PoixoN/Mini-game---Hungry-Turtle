using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Mini_game___Hungry_Turtle
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size * 2 / 3 );
        }
        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 8;

            Turtle.X = 200;
            Turtle.Y = 200;
            WriteT(60);

            Turtle.X = 260;
            Turtle.Y = 200;
            WriteO(30);

            Turtle.X = 400;
            Turtle.Y = 200;
            WriteT(30);

        }
    }
}
