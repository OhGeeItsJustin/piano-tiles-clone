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
        // Collision block attributes  
        Vector2 position;
        Vector2 size;
        Color color;

        // When CollisionBlock is created set size, position, and color from passed in values
        public CollisionBlock(int positionX, int positionY, Color color)
        {
            size.X = 100;
            size.Y = 100;
            position.X = positionX;
            position.Y = positionY;
            this.color = color;

        }

        // Draw to screen
        public void Draw()
        {
            Raylib.DrawRectangleV(position, size, color);
        }

        // Checks if a MusicNote object has collided with a CollisionBlock object
        public bool CollideWithNote(MusicNote note)
        {
            bool noteCollide = false;
            Vector2 notePosition = note.GetPosition();

            // If the MusicNote Y position is inside the Y position and the Y position + Y size for the CollisionBlock
            // check to see if the correct key was pressed
            if (notePosition.Y > (position.Y - 10) && notePosition.Y < (position.Y + size.Y + 10))
            {
                if (note.GetNoteValue() == 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
                {
                    noteCollide = true;
                    note.PlayNoteSound();
                }

                if (note.GetNoteValue() == 1 && Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    noteCollide = true;
                    note.PlayNoteSound();
                }

                if (note.GetNoteValue() == 2 && Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    noteCollide = true;
                    note.PlayNoteSound();
                }

                if (note.GetNoteValue() == 3 && Raylib.IsKeyPressed(KeyboardKey.KEY_R))
                {
                    noteCollide = true;
                    note.PlayNoteSound();
                }
            }

            return noteCollide;
        }

    }
}
