using System;

namespace SDDPExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project1 = new Project();
            if (project1.passed())
            {
                Console.WriteLine("You passed the project!");
            }
            else
            {
                Console.WriteLine("You did not passed the project!");
            }
            Console.ReadKey();
        }
    }
}