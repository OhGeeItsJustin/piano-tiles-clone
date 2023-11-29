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
        // Music note properties
        //NoteSound sound = new NoteSound();
        Vector2 position;
        Vector2 size;
        Vector2 speed;
        Color color;
        int noteValue;
        int points;

        // When MusicNote is created randomly decide what note it will be and set position, colour, and note value
        public MusicNote()
        {
            int certainNote = RandomNumber();
            size.X = 100;
            size.Y = 0;
            speed.Y = 5;
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

        // Move music note object on Y horizontal
        public void Move()
        {
            position.Y += speed.Y * Raylib.GetFrameTime();
        }

        // Return notes X and Y position for collision dectection
        public Vector2 GetPosition()
        {
            return position;
        }

        // Function will be used when music note hits position Y 500 or greater to make note disappear off screen
        public void NoteDisappear()
        {
            size.Y--;
        }

        // Function will be used to make music note slowly grow when its first created on the top of the screen until it hits position Y of 100 where it will stay at the size 100
        // Will make the music note look like its slowly coming in from top of the screen
        public void NoteAppear()
        {
            if (size.Y < 100)
            {
                size.Y++;
            }
            else
            {
                speed.Y = 80;
            }
        }

        // If music note is near the bottom of the screen return true
        // Will be used to start displaying the next note when this current note is near the bottom of screen
        public bool NextNote()
        {
            bool newNote = false;
            if (size.Y >= 0 && position.Y > 400)
            {
                newNote = true;
            }

            return newNote;
        }
    }
}
