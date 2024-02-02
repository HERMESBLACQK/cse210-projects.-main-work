using System;
class Reflection:Activity{
    private List<string> _reflectQues = new List<string>();
    private List<string> _reflectLists = new List<string>();

    public void addQues(string rQues){
         _reflectQues.Add(rQues);
    }

    public void addListsPrompt(string ques){
        _reflectLists.Add(ques);
    }
    public void displaRefQues(){
        // randomly display the questions inside the list
        var random = new Random();
        //saving the random number picked from the length of the list into the string variable index.
        int index = random.Next(_reflectQues.Count);
        string wrds = _reflectQues[index];
        Console.WriteLine();
        Console.WriteLine(wrds); //question
        Console.WriteLine();
    }
    public void displayQuesList(int t){
        foreach(var quest in _reflectLists){
                displaySpinner2();
                Console.WriteLine();
                Console.WriteLine(quest);
                Console.WriteLine();
        }
    }
    public void reflect()
    {
        displayMessage();
        displaySpinner();

        Console.WriteLine("How long in seconds would you like for your session?");
        string Dur = Console.ReadLine();

        //pass the value from the Dur into the setduration function which returns a string wich will be saved as the time to run the program.
        string timeToRun = setDuration(Dur);
        int start = 0;
        while (start < int.Parse(timeToRun) / 7)
        {
            displaRefQues();
            displayQuesList(int.Parse(timeToRun));
            start += 1;
        }
        displaySpinner2();
        finishingMsg();
    }
}