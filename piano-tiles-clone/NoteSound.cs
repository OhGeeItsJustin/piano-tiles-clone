using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;

namespace piano_tiles_clone
{
    internal class NoteSound
    {
        Sound[] sounds = new Sound[4];
        Sound buzzer;
        public NoteSound() 
        {
            InitAudioDevice();
            sounds[0] = LoadSound("../../../SoundAssets/QSound.wav");
       }
        public void PlayQSound() 
        {
            PlaySound(sounds[0]);
        }
        public void EndSounds()
        {
            UnloadSound(sounds[0]);
            CloseAudioDevice();
        }
    }
}
