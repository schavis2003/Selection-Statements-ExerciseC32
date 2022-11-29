using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See of you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");


            //Exercise 1
            //Create a program that allows a user to play a game where they must guess what your favorite number is:
            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            //Number Guessing Game

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random ();
            var number = random.Next(1, 1);

            Console.WriteLine("Input your guess:");
            
            var guess = int.Parse(Console.ReadLine());    

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high! Sorry");

            }
            else if(guess < number)
            {
                Console.WriteLine("Your gues is too low! Sorry");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
