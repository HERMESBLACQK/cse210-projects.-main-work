using System;
class Word{

    // saved the word as a private string
    private string _words;

    // method to set the word
    public string addWord(string wrd){
        _words = $"{wrd}";
        return _words;
    }
    // method to check the word
    public void checkWord(){
        Console.WriteLine(_words);
    }
}