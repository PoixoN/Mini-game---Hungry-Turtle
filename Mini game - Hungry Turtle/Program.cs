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
        static void Main(string[] args)
        {
            Turtle.Speed = 9;

            int cnt = 0;
            while (cnt < 10)
            {
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnLeft();
                Turtle.Move(25);
                Turtle.TurnLeft();
                ++cnt;
            }
        }
    }
}
