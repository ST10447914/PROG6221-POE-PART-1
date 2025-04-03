using System;
using System.Speech.Synthesis; 
using System.Threading;

class Chatbot01
{
    static void Main(string[] args)
    {
        // Create a SpeechSynthesizer instance
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Display ASCII Art Header
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
    ▄▄▄▄   ▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄ 
         ██████  ███████ ███████████ ███████ ███████████
         ██░░░██ ██░░░██ ██░░░░░░░██ ██░░░██ ██░░░░░░██
         ██    ██ ██    ██ ██      ██ ██    ██ ██      ██
         ███████  ███████  ████████  ███████  ████████  
         ██░░░██ ██░░░██ ██░░░░░░██ ██░░░██ ██░░░░░░██
         ██    ██ ██    ██ ██      ██ ██    ██ ██      ██
         ██████  ███████  ████████  ██████  ████████  
         -----------------------------------------------------
                     CYBERSECURITY AWARENESS CHATBOT                  
         -----------------------------------------------------
        ");
        Console.ResetColor();

        // Welcome Message with Typing Effect and Voice
        Console.ForegroundColor = ConsoleColor.Green;
        TypeEffect("Welcome to the Cybersecurity Awareness Bot!\n");
        synthesizer.Speak("Welcome to the Cybersecurity Awareness Bot!");
        Console.ResetColor();

        // Ask for the user's name and display a personalized message
        Console.WriteLine("Hello! What's your name?");
        string userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("I didn't catch your name. I'll just call you Cyber Hero!");
            synthesizer.Speak("I didn't catch your name. I'll just call you Cyber Hero!");
            userName = "Cyber Hero";
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Welcome, {userName}, to the Cybersecurity Awareness Bot!");
        synthesizer.Speak($"Welcome, {userName}, to the Cybersecurity Awareness Bot!");
        Console.ResetColor();

        // Section Header and Divider
        Console.WriteLine("========================================");
        Console.WriteLine("                MENU                   ");
        Console.WriteLine("========================================");

        // Interactive Section with Labeled Options
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose an option:");
            Console.WriteLine("(a) Passwords");
            Console.WriteLine("(b) Phishing");
            Console.WriteLine("(c) Browsing");
            Console.WriteLine("(d) How are you");
            Console.WriteLine("(e) What's your purpose");
            Console.WriteLine("(f) What can I ask you about");
            Console.WriteLine("(g) What is two-factor authentication");
            Console.WriteLine("(h) Exit");
            Console.ResetColor();

            Console.Write("\nEnter your choice (a/b/c/d/e/f/g/h): ");
            string userInput = Console.ReadLine()?.ToLower();

            // Detect and respond to invalid inputs
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please type something.");
                synthesizer.Speak("Invalid input. Please type something.");
                Console.ResetColor();
                continue;
            }

            // Responding to user queries
            switch (userInput)
            {
                case "a":
                    string passwordTips = "Strong passwords should be at least 12 characters long and include a mix of letters, numbers, and symbols.";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(passwordTips + "\n");
                    synthesizer.Speak(passwordTips);
                    Console.ResetColor();
                    break;

                case "b":
                    string phishingTips = "Beware of emails or messages asking for personal information. Always verify the sender's identity.Do not click on suspicious links in emails, even if they appear to be from trusted sources. Always hover over links to see the actual URL before clicking.";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(phishingTips + "\n");
                    synthesizer.Speak(phishingTips);
                    Console.ResetColor();
                    break;

                case "c":
                    string browsingTips = "Use HTTPS websites and avoid clicking on unfamiliar links to stay safe online.";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(browsingTips + "\n");
                    synthesizer.Speak(browsingTips);
                    Console.ResetColor();
                    break;

                case "d":
                    string responseHowAreYou = "I'm just a program, but I'm ready to help you stay safe online!";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(responseHowAreYou + "\n");
                    synthesizer.Speak(responseHowAreYou);
                    Console.ResetColor();
                    break;

                case "e":
                    string responsePurpose = "My purpose is to provide cybersecurity tips and help you navigate the digital world safely.";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(responsePurpose + "\n");
                    synthesizer.Speak(responsePurpose);
                    Console.ResetColor();
                    break;

                case "f":
                    string responseAskAbout = "You can ask me about passwords, phishing, browsing safely, and more!";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(responseAskAbout + "\n");
                    synthesizer.Speak(responseAskAbout);
                    Console.ResetColor();
                    break;

                case "g":
                    string response2FA = "Two-factor authentication (2FA) is an extra layer of security that helps protect your online accounts.";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypeEffect(response2FA + "\n");
                    synthesizer.Speak(response2FA);
                    Console.ResetColor();
                    break;


                case "h":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    TypeEffect($"Thank you for chatting, {userName}. Stay safe online! Goodbye.\n");
                    synthesizer.Speak($"Thank you for chatting, {userName}. Stay safe online! Goodbye.");
                    Console.ResetColor();
                    return;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    string defaultMessage = "I didn't quite understand that. Could you rephrase?";
                    TypeEffect(defaultMessage + "\n");
                    synthesizer.Speak(defaultMessage);
                    Console.ResetColor();
                    break;
            }
        }
    }

    // Method for Typing Effect
    static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(50); // Adjust the typing speed if needed
        }
    }
}