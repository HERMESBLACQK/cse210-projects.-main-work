using System;
class Activity{
    private string _activityName;
    private string _activityDesc;
    protected string _activityDur;

    public Activity(){
        //default constructor parameters.
		_activityName = "Unknown";
		_activityDesc = "Unknown";
        _activityDur = "";
	}
    
    // setting the member variables
    public string setActivity(string name,string desc){
        _activityName = name;
        _activityDesc = desc;
        return $"{name}\n {desc}";
    }

    // setting the duration of time the program should run for.
    public string setDuration(string dur){
        _activityDur = dur;
        return dur;
        
    }


    // the welcoming messages to display
    public void displayMessage(){
        Console.WriteLine($"{_activityName}\n{_activityDesc}");
    }

    public void displaySpinner(){
        Console.Write("Get Ready...");
        int i = 4;
        while(i<=5){
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Erase the + character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Console.WriteLine();
    }
    public void displaySpinner2(){
        Console.Write("Reflect...");
        int i = 4;
        while(i<=5){
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Erase the + character
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Console.WriteLine();
    }
    public void displaySpinner3(){
        Console.Write("start thinking...");
        int i = 4;
        while(i<=5){
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Erase the + character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Console.WriteLine();
    }
    // the finishing message to display
    public void finishingMsg(){
        Console.WriteLine("   ");
        Console.WriteLine("well done!!");
		Console.WriteLine( $"You have completed another {_activityDur}sec of {_activityName} today");
	}

}