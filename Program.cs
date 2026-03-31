using System;
using System.Threading;

namespace CyberSecurity
{
    internal class Program
    {
        static void Main()
        {
            // Set console color for "cyber" look
            Console.ForegroundColor = ConsoleColor.Green;

            // Play greeting sound (if AudioPlayer exists)
            AudioPlayer.PlayGreeting();

            // -------------------------------
            // Cybersecurity ASCII Art (Padlock)
            // -------------------------------
            string asciiLock = @"
       .--------.
      / .------. \
     / /        \ \
     | |        | |
    _| |________| |_
  .' |_|        |_| '.
  '._____ ____ _____.' 
  |     .'____'.     |
  '.__.'.'    '.'.__.'
  '.__  |      |  __.'
  |   '.'.____.'.'   |
  '.____'.____.'____.'
  '.________________.'
";
            Console.WriteLine(asciiLock);

            // -------------------------------
            // Typing effect intro
            // -------------------------------
            string intro = "\nInitializing Cybersecurity Awareness Bot...\nAccess Granted.\n\n";
            foreach (char c in intro)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            // -------------------------------
            // Banner / Features
            // -------------------------------
            Console.WriteLine(@"
  =====================================================
             CYBERSECURITY AWARENESS BOT
  =====================================================

             Welcome to the Cybersecurity Bot 

                • Password Safety
                • Phishing Alerts
                • Safe Browsing
                • Device Security
                • Social Engineering Tips

        Protect your data. Stay secure online!
  =====================================================
");

            // -------------------------------
            // Start the new ChatBot
            // -------------------------------
            ChatBot bot = new ChatBot();
            bot.StartChat();

            // Reset console color
            Console.ResetColor();
        }
    }
}