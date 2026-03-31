using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class UIService
    {
        public void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string logo = @"
    ╔══════════════════════════════════════════════════════════════════════╗
    ║                    🔒 CYBERSECURITY AWARENESS BOT 🔒                 ║
    ║                                                                      ║
    ║         ██████╗██╗   ██╗██████╗ ███████╗██████╗                     ║
    ║        ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                    ║
    ║        ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                    ║
    ║        ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                    ║
    ║        ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                    ║
    ║         ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                    ║
    ║                                                                      ║
    ║                   PROTECTING SOUTH AFRICA ONLINE                     ║
    ╚══════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine(logo);
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        public void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('═', 80));
            Console.ResetColor();
        }

        public void WriteColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public void TypewriterEffect(string text, int delayMs)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
        }
    }
}