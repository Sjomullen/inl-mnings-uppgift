using System;

namespace inlämings_uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int compnum = rnd.Next(1, 100);
            bool status = false;
            int usercount = 0;


            Console.WriteLine("Guess a number between 1 and 100");

            while (!status)
            {
                Console.WriteLine("Please enter a number: ");
                usercount++;
                string input = Console.ReadLine();

                int usernum = int.Parse(input);
                if (usernum == compnum)
                {
                    Console.WriteLine("Congrats you got the right number");
                    Console.WriteLine("You did it on: " + usercount + " tries");
                    status = true;
                }
                else
                {
                    if (usernum < compnum)
                    {
                        Console.WriteLine("The number was to low");
                    }
                    else if(usernum > compnum)
                    {
                        Console.WriteLine("The number was to high");
                    }
                }
            }
        }
    }
}
            


  
