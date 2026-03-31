using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;
        private AudioService audioService;
        private UIService uiService;

        // Automatic properties
        public string BotName { get; set; } = "CyberGuardian";
        public string Version { get; set; } = "1.0";
        public bool IsActive { get; set; } = true;

        public Chatbot()
        {
            audioService = new AudioService();
            uiService = new UIService();
        }

        public void Start()
        {
            // Play voice greeting
            audioService.PlayGreeting();

            // Display ASCII art logo
            uiService.DisplayAsciiLogo();

            // Get user name with validation
            GetUserName();

            // Display welcome message
            DisplayWelcomeMessage();

            // Start main conversation loop
            RunConversationLoop();
        }

        private void GetUserName()
        {
            while (string.IsNullOrWhiteSpace(userName))
            {
                uiService.WriteColored("\n[?] Please enter your name: ", ConsoleColor.Cyan);
                userName = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    uiService.WriteColored("[!] Name cannot be empty. Please try again.\n", ConsoleColor.Red);
                }
            }
        }

        private void DisplayWelcomeMessage()
        {
            uiService.DrawBorder();
            uiService.WriteColored($"\n*** WELCOME, {userName.ToUpper()}! ***\n", ConsoleColor.Green);
            uiService.WriteColored($"Hello {userName}! I'm {BotName}, your Cybersecurity Awareness Assistant.\n", ConsoleColor.Yellow);
            uiService.WriteColored($"Version {Version} - Ready to help you stay safe online!\n", ConsoleColor.Cyan);
            uiService.DrawBorder();

            // Typing effect simulation
            uiService.TypewriterEffect($"\nI'm here to teach you about:\n", 30);
            uiService.TypewriterEffect("  🔐 Password Safety\n", 30);
            uiService.TypewriterEffect("  🎣 Phishing Detection\n", 30);
            uiService.TypewriterEffect("  🔒 Safe Browsing Practices\n", 30);
            Thread.Sleep(500);
        }

        private void RunConversationLoop()
        {
            string userInput;

            while (IsActive)
            {
                uiService.WriteColored($"\n[{userName}] > ", ConsoleColor.Cyan);
                userInput = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    uiService.WriteColored("[Bot] I didn't hear anything. Please type a message!\n", ConsoleColor.Red);
                    continue;
                }

                ProcessUserInput(userInput);
            }
        }

        private void ProcessUserInput(string input)
        {
            uiService.WriteColored("[Bot] > ", ConsoleColor.Green);

            if (input.Contains("how are you"))
            {
                uiService.TypewriterEffect($"I'm functioning perfectly, {userName}! Thanks for asking. I'm here 24/7 to help you with cybersecurity awareness.\n", 40);
            }
            else if (input.Contains("purpose") || input.Contains("what can you do"))
            {
                uiService.TypewriterEffect($"My purpose is to educate South Africans about cybersecurity threats like phishing, malware, and social engineering. I can teach you about password safety, recognizing suspicious links, and safe browsing habits!\n", 40);
            }
            else if (input.Contains("what can i ask") || input.Contains("topics"))
            {
                DisplayAvailableTopics();
            }
            else if (input.Contains("password") || input.Contains("passphrase"))
            {
                ProvidePasswordAdvice();
            }
            else if (input.Contains("phish"))
            {
                ProvidePhishingAdvice();
            }
            else if (input.Contains("link") || input.Contains("url") || input.Contains("safe browsing"))
            {
                ProvideLinkSafetyAdvice();
            }
            else if (input.Contains("bye") || input.Contains("exit") || input.Contains("quit"))
            {
                EndConversation();
            }
            else if (input.Contains("help"))
            {
                DisplayHelp();
            }
            else
            {
                uiService.WriteColored("I didn't quite understand that. Could you rephrase? Try asking about 'password safety', 'phishing', or 'safe browsing'!\n", ConsoleColor.Yellow);
            }
        }

        private void DisplayAvailableTopics()
        {
            uiService.DrawBorder();
            uiService.WriteColored("\n📚 TOPICS YOU CAN ASK ME ABOUT:\n", ConsoleColor.Magenta);
            uiService.WriteColored("  • Password safety & best practices\n", ConsoleColor.White);
            uiService.WriteColored("  • How to spot phishing emails\n", ConsoleColor.White);
            uiService.WriteColored("  • Recognizing suspicious links\n", ConsoleColor.White);
            uiService.WriteColored("  • Safe browsing habits\n", ConsoleColor.White);
            uiService.WriteColored("  • Two-factor authentication\n", ConsoleColor.White);
            uiService.DrawBorder();
        }

        private void ProvidePasswordAdvice()
        {
            uiService.DrawBorder();
            uiService.WriteColored("\n🔐 PASSWORD SAFETY TIPS:\n", ConsoleColor.Cyan);
            uiService.TypewriterEffect("  1. Use passwords with at least 12 characters\n", 35);
            uiService.TypewriterEffect("  2. Combine uppercase, lowercase, numbers, and symbols\n", 35);
            uiService.TypewriterEffect("  3. Never reuse passwords across different accounts\n", 35);
            uiService.TypewriterEffect("  4. Use a password manager like Bitwarden or LastPass\n", 35);
            uiService.TypewriterEffect("  5. Enable Two-Factor Authentication (2FA) whenever possible\n", 35);
            uiService.WriteColored("\n  💡 Did you know? 'Passphrase' (e.g., Blue-House-Sunshine-42) is often stronger than complex passwords!\n", ConsoleColor.Green);
            uiService.DrawBorder();
        }

        private void ProvidePhishingAdvice()
        {
            uiService.DrawBorder();
            uiService.WriteColored("\n🎣 SPOTTING PHISHING EMAILS:\n", ConsoleColor.Red);
            uiService.TypewriterEffect("  ⚠️ Check the sender's email address carefully\n", 35);
            uiService.TypewriterEffect("  ⚠️ Look for spelling and grammar mistakes\n", 35);
            uiService.TypewriterEffect("  ⚠️ Hover over links before clicking (don't click suspicious ones!)\n", 35);
            uiService.TypewriterEffect("  ⚠️ Be wary of urgent or threatening language\n", 35);
            uiService.TypewriterEffect("  ⚠️ Never share personal info via email\n", 35);
            uiService.WriteColored("\n  🚨 Real banks and companies will NEVER ask for your password via email!\n", ConsoleColor.Yellow);
            uiService.DrawBorder();
        }

        private void ProvideLinkSafetyAdvice()
        {
            uiService.DrawBorder();
            uiService.WriteColored("\n🔗 SAFE BROWSING & LINK SAFETY:\n", ConsoleColor.Blue);
            uiService.TypewriterEffect("  ✅ Look for 'https://' - the 's' means secure\n", 35);
            uiService.TypewriterEffect("  ✅ Check for padlock icon in address bar\n", 35);
            uiService.TypewriterEffect("  ✅ Verify website URLs match the company name\n", 35);
            uiService.TypewriterEffect("  ❌ Avoid shortened links (bit.ly, tinyurl) from unknown sources\n", 35);
            uiService.TypewriterEffect("  ❌ Don't click pop-ups claiming you've won a prize\n", 35);
            uiService.WriteColored("\n  🛡️ Use a reputable antivirus and keep it updated!\n", ConsoleColor.Green);
            uiService.DrawBorder();
        }

        private void DisplayHelp()
        {
            uiService.DrawBorder();
            uiService.WriteColored("\n🆘 AVAILABLE COMMANDS:\n", ConsoleColor.Magenta);
            uiService.WriteColored("  • 'how are you' - Check on me\n", ConsoleColor.White);
            uiService.WriteColored("  • 'what's your purpose' - Learn what I do\n", ConsoleColor.White);
            uiService.WriteColored("  • 'what can I ask about' - See all topics\n", ConsoleColor.White);
            uiService.WriteColored("  • 'password safety' - Get password tips\n", ConsoleColor.White);
            uiService.WriteColored("  • 'phishing' - Learn to spot scams\n", ConsoleColor.White);
            uiService.WriteColored("  • 'safe browsing' - Link safety advice\n", ConsoleColor.White);
            uiService.WriteColored("  • 'help' - Show this menu\n", ConsoleColor.White);
            uiService.WriteColored("  • 'bye' or 'exit' - End conversation\n", ConsoleColor.White);
            uiService.DrawBorder();
        }

        private void EndConversation()
        {
            uiService.DrawBorder();
            uiService.WriteColored($"\n👋 Goodbye {userName}! Stay safe online and remember: Think before you click!\n", ConsoleColor.Green);
            uiService.TypewriterEffect("\n[Bot] Cybersecurity is everyone's responsibility in South Africa. Stay vigilant!\n", 45);
            uiService.DrawBorder();
            IsActive = false;
            Environment.Exit(0);
        }
    }
}