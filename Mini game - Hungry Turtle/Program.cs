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
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            int eat_x = 200, eat_y = 200;
            GraphicsWindow.BrushColor = "Red"; 
            var eat = Shapes.AddRectangle(10, 10);
            Shapes.Move(eat, eat_x, eat_y);

            Random rand = new Random();

            while(true)
            {
                Turtle.Move(10);
                if ((Turtle.X >= eat_x && Turtle.X <= eat_x + 10) && (Turtle.Y >= eat_y && Turtle.Y <= eat_y + 10))
                {
                    eat_x = rand.Next(0, GraphicsWindow.Width);
                    eat_y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, eat_x, eat_y);
                }    
            }

        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
