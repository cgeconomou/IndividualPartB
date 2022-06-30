using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Enums
{
    internal class Enums
    {
        public enum Choice
        {
            ExitMenu = 0,
            StudentMenu = 1,
            TrainerMenu,
            CourseMenu,
            AssignmentMenu,
            ExtraPrints,
        }

        public enum Entity
        {
            ExitMenu = 0,
            Create = 1,
            Read,
            Edit,
            Delete,
        }
        public enum MultiPrint
        {
            ExitMenu = 0,
            StudentPerCourse,
            TrainerPerCourse,
            AssignmentPerStudentPerCourse,
        }
    }
}
