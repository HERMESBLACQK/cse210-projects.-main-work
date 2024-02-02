using System;

class Scripture
{

    // initializing the scripture member varialbe as private variables.
    private string _refrence;
    private string _singleVerse;

    public Scripture()
    {
        // default scripture to be displayed if no scripture enterd
        _refrence = "John 3:16";
        _singleVerse = "for God so loved the world that he gave his only begotten son and whosoever ...";

    }

    // method to sdd a new scripture if available
    public void addScripture(string refr, string singleV)
    {
        _refrence = refr;
        _singleVerse = singleV;
    }
    public void addScripture(string refr)
    {
        _refrence = refr;
    }
    // method to display the scripture added
    public void displayScripture()
    {
        //if the length of the string is less than 100 then the scripture and the refrence 
        //should be displayed side by side else it should be displayeďon top of eachother
        if (_singleVerse.Length < 100)
            Console.WriteLine($"{_refrence} {_singleVerse}");
        wordToList();
        if (_singleVerse.Length > 100)
        {
            Console.WriteLine(_refrence);
            Console.WriteLine(_singleVerse);
        }
    }

    public string wordToList()
    {
        char[] delimeter = { ' ' };
        List<string> wordList = _singleVerse.Split(delimeter).ToList();
        // wordList.Add(_singleVerse);

        Console.WriteLine("Press Enter to continue or text 'quit' to end");
        string ans = "";
        // looping through and checking for conditions
        while (_singleVerse != "__" & ans.ToLower() != "quit")
        {
            //using the random functions
            var random = new Random();
            //saving the random number picked from the length of the list into the string variable index.
            int index = random.Next(wordList.Count);
            string wrds = wordList[index];
            //printing the random word replaced with __ to the console.
            Console.WriteLine($"{_refrence} {_singleVerse.Replace(wrds, "___")}");
            ans = Console.ReadLine();
            Console.Clear();
        }
        return $"{wordList}";
    }

    // to load a scripture verse from an external text file
    public void loadFromExt()
    {
        Console.WriteLine("Enter file name");
        string filename = Console.ReadLine();

        // method to read from the external file contents
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

        // looping through the contents of the file and printig it to the console.
        Console.WriteLine("Enter scripture Name");
        string scriptureName = Console.ReadLine();
        foreach (string line in lines)
        {
            if (scriptureName.ToLower() == line) Console.WriteLine(line);
        }

    }
}