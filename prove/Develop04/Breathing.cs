using System;
class Breathing:Activity{

    public void breathIn(int t){
        int i = 1;
        Console.Write("Breathe in...");
        while(i<=4){
            
            // Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            // Console.Write("-"); // Replace it with the - character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("|"); // Erase the + character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            Console.Write(i);
            i+=1;
        }
         //divide the user defined running time by 6 so it will serve as the time for the program to pause.
        //  Thread.Sleep(t/6);
        // Console.WriteLine(t/6);
    }

    public void breathOut(int t){
        int i = 4;
        Console.Write("Now breathe out...");
        while(i<=4){
            // Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            // Console.Write("-"); // Replace it with the - character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("|"); // Erase the + character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            Console.Write(i);
            i-=1;
            if(i ==-1){
                return;
            }
        }
        //divide the user defined running time by 6 so it will serve as the time for the program to pause.
        // Thread.Sleep(t/6);
        // Console.WriteLine(t/6);
    }
 public void breathing(){
    displayMessage();
    displaySpinner();

    Console.WriteLine("How long in seconds would you like for your session?");
    string Dur = Console.ReadLine();

    //pass the value from the Dur into the setduration function which returns a string wich will be saved as the time to run the program.
    string timeToRun = setDuration(Dur);
    int start = 0;
    while(start<int.Parse(timeToRun)/7){
        breathIn(int.Parse(timeToRun));
        Console.WriteLine();
        breathOut(int.Parse(timeToRun));
        Console.WriteLine("");
        start+=1;
    }
    finishingMsg();
 }

}