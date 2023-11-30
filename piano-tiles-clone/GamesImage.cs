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
    internal class GamesImage
    {
        Image goodStamp;
        Image badStamp;
        Image nuteralStamp;
        Texture2D goodStampTexture;
        public GamesImage() 
        {
            goodStamp = LoadImage("../../../Image assets/good job image.jpg");
            goodStampTexture = LoadTextureFromImage(goodStamp);

            //bad stamp 


        }

        public void DisplayGoodImage () 
        {
            DrawTexture(
                goodStampTexture,
                600,
                0,
                Color.WHITE);
        }
    }
}
