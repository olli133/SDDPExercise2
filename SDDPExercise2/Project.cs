using System;
using System.Collections.Generic;
using System.Text;

namespace SDDPExercise2
{
    class Project
    {
        BooleanCourse _bc1;
        BooleanCourse _bc2;

        GradedCourse _gc1;
        GradedCourse _gc2;

        public Project()
        {
            _bc1 = new BooleanCourse("Project", true);
            _bc2 = new BooleanCourse("Seminar Paper", true);

            _gc1 = new GradedCourse("IT Controlling", 8);
            _gc2 = new GradedCourse("Software Engineering", 18);
        }

        public bool passed()
        {
            Course[] projectCourses = new Course[] { _bc1, _bc2, _gc1, _gc2 };
            int numberPassed = 0;
            foreach (Course course in projectCourses)
            {
                if (course.Passed())
                {
                    numberPassed++;
                }
            }
            return numberPassed >= 3;
        }
    }
}
