

using System.Text;

Console.WriteLine("-=HANGMAN=-");

string wordToGuess = GetRandomWord();

Console.WriteLine("  _____");
Console.WriteLine(" |     |");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine("===");

Console.WriteLine();

// Saving the wrong answers.
int wrongAttempts = 0;

// Saving all the letters a player has been used.
List<char> guessedLetters = new List<char>();

// Here we will save the player new word (the letters he has guessed) which will compare to the word he has to guess.
StringBuilder newString = new StringBuilder();
newString.Append('_', wordToGuess.Length);

while (wrongAttempts < 6)
{
    Console.WriteLine("Guess a letter:");

    char currentChar = char.Parse(Console.ReadLine());

    if (!guessedLetters.Contains(currentChar))
    {
        guessedLetters.Add(currentChar);
    }
    else
    {
        Console.WriteLine($"You have already tried the letter '{currentChar}'!");
        Console.WriteLine();
        continue;
    }

    if (!wordToGuess.Contains(currentChar))
    {
        wrongAttempts++;

        if (wrongAttempts == 1)
        {
            Console.WriteLine("  _____");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |     O");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine("===");
        }
        else if (wrongAttempts == 2)
        {
            Console.WriteLine("  _____");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |     O");
            Console.WriteLine(" |    \\|");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine("===");
        }
        else if (wrongAttempts == 3)
        {
            Console.WriteLine("  _____");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |     O");
            Console.WriteLine(" |    \\|/");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine("===");
        }
        else if (wrongAttempts == 4)
        {
            Console.WriteLine("  _____");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |     O");
            Console.WriteLine(" |    \\|/");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |    /");
            Console.WriteLine(" | ");
            Console.WriteLine("===");
        }
        else if (wrongAttempts == 5)
        {
            Console.WriteLine("  _____");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |     O");
            Console.WriteLine(" |    \\|/");
            Console.WriteLine(" |     |");
            Console.WriteLine(" |    / \\");
            Console.WriteLine(" | ");
            Console.WriteLine("===");
        }
        else if (wrongAttempts == 6)
        {
            Console.WriteLine();
            Console.WriteLine($"The letter '{currentChar}' is wrong !");
            Console.WriteLine();
            Console.WriteLine("-=GAME OVER=-");
            break;
        }

        Console.WriteLine($"The letter '{currentChar}' is wrong !");
        Console.WriteLine();
    }
    else
    {
        // If wordToGuess contains the letter which the player has written we will replace the '_' with that letter.
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == currentChar)
            {
                newString[i] = currentChar;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Correct!");
        Console.WriteLine();
        Console.WriteLine(newString.ToString());
        Console.WriteLine();
    }

    if (newString.ToString() == wordToGuess)
    {
        Console.WriteLine("YOU WIN!");
        break;
    }
}

static string GetRandomWord()
{
    string[] words = { "mountain", "whispering", "adventure", "horizon", "midnight", "melodies", "magic", "meadows", "colors", "whispers", "moonlight", "shadows", "castles", "echoes", "flower", "river", "clouds", "silence", "laughter", "window", "garden", "sunset", "silhouette", "beach", "memory", "chocolate", "starlight", "telescope", "guitar", "raindrop", "feather", "journey", "laughter", "crystal", "umbrella", "compass", "whistle", "harmony", "diamond", "fantasy", "kaleidoscope", "paradise", "cascade", "butterfly", "serenade", "whisper", "serenity", "breeze", "treasure", "jewel", "symphony", "harbor", "harbor", "journey", "mystery", "enigma", "wisdom", "fortune", "passion", "promise", "meditation", "discovery", "miracle", "canvas", "brilliance", "sapphire", "soul", "eternity", "celebration", "ballet", "majesty", "whimsy", "cathedral", "serenity", "mystique", "phantom", "phenomenon", "captivation", "reflection", "magnificence", "regeneration", "illumination", "breathtaking", "mysterious", "captivating", "tranquility", "revelation" };

    Random random = new Random();

    int randomWordIndex = random.Next(words.Length + 1);

    string wordToGuess = words[randomWordIndex];
    return wordToGuess;
}