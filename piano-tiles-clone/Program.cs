using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

namespace piano_tiles_clone
{
    internal class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title";
        static List<MusicNote> notes = new List<MusicNote>();
        static GamesImage image;
        static CollisionBlock[] collisionBlocks = new CollisionBlock[4];
        static Color[] collisionBlockColors = { Color.RED, Color.ORANGE, Color.GREEN, Color.YELLOW };


        static void Main(string[] args)
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(800, 600, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(60);

            // Setup your game. This is a function YOU define.
            Setup();

            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.WHITE);

                // Your game code here. This is a function YOU define.
                Update();

                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            // Your one-time setup code here
            image = new GamesImage();

            int collisionBlockY = 450;
            int collisionBlockX = 50;
            for (int i = 0; i < collisionBlocks.Length; i++)
            {
                collisionBlocks[i] = new CollisionBlock(collisionBlockX, collisionBlockY, collisionBlockColors[i]);
                collisionBlockX += 200;
            }

            InitAudioDevice();

            for (int j = 0; j < 10; j++)
            {
                MusicNote note = new MusicNote();
                notes.Add(note);
            }
        }

        static void Update()
        {
            for (int i = 0; i < collisionBlocks.Length; i++)
            {
                collisionBlocks[i].Draw();
            }

            notes[0].Draw();
            notes[0].Move();

            //Your game code run each frame here
            Vector2 position = notes[0].GetPosition();
            if (position.Y > 500)
            {
                notes[0].NoteDisappear();
            }
            if (position.Y < 100)
            {
                notes[0].NoteAppear();
            }

            for (int i = 0; i < collisionBlocks.Length; i++)
            {
                if (collisionBlocks[i].CollideWithNote(notes[0]) || notes[0].NextNote())
                {
                    notes.RemoveAt(0);
                }
            }

            Raylib.DrawText("Q", 90, 485, 32, Color.BLACK);
            Raylib.DrawText("W", 290, 485, 32, Color.BLACK);
            Raylib.DrawText("E", 490, 485, 32, Color.BLACK);
            Raylib.DrawText("R", 690, 485, 32, Color.BLACK);
            image.DisplayGoodImage();
        }
    }
}