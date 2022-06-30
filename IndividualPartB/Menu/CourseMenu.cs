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
    public class CourseMenu
    {
        public static void Start()
        {
            CourseServices courseServices = new CourseServices();
            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("0 - Return to Main Menu");
                Console.WriteLine("1 - Create a Course");
                Console.WriteLine("2 - Reading All Courses"); 
                Console.WriteLine("3 - Edit a Course");
                Console.WriteLine("4 - Delete a Course");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                Entity course = (Entity)input;
                switch (course)
                {
                    case Entity.ExitMenu: VoiceGuide.CourseMenuMessage(input); isActive = false; break;
                    case Entity.Create: VoiceGuide.CourseMenuMessage(input); courseServices.Add(); break;
                    case Entity.Read: VoiceGuide.CourseMenuMessage(input); courseServices.Read(); break;   
                    case Entity.Edit: VoiceGuide.CourseMenuMessage(input); courseServices.Edit(); break;
                    case Entity.Delete: VoiceGuide.CourseMenuMessage(input); courseServices.Delete(); break;
                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;
                }
            }
        }
    }
}
