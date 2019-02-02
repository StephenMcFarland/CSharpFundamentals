using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        //Challenge ask the user using a string variable age, name, and favorite food. Write out the input to the console. refer back to code today. Ask questions. 
        //Ask the user first name, last name, age
        //Console.WriteLine("Hello, what is your first name?");
        //    string firstName = Console.ReadLine();

        //Console.WriteLine("What is your last name?");
        //    string lastName = Console.ReadLine();

        //Console.WriteLine("What is your age?");
        //    int age = int.Parse(Console.ReadLine());

        //Console.WriteLine($"Hello,{firstName} {lastName}, you are a {age}.");

        //    Console.WriteLine("Hello " + firstName + " " + lastName + " " + age);
        //    Console.ReadLine();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string hello = "Hello";

            Console.WriteLine(hello + " World!");
            Console.ReadKey();
            //Challenge: Create two string variables one for first name, and one for last name. Using a interpolation write them to the console.
            string firstName = "Kenn";
            string lastName = "Pascascio";
            //String literal
            Console.WriteLine($"{hello} {firstName} {lastName}");
            Console.ReadKey();

            //Uncomment below after reaching the end to show that variables can be reassigned. Use as an example of stack and heap later in the day.
            //lastName = "O'Connnor";

            //Challenge assign them to one variable and print that to the console.
            //Concatenation
            string greeting = hello + " " + firstName + " " + lastName;
            Console.WriteLine(greeting);
            Console.ReadKey();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine($"{hello}, {firstName} {lastName}. You are {age}");
        }
    }
}
