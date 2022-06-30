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
    public class StudentMenu
    {

        public static void Start()
        {
            StudentServices studentServices = new StudentServices();

            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("0 - Return to Main Menu");
                Console.WriteLine("1 - Create a Student");
                Console.WriteLine("2 - Reading All Students");
                Console.WriteLine("3 - Edit a Student");
                Console.WriteLine("4 - Delete a Student");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                Entity student = (Entity)input;
                switch (student)
                {
                    case Entity.ExitMenu: VoiceGuide.StudentMenuMessage(input); isActive = false; break;
                    case Entity.Create: VoiceGuide.StudentMenuMessage(input); studentServices.Add(); break;
                    case Entity.Read: VoiceGuide.StudentMenuMessage(input); studentServices.Read(); break;
                    case Entity.Edit: VoiceGuide.StudentMenuMessage(input); studentServices.Edit(); break;
                    case Entity.Delete: VoiceGuide.StudentMenuMessage(input); studentServices.Delete(); break;
                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;
                }
            }
        }

    }
}
