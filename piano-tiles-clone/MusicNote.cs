using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Numerics;

namespace piano_tiles_clone
{
    public class MusicNote
    {
        // music note properties
        NoteSound sound = new NoteSound();
        Vector2 position;
        Vector2 size;
        Color color;
        int points;

        // returns number from 0 to 3
        public int RandomNumber()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(4);
            return randomNumber;
        }
    }
}
