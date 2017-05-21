using System;
using System.Collections.Generic;
using System.Text;

namespace SDDPExercise2
{
    class BooleanCourse : Course
    {
        public bool _passed;

        public BooleanCourse(String name, bool passed) :base (name)
        {
            _passed = passed;
        }

        public override bool Passed()
        {
            return _passed;
        }
    }
}
