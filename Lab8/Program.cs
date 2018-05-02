using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = 
                {"Adam",
                "Bryan",
                "Chris",
                "Danny",
                "Emily",
                "Frank",
                "Grant",
                "Hugh",
                "Ingrid",
                "Janice",
                "Kevin",
                "Larry",
                "Merin",
                "Nancy",
                "Orin",
                "Prentis",
                "Quentin",
                "Rick",
                "Stanley",
                "Tony" };

            string[] FavoriteFood = 
                {"apple",
                "banana",
                "cashew",
                "danish cookies",
                "empanada",
                "frankfurt",
                "gyro",
                "ham",
                "ice cream",
                "jelly",
                "kit kat",
                "lemon",
                "melon",
                "noodles",
                "oranges",
                "pistacchios",
                "quesedilla",
                "reuben",
                "steak",
                "tater tots"};

            string[] Town = 
                {"Albington",
                "Brenton",
                "Creshire",
                "Denton",
                "Elcot",
                "Frenchester",
                "Gamblon",
                "Highmore",
                "Inktown",
                "Jepsen",
                "Krazen",
                "Littlerock",
                "Monsey",
                "Nanuet",
                "Orangeburg",
                "Pittsburgh",
                "Questrock",
                "Richmond",
                "Spring Valley",
                "Tappan"};

            Console.WriteLine("Welcome to our C# class.");
           
            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 1-20)");
                string Input = Console.ReadLine();
                int StudentNumber;
                int.TryParse(Input, out StudentNumber);
                StudentNumber--;

                if (StudentNumber < 0 || StudentNumber >= Names.Length)
                {
                    Console.WriteLine("That wasn't a valid student number");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Student {Input} is {Names[StudentNumber]}. What would you like to know about {Names[StudentNumber]}? (Hometown or Favorite Food)");
                }

                string Input2 = Console.ReadLine();
                
                if (Input2.ToUpper() != "HOMETOWN" && Input2.ToUpper() != "FAVORITE FOOD")
                {
                    Console.WriteLine("That data doesn't exist. (Enter \"Hometown\" or \"Favorite Food\")");
                    continue;
                }
                else if (Input2.ToUpper() == "HOMETOWN")
                {
                    Console.WriteLine($"{Names[StudentNumber]} is from {Town[StudentNumber]}");
                }
                else if (Input2.ToUpper() == "FAVORITE FOOD")
                {
                    Console.WriteLine($"{Names[StudentNumber]}'s favorite food is {FavoriteFood[StudentNumber]}");
                }

                while (true)
                {
                    Console.WriteLine("Would you like to know about another student or Quit?");
                    string Response = Console.ReadLine();

                    if (Response.ToUpper() == "QUIT")
                    {
                        return;
                    }
                    else if (Response.ToUpper() == "YES")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response.");
                    }
                }
                continue;
            } 
        }
    }
}
