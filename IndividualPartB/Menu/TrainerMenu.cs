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
    public class TrainerMenu
    {
        public static void Start()
        {
            TrainerServices trainerServices = new TrainerServices();
            bool isActive = true;
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("0 - Return to Main Menu");
                Console.WriteLine("1 - Create a Trainer");
                Console.WriteLine("2 - Reading All Trainers"); 
                Console.WriteLine("3 - Edit a Trainer");
                Console.WriteLine("4 - Delete a Trainer");
                Console.Write("Choose:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                Entity trainer = (Entity)input;
                switch (trainer)
                {
                    case Entity.ExitMenu: VoiceGuide.TrainerMenuMessage(input); isActive = false; break;
                    case Entity.Create: VoiceGuide.TrainerMenuMessage(input); trainerServices.Add(); break;
                    case Entity.Read: VoiceGuide.TrainerMenuMessage(input); trainerServices.Read(); break;
                    case Entity.Edit: VoiceGuide.TrainerMenuMessage(input); trainerServices.Edit(); break;
                    case Entity.Delete: VoiceGuide.TrainerMenuMessage(input); trainerServices.Delete(); break;
                    default: VoiceGuide.VoiceMessage("Something went wrong.....Please try again..."); break;
                }
            }
        }
    }
}
