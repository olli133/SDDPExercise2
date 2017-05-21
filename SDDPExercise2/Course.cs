using System;
using System.Collections.Generic;
using System.Text;

namespace SDDPExercise2
{
    abstract class Course
    {
        public String _name;

        public Course(String name)
        {
            _name = name;
        }

        public abstract bool Passed();
    }
}
