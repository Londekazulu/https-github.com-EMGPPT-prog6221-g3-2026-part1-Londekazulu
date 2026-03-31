using System;
using System.Media;

namespace CyberSecurity
{
    internal class AudioPlayer
    {
        // This method plays a voice greeting when the program starts
        public static void PlayGreeting()
        {
            try
            {
                // Create a SoundPlayer object with the WAV file
                SoundPlayer player = new("greeting.wav");
                player.PlaySync(); // Play the audio and wait until it finishes
            }
            catch
            {
                // If the file is missing or can't play, show a warning
                Console.WriteLine("⚠️ Audio file not found.");
            }
        }
    }
}