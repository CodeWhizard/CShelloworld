using System;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Github!");



            bool keepGoing;
            keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("type yes or no");

                input = Console.ReadLine();

                switch (input)
                {
                    case "yes":
                        Console.WriteLine("you typed yes");
                        break;
                    case "no":
                        Console.WriteLine("you typed no");
                        break;
                    default:
                        Console.WriteLine("you didnt type either yes or no");
                        keepGoing = false;
                        break;
                }
            }


        }
    }
}
