using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
class Program
{
    static void Main()
    {
        // Dictionary to store user preferences
        Dictionary<string, string> userPreferences = new Dictionary<string, string>();

        // Prompt user for preferred theme
        Console.WriteLine("Choose your preferred theme:");
        Console.WriteLine("1. Light Mode");
        Console.WriteLine("2. Dark Mode");
        Console.Write("Enter the number of your choice: ");

        // Read user input for theme preference
        string themeChoice = Console.ReadLine();

        // Set theme preference based on user input
        switch (themeChoice)
        {
            case "1":
                // Launch a new command prompt with white background for Light Mode
                Process.Start("cmd.exe", "/k color f0");
                userPreferences["Theme"] = "Light Mode";
                break;
            case "2":
                // Add handling for Dark Mode or any other action for choice "2"
                Console.WriteLine("Dark Mode selected.");
                userPreferences["Theme"] = "Dark Mode";
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Dark Mode.");
                // Launch a new command prompt with white background for the default Light Mode
                Process.Start("cmd.exe", "/k color f0");
                userPreferences["Theme"] = "Light Mode";
                break;
        }

         // Dictionary to store language translations
        Dictionary<string,string> languageDictionary = new Dictionary<string, string>();
         languageDictionary.Add("hello", "hola");
        languageDictionary.Add("goodbye", "adios");
        languageDictionary.Add("hello_french", "bonjour");
        languageDictionary.Add("goodbye_french", "au revoir");
        languageDictionary.Add("hello_german", "hallo");
        languageDictionary.Add("goodbye_german", "auf Wiedersehen");
        languageDictionary.Add("hello_italian", "ciao");
        languageDictionary.Add("goodbye_italian", "addio");
        languageDictionary.Add("hello_russian", "привет");
        languageDictionary.Add("goodbye_russian", "до свидания");
        languageDictionary.Add("hello_chinese", "你好");
        languageDictionary.Add("goodbye_chinese", "再见");
        languageDictionary.Add("hello_korean", "안녕하세요");
        languageDictionary.Add("goodbye_korean", "안녕히 계세요");
        languageDictionary.Add("hello_portuguese", "olá");
        languageDictionary.Add("goodbye_portuguese", "adeus");
        languageDictionary.Add("hello_dutch", "hallo");
        languageDictionary.Add("goodbye_dutch", "vaarwel");
        languageDictionary.Add("hello_polish", "cześć");
        languageDictionary.Add("goodbye_polish", "żegnaj");

   // Randomly select a language from the dictionary
        Random random = new Random();
        List<string> keys = new List<string>(languageDictionary.Keys);
        string randomLanguageKey = keys[random.Next(keys.Count)];

        // Extract the part after the underscore
        string cleanLanguageKey = randomLanguageKey.StartsWith("hello_") ? randomLanguageKey.Substring("hello_".Length) : randomLanguageKey.Substring("goodbye_".Length);

        // Display the randomly selected language key
        Console.WriteLine($"\nRandomly selected language key for translation: {cleanLanguageKey}");

        // Check if the entered word is in the dictionary
        if (languageDictionary.ContainsKey(randomLanguageKey))
        {
            // Get the translation for the randomly selected language
            string translation = languageDictionary[randomLanguageKey];

           // Set console encoding to UTF-16 (Unicode)
            Console.OutputEncoding = Encoding.Unicode;

            // Output the translation
            Console.WriteLine($"Translation for 'hello' in {cleanLanguageKey}: {translation}");
        }
        else
        {
            Console.WriteLine($"Sorry, 'hello' is not in the dictionary for {cleanLanguageKey}.");
        }

        Console.ReadLine();
    }
}