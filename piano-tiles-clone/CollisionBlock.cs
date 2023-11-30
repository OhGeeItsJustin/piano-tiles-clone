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

        public bool CollideWithNote(MusicNote note)
        {
            bool noteCollide = false;
            Vector2 notePosition = note.GetPosition();

            if (notePosition.Y > (position.Y - 2) && notePosition.Y < (position.Y + size.Y + 2))
            {
                if (note.GetNoteValue == 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
                { 
                    noteCollide = true; 
                }

                if (note.GetNoteValue == 1 && Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    noteCollide = true;
                }

                if (note.GetNoteValue == 2 && Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    noteCollide = true;
                }

                if (note.GetNoteValue == 3 && Raylib.IsKeyPressed(KeyboardKey.KEY_R))
                {
                    noteCollide = true;
                }
            }

            return noteCollide;
        }

    }
}
