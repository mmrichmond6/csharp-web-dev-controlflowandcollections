using System;
using System.Collections.Generic;


namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudentName;
            Console.WriteLine("Enter your student's Name (or ENTER to finish):");

            //Get student IDs and names
            do
            {
                Console.WriteLine("Student Name:  ");
                string input = Console.ReadLine();
                newStudentName = input;

                if (!Equals(newStudentName, ""))
                {
                    Console.WriteLine("Student ID:  ");
                    int newStudentID = int.Parse(Console.ReadLine());
                    students.Add(newStudentID, newStudentName);

                    //Read in the newline before looping back
                    //Console.ReadLine();
                }

            } while (!Equals(newStudentName, ""));            
           
                //Print class roster
                Console.WriteLine("Class roster:");

                foreach (KeyValuePair<int, string> student in students)
                {
                    Console.WriteLine("Student Name:  " + student.Value + " ID(" + student.Key + ")");
                }
            }
        }
    }
