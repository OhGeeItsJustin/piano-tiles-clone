﻿using System;
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
        // Music note properties
        NoteSound sound = new NoteSound();
        Vector2 position;
        Vector2 size;
        Color color;
        int noteValue;
        int points;

        // When MusicNote is created randomly decide what note it will be and set position, colour, and note value
        public MusicNote()
        {
            int certainNote = RandomNumber();
            size.X = 100;
            size.Y = 100;
            points = 1;
            switch (certainNote)
            {
                case 0:
                    noteValue = 0;
                    color = Color.RED;
                    position.X = 50;
                    position.Y = 0;
                    break;
                case 1:
                    noteValue = 1;
                    color = Color.ORANGE;
                    position.X = 250;
                    position.Y = 0;
                    break;
                case 2:
                    noteValue = 2;
                    color = Color.GREEN;
                    position.X = 450;
                    position.Y = 0;
                    break;
                case 3:
                    noteValue = 3;
                    color = Color.YELLOW;
                    position.X = 650;
                    position.Y = 0;
                    break;
            }
        }

        // Returns number from 0 to 3
        public int RandomNumber()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(4);
            return randomNumber;
        }

        // Draw to screen
        public void Draw()
        {
            Raylib.DrawRectangleV(position, size, color);
        }
    }
}
