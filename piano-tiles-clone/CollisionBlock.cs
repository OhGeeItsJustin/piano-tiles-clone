using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace piano_tiles_clone
{
    public class CollisionBlock
    {
        Vector2 position;
        Vector2 size;
        Color color;

        public CollisionBlock(int positionX, int positionY, Color color)
        {
            size.X = 100;
            size.Y = 100;
            position.X = positionX;
            position.Y = positionY;
            this.color = color;

        }

        public void Draw()
        {
            Raylib.DrawRectangleV(position, size, color);
        }

    }
}
