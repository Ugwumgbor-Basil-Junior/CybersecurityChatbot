using System;
using System.Media;

using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;

            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}