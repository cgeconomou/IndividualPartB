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
    public static class AssignmentMenu
    {
        public static void Start()
        {
            AssignmentServices assignmentServices = new AssignmentServices();
            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("0 - Return to Main Menu");
                Console.WriteLine("1 - Create a Assignment");
                Console.WriteLine("2 - Reading All Assignments");
                Console.WriteLine("3 - Edit a Assignment");
                Console.WriteLine("4 - Delete a Assignment");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                Entity assignment = (Entity)input;
                switch (assignment)
                {
                    case Entity.ExitMenu: VoiceGuide.AssignmentMenuMessage(input); isActive = false; break;
                    case Entity.Create: VoiceGuide.AssignmentMenuMessage(input); assignmentServices.Add(); break;
                    case Entity.Read: VoiceGuide.AssignmentMenuMessage(input); assignmentServices.Read(); break;
                    case Entity.Edit: VoiceGuide.AssignmentMenuMessage(input); assignmentServices.Add(); break;
                    case Entity.Delete: VoiceGuide.AssignmentMenuMessage(input); assignmentServices.Delete(); break;
                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;
                }
            }
        }
    }
}
