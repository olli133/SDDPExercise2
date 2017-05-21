using System;
using System.Collections.Generic;
using System.Text;

namespace SDDPExercise2
{
    class GradedCourse : Course
    {
        public int _grade;

        public GradedCourse(String name, int grade) : base(name)
        {
            switch(grade)
            {
                case 20:
                    _grade = grade;
                    break;
                case 18:
                    _grade = grade;
                    break;
                case 14:
                    _grade = grade;
                    break;
                case 10:
                    _grade = grade;
                    break;
                case 8:
                    _grade = grade;
                    break;
                case 5:
                    _grade = grade;
                    break;
                case 0:
                    _grade = grade;
                    break;
                default:
                    Console.WriteLine("Creation of Course failed, Please use numerical grades 20 , 18 , 14 , 10 , 8, 5 and and 0.");
                    break;
            }
        }

        public override bool Passed()
        {
            bool returnValue = true;
            switch (_grade)
            {
                case 20:
                    break;
                case 18:
                    break;
                case 14:
                    break;
                case 10:
                    break;
                case 8:
                    returnValue = false;
                    break;
                case 5:
                    returnValue = false;
                    break;
                case 0:
                    returnValue = false;
                    break;
                default:
                    Console.WriteLine("Evaluation failed, please use numerical grades 20 , 18 , 14 , 10 , 8, 5 and and 0.");
                    returnValue = false;
                    break;
            }
            return returnValue;
        }
    }
}
