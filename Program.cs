
using System;
namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            Console.WriteLine(amountOfCars);
            var fireflys = Multiply(60, 2, 4);
            Console.WriteLine(fireflys);

            var answer1 = Methods.Add(2, 2);
            Console.WriteLine(answer1);
            var answer2 = Methods.Multiply(5, 5);
            Console.WriteLine(answer2);
            var answer3 = Methods.Subtract(2, 2);
            Console.WriteLine(answer3);
            var answer4 = Methods.Divide(5, 2);
            Console.WriteLine(answer4);



            //-------------Exercise 1----------
            Console.WriteLine("Hello - what is your first name?");
            string? userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            string? color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            string? animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            string? band = Console.ReadLine();


            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("-------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite color: {animal}");
            Console.WriteLine($"Favorite Anilmal: {band}");

            Console.WriteLine();

            Console.WriteLine($"How old are you {userName}?");
            //Methods.AgeChecker();
        }
    }
}

//int answer1 - methods.add(2,2);
//Console.WriteLine(answer1);