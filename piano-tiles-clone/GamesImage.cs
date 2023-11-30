using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

namespace piano_tiles_clone
{
    public class GamesImage
    {
        Image goodStamp;
        Image badStamp;
        Image nuteralStamp;
        Texture2D goodStampTexture;
        Texture2D badStampTexture;
        Texture2D nuteralStampTexture; 
        public GamesImage() 
        {
            //this will be used to load and unload each image 
            goodStamp = LoadImage("../../../Image assets/good job image.png");
            goodStampTexture = LoadTextureFromImage(goodStamp);
            UnloadImage(goodStamp);
            badStamp = LoadImage("../../../Image assets/bad image.png");
            badStampTexture = LoadTextureFromImage(badStamp);
            UnloadImage(badStamp);
            nuteralStamp = LoadImage("../../../Image assets/ok image.png");
            nuteralStampTexture = LoadTextureFromImage(nuteralStamp);
            UnloadImage(nuteralStamp);
             


        }

        public void DisplayGoodImage () 
        {
            BeginDrawing();
            DrawTexture(
                goodStampTexture,
                700,
                0,
                Color.WHITE);
        }
        public void DisplayBadImage () 
        { 
            BeginDrawing();
            DrawTexture(
                 badStampTexture,
                 700,
                 0,
                 Color.WHITE);
        }
        public void DisplayNuteralImage () 
        { 
            BeginDrawing(); 
            DrawTexture(
                nuteralStampTexture,
                700,
                0,
                Color.WHITE);
        }
    }
}
