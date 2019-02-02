using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchesAndLoops_Console
{
    public enum GenderType { Male = 1, Female, UnDeclared }
    class Program
    {
        static void Main(string[] args)
        {
            string lastName = "Wagner";
            string firstName = "Kate";
            GenderType gender = GenderType.Female;
            switch (gender)
            {
                case GenderType.Male:
                    Console.WriteLine($"Welcome Mr.{lastName}");
                    break;
                case GenderType.Female:
                    Console.WriteLine($"Welcome Mrs.{lastName}");
                    break;
                case GenderType.UnDeclared:
                    Console.WriteLine($"Welcome {firstName} {lastName}");
                    break;
            }

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feelingAsString = Console.ReadLine();
            int feeling = int.Parse(feelingAsString);

            switch (feeling)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Uh oh");
                    break;
                default:
                case 3:
                    Console.WriteLine("Cool");
                    break;
                case 4:
                    Console.WriteLine("That's good");
                    break;
                case 5:
                    Console.WriteLine("That's awesome!");
                    break;
            }

            if (feeling <= 1)
            {
                Console.WriteLine("Oh no that's terrible");
            }
            else if (feeling == 2)
            {
                Console.WriteLine("Uh oh");
            }
            else if (feeling == 3)
            {
                Console.WriteLine("Cool");
            }
            else if (feeling == 4)
            {
                Console.WriteLine("That's good");
            }
            else if (feeling == 5)
            {
                Console.WriteLine("Awesome!");
            }
            else
            {
                Console.WriteLine("That's off the scale");
            }

            Console.ReadLine();

            string name = "Joshua";

            //1 Starting point
            //2 While true, keep looping
            //3 What to do after each loop
            //for  //1     //2     //3
            for (int i = 1; i <= name.Length; i++)
            {
                Console.Write(i);
            }

            //1 Collection being worked on
            //2 Name of current type being worked on
            //3 Current type in collection
            //4 in keyword used to seperate the individual and collection
            //foreach //3  //2   //4  //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            int total = 1;

            //1 Loop runs while this statement is true
            //while   //1
            while (total != 5)
            {
                Console.WriteLine(total);
                total++;
            }

            string response = "n";
            while (response != "y")
            {
                Console.WriteLine("What's your name?");
                string fullName = Console.ReadLine();
                Console.WriteLine($"Hello {name}.");

                Console.WriteLine("Do you want to keep your name? (y/n)");
                response = "n";
            }
        } 
    }
}
