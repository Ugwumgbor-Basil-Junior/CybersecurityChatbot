using System;
using System.IO;
using System.Media;

namespace CybersecurityChatbot
{
    public class AudioService
    {
        public void PlayGreeting()
        {
           try
            {
                string audioPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "CyberSecurityGreeting.wav"
                );

                if (File.Exists(audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                }
                else
                {
                    Console.WriteLine("[Audio] Greeting file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Audio Error] {ex.Message}");
            }
        }
    }
}