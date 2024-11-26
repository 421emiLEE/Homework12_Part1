using System;
//need to add this to use List
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        List<person> myList = new List<person>();
        List<person> myKidsList = new List<person>();
        List<person> myAverageHeightList = new List<person>();


        person p1 = new person("Mark", 12, 6.2);
        person p2 = new person("John", 22, 5.2);
        person p3 = new person("Rob", 25, 6.0);
        person p4 = new person("Jason", 11, 5.5);
        person p5 = new person("Rick", 17, 5.6);



        myList.Add(p1);
        myList.Add(p2);
        myList.Add(p3);
        myList.Add(p4);
        myList.Add(p5);



        myKidsList.AddRange(from a in myList where a.Age <= 12 select a); //query to get kids
        Console.WriteLine("Persons who can get kids menu: ");
        foreach (var i in myKidsList)
        {
            Console.WriteLine("Name: " + i.Name + " Age: " + i.Age + " Height: " + i.Height);
            
        }

        int personCount  = (from b in myList select b).Count(); //query to get count of persons
        //Console.WriteLine("Total number of persons: " + personCount);
        double average = 0.0;
        double sum = 0.0;
         foreach(var h in myList)
        {
            sum += h.Height;  
        }
        average = sum / personCount;
        Console.WriteLine("The average height is: " + average);
        myAverageHeightList.AddRange(from a in myList where a.Height >= average select a); //query to get persons with height greater than average
        Console.WriteLine("Persons with height higher than the average : ");
        foreach (var i in myAverageHeightList)
        {
            Console.WriteLine("Name: " + i.Name + " Age: " + i.Age + " Height: " + i.Height);
        }

    }

    public class person
    {
        string name;
        int age;
        double height;
        public person(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }


        //three properties

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }

       
    }



}


