using System;

class Program
{
    static void Main(string[] args)
    {
        //Reception
        //Created a new instance of the Address class
        Address recePtionAdd = new Address("47th Avenue","Time Square","Manhatma","New York","UK");
        Reception reception = new Reception();
        reception.setEvent("Receptions");
        reception.setTitle("Cultural Exhibition");
        reception.setDesc("Meet People from different parts of the world exhibiting their Cultures and Values");
        reception.setDate("22-04-2023");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        reception.setAddress(recePtionAdd.getFullAdd());


        //Lecture
        Address lectureAdd = new Address("Orson Pratt Hall","Salt Lake","Jackson County","Utah","USA");
        Lecture lecture = new Lecture();
        lecture.setEvent("Lecture");
        lecture.setTitle("Climate Change");
        lecture.setDesc("Lecture on the Effect of climate change on animals");
        lecture.setDate("22-05-2023");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        lecture.setAddress(lectureAdd.getFullAdd());


        //Outdoor
        Address outdoorAdd = new Address("Ojude","Ile-ife","Osun","South west","Nigeria");
        Outdoor outdoor = new Outdoor();
        outdoor.setEvent("Tourism");
        outdoor.setTitle("Touring the ancient city of Ile-ife");
        outdoor.setDate("22-09-2023");
        outdoor.getWeatherInfo("Slight Rain");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        outdoor.setAddress(outdoorAdd.getFullAdd());


        Console.WriteLine($"These are the lists of events available\n1.{reception.shorDesc()}\n2.{lecture.shorDesc()}\n3.{outdoor.shorDesc()}\nWhich will you like to take a look at 1,2 or 3?\n");
        
        string ans = Console.ReadLine();
        if(ans == "1"){
            reception.fullDetails();
        }else if(ans == "2"){
            lecture.fullDetails();
        }else if(ans == "3"){
            outdoor.fullDetails();
        }
    }
}