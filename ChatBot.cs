/*
 * Reference:
 * Troelsen, A. and Japikse, P. (2022). 
 * Pro C# 10 with .NET 6. 11th ed. Apress.
 */

using System;

namespace CyberSecurity
{
    internal class ChatBot
    {
        // Property to store user's name
        public string UserName { get; set; }

        // Start the chatbot conversation
        public void StartChat()
        {
            AskName();

            while (true)
            {
                // Change colour for user input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    ShowResponse("Please enter something.");
                    continue;
                }

                if (input == "exit")
                {
                    ShowResponse("Goodbye! Stay safe online.");
                    break;
                }

                Respond(input);
            }
        }

        // Ask for user's name
        private void AskName()
        {
            Console.Write("Enter your name: ");
            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "User";
            }

            ShowResponse($"Hello {UserName}! Welcome to the Cybersecurity Bot 😊");
        }

        // Determine bot responses
        private void Respond(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
            {
                ShowResponse("I'm here to help you stay safe online! I can answer questions about cybersecurity and give practical tips.");
            }
            else if (input.Contains("purpose"))
            {
                ShowResponse("My purpose is to educate you about cybersecurity, helping you understand risks like phishing, unsafe browsing, weak passwords, and malware, so you can protect yourself online.");
            }
            else if (input.Contains("what can i ask") || input.Contains("topics"))
            {
                ShowResponse("You can ask me about password safety, phishing, safe browsing, malware, social engineering, device security, and other ways to protect your online information. I will explain what they are and give you tips to stay secure.");
            }
            else if (input.Contains("password"))
            {
                ShowResponse("Passwords are your first line of defense. Use long, complex passwords with uppercase and lowercase letters, numbers, and symbols. Avoid personal info or repeated passwords. Using a password manager helps you store them safely. ⚠️ Beware of easy-to-guess passwords like '123456' or 'password'!");
            }
            else if (input.Contains("phishing"))
            {
                ShowResponse("Phishing is when scammers try to trick you into giving personal information through fake emails or websites. Always check the sender, hover over links to verify them, and never share sensitive info online unless you're sure it's safe. ⚠️ Beware of emails or messages asking you to click links or provide personal info!");
            }
            else if (input.Contains("browsing"))
            {
                ShowResponse("Safe browsing means visiting trusted websites and avoiding suspicious downloads. Look for HTTPS in URLs, keep your browser updated, and use antivirus software. ⚠️ Beware of pop-ups or downloads from unknown sources—they could be harmful!");
            }
            else if (input.Contains("malware"))
            {
                ShowResponse("Malware is software designed to harm your device or steal your data. Keep your antivirus updated, avoid suspicious downloads, and never click unknown links. ⚠️ Beware of unexpected attachments or software from untrusted sources!");
            }
            else if (input.Contains("social engineering"))
            {
                ShowResponse("Social engineering is when attackers manipulate you into giving information or access. Be cautious of unsolicited calls, messages, or requests for personal info. ⚠️ Always verify requests and never give sensitive info to strangers!");
            }
            else if (input.Contains("device") || input.Contains("security"))
            {
                ShowResponse("Device security protects your phones, computers, and tablets. Keep your software updated, use strong passwords, enable device encryption, and turn on security features like two-factor authentication. ⚠️ Beware of leaving devices unlocked or using public Wi-Fi without protection!");
            }
            else
            {
                ShowResponse("I didn't quite understand that. You can ask me about password safety, phishing, safe browsing, malware, social engineering, and device security.");
            }
        }

        // Display bot response with typing effect
        private void ShowResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            UIHelper.TypingEffect("Bot: " + message);
            Console.ResetColor();
        }
    }
}