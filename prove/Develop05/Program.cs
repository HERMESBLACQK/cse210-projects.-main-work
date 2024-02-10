using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        // initializing a list for the goals to be stored and looped;
        List<Goals> goals = new List<Goals>();
        Simple simple = new Simple();
        Eternal eternal = new Eternal();
        Checklist checklist = new Checklist();
        //initializing the total points
        int gainedPoints = 0;
        // Console.WriteLine("Hello Develop05 World!")
        



        //The question to be run for every question.
        static string[] goalEntry()
        
        {
            Console.WriteLine("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description for your goal? ");

            string goalDesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();


            // Returning lists of string values from the functions
            return new string[]{
                  goalName,
                  goalDesc,
                  goalPoints
                };
        }

        static string[] checkListQues()
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus");
            string bonusTime = Console.ReadLine();
            Console.WriteLine("What is the bonus for accomplishing it that many");
            string accomplishBonus = Console.ReadLine();
            return new string[]{
                bonusTime,
                accomplishBonus
            };
        }


        while (true)
        {
            //This is the question function that will run when app starts.
            string quest()
            {
                Console.WriteLine($"You have {gainedPoints} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options");
                Console.WriteLine("  1. Create New goal");
                Console.WriteLine("  2. List goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Events");
                Console.WriteLine("  6. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                string ans = Console.ReadLine();
                return ans;
            }
            string answer;
            answer = quest();

            if (int.Parse(answer) == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("    1. Simple Goal");
                Console.WriteLine("    2. Eternal Goal");
                Console.WriteLine("    1. Checklist Goal");
                Console.WriteLine("which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                //calling the goal entry function for the goal question and answer prompt;
                // storing the list returned values to be used as parameters inside the new goal instances


                //if 1 is entered
                if (int.Parse(goalType) == 1)
                
                {
                    var goal = goalEntry();
                    string goalName = goal[0];
                    string desc = goal[1];
                    int points = int.Parse(goal[2]);
                    simple.setName(goalName);
                    simple.setDesc(desc);
                    simple.setPoints(points);
                    //Use the getter and setter methods on the base class
                    // add the goal to the goal list.
                    goals.Add(simple);
                    Console.WriteLine(simple.display());
                }
                else if (int.Parse(goalType) == 2)
                {
                    
                    var goal = goalEntry();
                    string goalName = goal[0];
                    string desc = goal[1];
                    int points = int.Parse(goal[2]);
                    eternal.setName(goalName);
                    eternal.setDesc(desc);
                    eternal.setPoints(points);
                    //Use the getter and setter methods on the base class
                    // add the goal to the goal list.
                    goals.Add(eternal);
                     Console.WriteLine(eternal.getName());
                }
                else if (int.Parse(goalType) == 3)
                {
                    
                    var goal = goalEntry();
                    string goalName = goal[0];
                    string desc = goal[1];
                    //If the goal type is Checklist
                    //The special question list for a checklist question.
                    var chkLst = checkListQues();
                    string bonusTime = chkLst[0];
                    string accomplishBonus = chkLst[1];
                    int points = int.Parse(goal[2]);
                    checklist.setName(goalName);
                    checklist.setDesc(desc);
                    checklist.setPoints(points);
                    //Use the getter and setter methods on the base class then save it to a list so that it can be pushed out to an external file.
                    // add the goal to the goal list.
                    
                    goals.Add(checklist);
                }
            }

            //if 2 is entered
            else if (int.Parse(answer) == 2)
            {
                // loop through all the goals inside the list and use the display method on each of them.
                
            }

            //If 3 is entered then ask user to save the goals to an external file
            else if (int.Parse(answer) == 3)
            {
                Console.WriteLine("Enter file name");
                string _fileName = Console.ReadLine();
                //the file extension is programmed already user just need to enter the name, this can be considerd as a simple creativity
                using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
                {
                    foreach (var g in goals)
                    {
                        outputFile.WriteLine(g);
                    }
                }
            }

            //if answer = 4, then display the goals saved to the external text file.
            else if (int.Parse(answer) == 4)
            {
                Console.WriteLine("Enter file name");
                string _fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines($"{_fileName}.txt");
                // looping through the contents of the file and printig it to the console.
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            else if (int.Parse(answer) == 5)
            {
                string[] lines = System.IO.File.ReadAllLines("goalsOne.txt");
                // looping through the contents of the file and printig it to the console.
                Console.WriteLine("The goals are");
                int i = 0;
                foreach (string line in lines)
                {
                    string[] substring = line.Split(",");
                    string goaltitle = substring[0];
                    string title = substring[1];
                    string desc = substring[2];
                    int points = int.Parse(substring[3]);
                    int bonusPoint = int.Parse(substring[4]);
                    int compltdTime = int.Parse(substring[5]);

                    Console.WriteLine($"{i+1}. {title}");
                    // if(){}
                }
                Console.WriteLine("Which goal did you accomplish?");
                String ans = Console.ReadLine();
                
            }
        }
    void displayGoal(Goals goal){
                //use all the getter functions on the goals to display all the properties of each classes.
                Console.WriteLine($"{goal.getName()}");
             }
    }
}
