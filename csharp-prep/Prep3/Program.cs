using System;

class Program
{
    static void Main(string[] args)

    {
        
        int count = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine($"What is the magic number? {number}");
        int guess = -1;
        

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            count++;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You made {count} guess(es).");

            }
        } 

    }
}