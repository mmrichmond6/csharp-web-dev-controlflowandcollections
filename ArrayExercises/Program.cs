using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
        
            int[] numbers = new int[6] {1, 1, 2, 3, 5, 8};

            //print all numbers in the array
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //print only odd numbers in array
            foreach(int number in numbers) {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
