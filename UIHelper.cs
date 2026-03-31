using System;
using System.Threading;

namespace CyberSecurity
{
    internal class UIHelper
    {
        // Display chatbot header with ASCII art
        public static void DisplayHeader()
        {
            Console.Clear(); // Clear screen for clean start

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=================================");
            Console.WriteLine("      🤖 CYBERSECURITY BOT");
            Console.WriteLine("=================================");

            Console.WriteLine(@"
            [ 🔒 SAFE ONLINE 🔒 ]
              |\     ____     /|
              | \___|__|___ / |
              |             |
              |   PROTECT   |
              |   YOURSELF  |
              |_____________|
            ");

            Console.ResetColor();
        }

        // Typing animation effect
        public static void TypingEffect(string message)
        {
            Random rand = new Random();

            foreach (char c in message)
            {
                Console.Write(c);

                // Random delay for realistic typing
                Thread.Sleep(rand.Next(15, 40));
            }

            Console.WriteLine();
        }
    }
}