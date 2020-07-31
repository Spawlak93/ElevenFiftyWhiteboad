using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Assessment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            int number = 12;
            string name = "Luna";
            DateTime LunaDOB = new DateTime(1981, 02, 13);

            Console.WriteLine(engine.Sub(number, 7));
            Console.WriteLine(engine.Combine(name, "Lovegood"));

            Console.WriteLine("Are you wearing clothes?");
            string response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "y":
                case "yes":
                    Console.WriteLine("Good!");
                    break;

                case "n":
                case "no":
                    Console.WriteLine("You might want to turn off your webcam....");
                    break;

                case "why":
                case "why?":
                    Console.WriteLine("Because I want to know");
                    break;

                default:
                    Console.WriteLine("fine then don't answer my question");
                    break;
            }
            bool happy;
            while (true)
            {
                Console.WriteLine("Are you happy today?");
                response = Console.ReadLine().ToLower();
                if (response == "y" || response == "yes")
                { 
                    happy = true;
                    break;
                }
                else if (response == "n" || response == "no")
                {
                    happy = false;
                    break;
                }
                else
                    Console.WriteLine("A simple yes or no will do.");
            }

            if (happy == true)
                Console.WriteLine("Great enjoy your day!");
            else
                Console.WriteLine("That sucks");



            Console.WriteLine("How much money do you make in a year?(please dont use $ or words or leave a blank it will break my code and make me sad :'[ )");
            string earningsStr = Console.ReadLine();
            decimal earnings = Convert.ToDecimal(earningsStr);

            if (earnings >= 1000 && earnings <= 10000)
                Console.WriteLine("thats not a lot");

            else if(earnings >= 11000 && earnings <= 50000)
                Console.WriteLine("You are in the median bracket I think?");

            else if(earnings >= 51000 && earnings <= 1000000)
                Console.WriteLine("Are you a software dev?");

            else
                Console.WriteLine("I have no response to that");

            Console.ReadLine();


        }
    }
}
