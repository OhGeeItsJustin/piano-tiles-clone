using Raylib_cs;
using System.Numerics;

namespace piano_tiles_clone
{
    internal class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title";
        static MusicNote note;
        static GamesImage image;
        static CollisionBlock[] collisionBlocks = new CollisionBlock[4];
        static Color[] collisionColors = { Color.RED, Color.ORANGE, Color.GREEN, Color.YELLOW};
         

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
            note = new MusicNote();
            image = new GamesImage();

            int collisionBlockY = 450;
            int collisionBlockX = 50;
            for (int i = 0; i < collisionBlocks.Length; i++)
            {
                collisionBlocks[i] = new CollisionBlock(collisionBlockX, collisionBlockY, collisionColors[i]);
                collisionBlockX += 200;
            }
        }

        static void Update()
        {
            for (int i = 0; i < collisionBlocks.Length; i++)
            {
                collisionBlocks[i].Draw();
            }
            image.DisplayGoodImage();
            // Your game code run each frame here
            Vector2 position = note.GetPosition();
            if (position.Y > 500)
            {
                note.NoteDisappear();
            }
            if (position.Y < 100)
            {
                note.NoteAppear();
            }
            note.Draw();
            note.Move();
            Raylib.DrawText("Q", 90, 485, 32, Color.BLACK);
            Raylib.DrawText("W", 290, 485, 32, Color.BLACK);
            Raylib.DrawText("E", 490, 485, 32, Color.BLACK);
            Raylib.DrawText("R", 690, 485, 32, Color.BLACK);
        }
    }
}