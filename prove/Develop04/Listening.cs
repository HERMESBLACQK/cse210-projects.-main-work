using System;
class Listening:Activity{

    public List<string> _listeningQues = new List<string>();
    private List<string> _listeningAns = new List<string>();
    


    //setting the questions to be displayed to the user
    public void setQuestion(string question){
        _listeningQues.Add($"{question}");
    }

    public string random(){
            var random = new Random();
            //saving the random number picked from the length of the list into the string variable index.
            int index = random.Next(_listeningQues.Count);
            string wrds = _listeningQues[index];
            Console.WriteLine(wrds);
            return $"{wrds}";
        }


    //take the returned question and pass it as a parameter to this function 
    public void saveAns(string ques, string ans){
		_listeningAns.Add($"{ques}\n{ans}");
        }


    public void listen(){
        //welcoming message
        displayMessage();
        displaySpinner();

        Console.WriteLine("How long in seconds would you like for your session?");
        string Dur = Console.ReadLine();

        //pass the value from the Dur into the setduration function which returns a string wich will be saved as the time to run the program.
        string q = random();
        // displaySpinner2();

        string timeToRun = setDuration(Dur);
        int start = 0;
        while (start < int.Parse(timeToRun)/4)
        {
            displaySpinner3();
            Console.WriteLine();
            Console.WriteLine("Now start listing items");
            Console.WriteLine(">");
            string ans = Console.ReadLine();
            Console.WriteLine();

            //Saving the answers and specific question to a list for viewing later;
            saveAns(q,ans);

            start += 1;
        }
        Console.WriteLine("Will you like to view your resposes?");
        string yOrN = Console.ReadLine();
        if(yOrN.ToLower() == "yes"){
            displayEntries();
            Console.WriteLine($"Your {timeToRun}s is completed Thanks for your responces");
            displaySpinner();
            finishingMsg();
            return;
        }else if(yOrN.ToLower() == "no"){
            Console.WriteLine($"Your {timeToRun}s is completed Thanks for your responces");
            displaySpinner();
            finishingMsg();
        }
    }
    public void displayEntries(){
        Console.WriteLine("Your list of responses");
            if(_listeningAns.Count<=1){
                foreach(string ans in _listeningAns){
                    Console.WriteLine(ans);
                }
            }else{
                Console.WriteLine("YOU HAVE NO ANSWERS");
            }
    }
}