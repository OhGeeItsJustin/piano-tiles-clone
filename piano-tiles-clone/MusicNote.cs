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
        NoteSound sound = new NoteSound();
        Vector2 position;
        Vector2 size;
        Color color;
        int points;
    }
}
