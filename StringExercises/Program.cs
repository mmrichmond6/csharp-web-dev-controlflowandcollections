using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            //create a string for a value
            string sentences;
            sentences = "I would not, could not, in a box.  I would not, could not with a fox.  \nI will not eat them in a house.  I will not eat them with a mouse.";
            Console.WriteLine(sentences);

            //use Split method to divide at each space (stored in an array)
            string[] wordArray = sentences.Split(' ');
            Console.WriteLine(wordArray[0]);

            //print entire array
            foreach(string word in wordArray)
            {
                Console.WriteLine(word);
            }

            //print array of words (according to directions)
            Console.WriteLine(string.Join(",", wordArray));

            //split the string into separate sentences
            string[] sentencesArray = sentences.Split("  ");
            Console.WriteLine(string.Join(",", sentencesArray));
        }
    }
}
