using System;

using System.Collections.Generic;
// class Program
// {
// Defined
/*Encapsulation is the process of keeping the implementation details of a program hidden and providing 
a well defined interface for interracting with 
other objects or code modules Encapsulation can enhance maintainability, reduce complexity and improve security by
limiting the direct acces other objects or code modules have to the internal state or behavior of a specific module
common techniques for encapsulation is by using access modifiers like private, public and protected in OOP and use of
closures and moduleśin functional programming*/

/*BENEFITS OF ENCAPSULATION
1. Improves maintainability: Encapsulation helps to isolate changes in a code module or object, making it easier 
   to modify and update without breaking other parts of the codebase.
2. Reduce complexity: By hiding the implementation details, encapsulation can simplify code and reduce its complexity
   making it easier to understand and wrk with.
3. Increase Security: Encapsulation can help protect sensitive data and prevent unauthorized access by limiting direct
   access to the internal state or behavior
4. Better abstraction: Encapsulation allows code to be abstracted and treated like a blsck box, making it easier to reason
   about and reuse in other parts of the system.
5. Easirt testing: Encapsulated code modules and objects are often easier to test because their behavior can be defined and 
   tested independently of other parts of the system.

APPLICATIONS
1. Object-Oriented Programming (OOP):
   Encapsulation is a fundamental concept in oop, and it is used define classes with well-defined interfaces, making it easier 
   to create reusable and modular code.
2. Functional Programming: In functional programming, encapsulation can be achieved through the use of closures and modules,
   which can be used to reduce effets and make a code more predictable.
3. Data Privacy: Encapsulation can be used to limit access to sensitive data by hiding if behind an interface or a set of defined
   functions. this can help to increase the security of a system.
4. Web Development: Encapsulatuon is commonly used in web development to seperate the presentatuon layer (HTML,CSS etc) from the
   business and logic data access layers.
5. Distributed Systems: Encapsulation can help to manage the complexity of distributed system by isolationg different components 
   from each other and providing a clear interface for communication.
*/



// Personal Definition
/*Encapsulation is the process of keeping the internal structure of a program secure from being polluted by other
 external codes or program and only exposing a safe well defined space where other codes or program can interract with it without breaking it.*/
 class program{
    static void Main(string[] args)
    {
        // Console.WriteLine("Book: ");
        // string bookName = Console.ReadLine();

        // Console.WriteLine("Chapter: ");
        // string chapt = Console.ReadLine();

        // Console.WriteLine("verse: ");
        // string ver = Console.ReadLine();

        // Console.WriteLine("End Verse?");
        // string end = Console.ReadLine();


        string verse1 = "prov 3:4";
        string proverb = "for God so love the world that he gave his only begotten .......";
        string verse2 = "matt 5:6";
        string matt = "In the beginning......";
        //the refrence.getRefrence method returns a string so it will be saved in r and the r will be passed into the scripture class for processing.
        Refrence refrence = new Refrence("Matt", "3", "15");
        string r = refrence.getRefrence();
        Console.WriteLine(r);
        Word word = new Word();
        string wrd = word.addWord(proverb);
      //   word.checkWord();
        Scripture scripture = new Scripture();
        scripture.addScripture(r,proverb);
        

        Console.WriteLine("Load Scripture from external file or from available scriptures? yes/no");
        string ans = "";
        if(ans.ToLower() != "no"){
        scripture.displayScripture();
        }else{
         scripture.loadFromExt();
        }








        // Entry newEnt = new Entry();
        // Entry newEnt2 = new Entry();

        // first style
        // newEnt.addScripture(verse1,proverb);
        // newEnt.addScripture(verse2,matt);
        // newEnt.displayQ();

        // second style
        // newEnt2.addScripture2(verse1,proverb);
        // newEnt2.addScripture2(verse2,matt);
        // newEnt2.displayQ2();


        // third style
        // string refr = newEnt.addRef(proverb);
        // string vrse = newEnt.addVerse(verse1);
        // Scripture src = new Scripture();

        // fourth style
        //  string[] srcEnt = {
        //          refr,
        //          vrse
        //      };
        //  src.addScripture(srcEnt);
        //  src.displayScripture();


    }
 }