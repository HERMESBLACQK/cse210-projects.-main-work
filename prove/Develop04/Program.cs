using System;

class Program
{
    static void Main(string[] args)
    {


        Reflection reflect = new Reflection();
         reflect.setActivity("Reflecting Activity","This activity will help you to calm down and master the art of reflecting");
        //Questions 
        string qone,qtwo,qthree,qfour;
        qone = ("Think of a time when you stood up for someone else");
        qtwo = ("Think of a time when you did something really difficult.");
        qthree = ("Think of a time when you helped someone in need.");
        qfour = ("Think of a time when you did something truly selfless.");
        reflect.addQues(qone);
        reflect.addQues(qtwo);
        reflect.addQues(qthree);
        reflect.addQues(qfour);


        //sub Questions lists
        string one,two,three,four,five,six,seven,eight,nine;
        one = "Why was this experience meaningful to you?";
        two = "Have you ever done anything like this before?";
        three = "How did you get started?";
        four = "How did you feel when it was complete?";
        five = "What made this time different than other times when you were not as successful?";
        // six = "What is your favorite thing about this experience?";
        seven = "What is your favorite thing about this experience?";
        eight = "What did you learn about yourself through this experience?";
        nine = "How can you keep this experience in mind in the future?";
        reflect.addListsPrompt(one);
        reflect.addListsPrompt(two);
        reflect.addListsPrompt(three);
        reflect.addListsPrompt(four);
        reflect.addListsPrompt(five);
        // reflect.addListsPrompt(six);
        reflect.addListsPrompt(seven);
        reflect.addListsPrompt(eight);
        reflect.addListsPrompt(nine);





        string BrName = "Breathing Activity";
        string BrDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing breathe = new Breathing();
        breathe.setActivity(BrName,BrDesc);
        

        string lName = "Listening Activity";
        string lDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Listening listen = new Listening();
        listen.setActivity(lName,lDesc);


        string lq1 = "Who are people that you appreciate?";
        string lq2 = "What are personal strengths of yours?";
        string lq3 = "Who are people that you have helped this week?";
        string lq4 = "When have you felt the Holy Ghost this month?";
        string lq5 = "Who are some of your personal heroes?";
        listen.setQuestion(lq1);
        listen.setQuestion(lq2);
        listen.setQuestion(lq3);
        listen.setQuestion(lq4);
        listen.setQuestion(lq5);





    string displayQ(){
            Console.WriteLine("Hello Develop04 World!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing activity");
            Console.WriteLine("    2. Start Reflecting activity");
            Console.WriteLine("    3. Start listening activity");
            Console.WriteLine("    4.Quit");
            Console.WriteLine("Select a choice from the menu");
            string ans = Console.ReadLine();
            return ans;
        }
       
    bool replay = true;

    while (replay)
    {
         string ans = displayQ();
        if (int.Parse(ans) == 1)
        {
            breathe.breathing();
            // Console.Clear();
            displayQ();
        }
        else if (int.Parse(ans) == 2)
        {
            reflect.reflect();
            // Console.Clear();
            displayQ();
        }
        else if (int.Parse(ans) == 3)
        {
            listen.listen();
            // Console.Clear();
            displayQ();
        }else if(int.Parse(ans) == 4){
            replay = false;
            return;
        }
    }
        
    }
}