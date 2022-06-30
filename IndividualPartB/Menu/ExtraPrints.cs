using IndividualPartB.Menu.VoiceServices;
using IndividualPartB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enums;

namespace IndividualPartB.Menu
{
    public class ExtraPrints
    {
        public static void Start()
        {
            StudentServices studentServices = new StudentServices();
            TrainerServices trainerServices = new TrainerServices();
            AssignmentServices assignmentServices = new AssignmentServices();
            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("0 - Return to Main Menu");
                Console.WriteLine("1 - Student Per Course");
                Console.WriteLine("2 - Trainer Per Course");
                Console.WriteLine("3 - Assignment Per Student Per Course");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                MultiPrint multiPrint = (MultiPrint)input;
                switch (multiPrint)
                {
                    case MultiPrint.ExitMenu: VoiceGuide.ExtraMenuMessage(input); isActive = false; break;
                    case MultiPrint.StudentPerCourse: VoiceGuide.ExtraMenuMessage(input); studentServices.StudentPerCourseList(); break;
                    case MultiPrint.TrainerPerCourse: VoiceGuide.ExtraMenuMessage(input); trainerServices.TrainerPerCourseList(); break;
                    case MultiPrint.AssignmentPerStudentPerCourse: VoiceGuide.ExtraMenuMessage(input); assignmentServices.AssignmentPerStudentPerCourseList(); break;
                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;

                }
            }
        }
    }
}

