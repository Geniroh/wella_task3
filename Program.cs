using System;

namespace wella_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prime Checker, will you pass our Prime number Game");
            Console.Write("Enter your number to get started: ");
            int pNum = int.Parse(Console.ReadLine());


            if (pNum == 0)
            {
                Console.WriteLine("I see what you did there, but " + pNum + " is needs to be greater than 0");
                Console.Write("Want to try again(y/n): ");
                string tryagain = Console.ReadLine();

                if (tryagain == "y")
                {
                    Console.Write("Enter your number to give it another go: ");
                    pNum = int.Parse(Console.ReadLine());
                }
                else if (tryagain == "n")
                {
                    Console.WriteLine("Thank you for playing");
                }
                else
                {
                    Console.WriteLine("Ensure you selected the right letters with NO CAPS LOCK");
                }
            }

            if (pNum == 1)
            {
                Console.WriteLine("I see what you did there, but " + pNum + " is neither a prime nor composite number");
                Console.Write("Want to try again(y/n): ");
                string tryagain = Console.ReadLine();

                if (tryagain == "y")
                {
                    Console.Write("Enter your number to give it another go: ");
                    pNum = int.Parse(Console.ReadLine());
                }
                else if (tryagain == "n")
                {
                    Console.WriteLine("Thank you for playing");
                }
                else
                {
                    Console.WriteLine("Ensure you selected the right letters with NO CAPS LOCK");
                }
            }

            if (pNum == 2 || pNum == 3 || pNum == 5 || pNum == 7 || pNum == 11 || pNum == 13)
            {
                Console.WriteLine("Congratulations, the number " + pNum + " is a Prime number, you win!");
            }
            else if ((pNum % 2 == 0) || (pNum % 3 == 0) || (pNum % 5 == 0) || (pNum % 7 == 0) || (pNum % 11 == 0) || (pNum % 13 == 0))
            {
                Console.WriteLine("Unfortunately the number " + pNum + " is not a prime number. Try again!");
            }
            else
            {
                Console.WriteLine("Congratulations, the number " + pNum + " is a Prime number, you win!");
            }


        }
    }
}
