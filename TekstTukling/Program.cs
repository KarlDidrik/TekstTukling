
        while (true)
        {
            Console.WriteLine("Velg en operasjon:");
            Console.WriteLine("1. RotateText");
            Console.WriteLine("2. Change word");
            Console.WriteLine("3. Avslutt");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Skriv inn et ord:");
                    string wordToRotate = Console.ReadLine();
                    string rotatedText = RotateText(wordToRotate);
                    Console.WriteLine($"Resultatet etter rotasjon: {rotatedText}");
                    break;

                case "2":
                    Console.WriteLine("Skriv inn et ord:");
                    string wordToChange = Console.ReadLine();
                    string changedWord = ChangeWord(wordToChange);
                    Console.WriteLine($"Resultatet etter endring: {changedWord}");
                    break;

                case "3":
                    Console.WriteLine("Programmet avsluttes.");
                    return;

                default:
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                    break;
            }

            Console.WriteLine(); 
        }
    

    static string RotateText(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ChangeWord(string text)
    {
        return text.Replace('e', 'a');
    }
