using IndividualPartB.Menu.VoiceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enums;

namespace IndividualPartB.Menu
{
    public class MainMenu
    {
        //ta Service 8a mpoun san properties edw

        public static void Start()
        {
            VoiceGuide.VoiceMessage("Welcome to our program..");
            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("0 - Exit Program");
                Console.WriteLine("1 - StudentMenu");
                Console.WriteLine("2 - TrainerMenu");
                Console.WriteLine("3 - CourseMenu");
                Console.WriteLine("4 - AssignmentMenu");
                Console.WriteLine("5 - Extra Prints");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                Choice entity = (Choice)input;
                switch (entity)
                {
                    case Choice.ExitMenu: isActive = false; VoiceGuide.MainMenuMessage(input); break;
                    case Choice.StudentMenu: VoiceGuide.MainMenuMessage(input); StudentMenu.Start(); break;
                    case Choice.TrainerMenu: VoiceGuide.MainMenuMessage(input); TrainerMenu.Start(); break;
                    case Choice.CourseMenu: VoiceGuide.MainMenuMessage(input); CourseMenu.Start(); break;   
                    case Choice.AssignmentMenu: VoiceGuide.MainMenuMessage(input); AssignmentMenu.Start(); break;
                    case Choice.ExtraPrints: VoiceGuide.MainMenuMessage(input); ExtraPrints.Start(); break;

                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;
                }
            }
        }


    }
}
