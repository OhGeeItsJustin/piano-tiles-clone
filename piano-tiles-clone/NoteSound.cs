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
            sounds[0] = LoadSound("../../../SoundAssets/QSound.wav");
            sounds[1] = LoadSound("../../../SoundAssets/WSound.wav");
            sounds[2] = LoadSound("../../../SoundAssets/ESound.wav");
            sounds[3] = LoadSound("../../../SoundAssets/RSound.wav");
            buzzer = LoadSound("../../../SoundAssets/Buzzer.wav");
        }
        public void PlayQSound() 
        {
            PlaySound(sounds[0]);
        }
        public void PlayWSound()
        {
            PlaySound(sounds[1]);
        }
        public void PlayESound()
        {
            PlaySound(sounds[2]);
        }
        public void PlayRSound()
        {
            PlaySound(sounds[3]);
        }
        public void PlayBuzzer()
        {
            PlaySound(buzzer);
        }
        public void EndSounds()
        {
            UnloadSound(sounds[0]);
            UnloadSound(sounds[1]);
            UnloadSound(sounds[2]);
            UnloadSound(sounds[3]);
            UnloadSound(buzzer);
            CloseAudioDevice();
        }
    }
}
