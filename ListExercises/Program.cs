using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            //static method to find the sum of all the even numbers in a list
            //summing the list of even integers
            static int sumEven(List<int> numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }

                }
                return sum;
            }

            //creating the list
            List<int> numbers = new List<int>();
            int[] numbers_arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers.AddRange(numbers_arr);
            
            //printing the list
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(sumEven(numbers));

            static void fiveLetters(List<string> words)
            {
                foreach (string word in words)
                {
                    if(word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            List<string> words = new List<string>();
            string[] words_arr = { "hello", "my", "good", "friend", "Jill", "You", "bring", "happy", "thoughts" };
            words.AddRange(words_arr);

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            fiveLetters(words);


            string input;

            Console.WriteLine("Enter the number of letters you would like to search:  ");
            
                input = Console.ReadLine();
                int newLetterNumber = int.Parse(input);

            foreach (string word in words)
            {
                if (word.Length == newLetterNumber)
                {
                    Console.WriteLine(word);
                }
            }



        }
    }
}
