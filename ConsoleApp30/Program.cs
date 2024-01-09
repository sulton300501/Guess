using System;


namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isCorrected = false;
            Random rand = new Random();

            int randomNum = rand.Next(1,11);

            Console.WriteLine("Welcome to the number guessing game...");
            Console.WriteLine("A number between 1 and 10 will be generated");
            Console.WriteLine("If you guess the correct number , you win!");


           

            while (!isCorrected)
            {
                Console.WriteLine("Please enter your guess...");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum)
                {
                    Console.WriteLine("Your guess is to high");
                }else if(guess < randomNum)
                {
                    Console.WriteLine("Your guess is to low");
                }else {

                    Console.WriteLine("Correct!");
                    isCorrected = true;
                        
                     }


            }
            Console.WriteLine("Conguratulation");

            Console.ReadKey();

        }
    }
}