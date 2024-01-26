




using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a sample scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        // Display the complete scripture
        DisplayScripture(scripture);

        // Hide words until all words are hidden
        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            HideRandomWords(scripture);
            DisplayScripture(scripture);
        }

        Console.WriteLine("Program ended.");
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }

    static void HideRandomWords(Scripture scripture)
    {
        List<Word> visibleWords = scripture.Words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            // Choose a random word to hide
            Random random = new Random();
            int indexToHide = random.Next(visibleWords.Count);
            visibleWords[indexToHide].Hide();
        }
    }
}

class Scripture
{
    private List<Word> words = new List<Word>();

    public bool AllWordsHidden => words.All(w => w.IsHidden);

    public Scripture(string referenceText, string scriptureText)
    {
        Reference = new Reference(referenceText);
        InitializeWords(scriptureText);
    }

    public Reference Reference { get; }

    public IReadOnlyList<Word> Words => words;

    public void InitializeWords(string scriptureText)
    {
        string[] wordArray = scriptureText.Split(' ');
        words.AddRange(wordArray.Select(word => new Word(word)));
    }

    public string GetDisplayText()
    {
        return $"{Reference.GetDisplayText()}\n\n{string.Join(" ", words.Select(w => w.GetDisplayText()))}";
    }
}

class Reference
{
    public Reference(string referenceText)
    {
        Text = referenceText;
    }

    public string Text { get; }

    public string GetDisplayText()
    {
        return $"Reference: {Text}";
    }
}

class Word
{
    private bool isHidden;

    public Word(string text)
    {
        Text = text;
        isHidden = false;
    }

    public string Text { get; }

    public bool IsHidden => isHidden;

    public void Hide()
    {
        isHidden = true;
    }

    public string GetDisplayText()
    {
        return isHidden ? "___" : Text;
    }
}
