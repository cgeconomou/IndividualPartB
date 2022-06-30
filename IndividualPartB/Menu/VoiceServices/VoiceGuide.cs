using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.VoiceServices
{
    public class VoiceGuide
    {
        public static void VoiceMessage(string message)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();
                Prompt color = new Prompt(message);
                synth.Speak(color);
            }
        }

        public static void MainMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Thanks for using our program.....Have a nice day.."); break;
                case 1: VoiceMessage("This is our student menu"); break;
                case 2: VoiceMessage("This is our trainer menu"); break;
                case 3: VoiceMessage("This is our course menu"); break;
                case 4: VoiceMessage("This is our assignment menu"); break;
                case 5: VoiceMessage("This is extra prints menu"); break;
                default:
                    break;
            }
        }

        public static void StudentMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Welcome to our main menu"); break;
                case 1: VoiceMessage("Please fill all student data that required"); break;
                case 2: VoiceMessage("This is our student List"); break;
                case 3: VoiceMessage("You choose to edit student's data"); break;
                case 4: VoiceMessage("You choose to delete a student,Please give the student's id"); break;
                default: VoiceMessage("Something went wrong,please try again..."); break;

            }
        }
        public static void TrainerMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Welcome to our main menu"); break;
                case 1: VoiceMessage("Please fill all Trainer data that required"); break;
                case 2: VoiceMessage("This is our Trainer List"); break;
                case 3: VoiceMessage("You choose to edit Trainer's data"); break;
                case 4: VoiceMessage("You choose to delete a Trainer,Please give the Trainer's id"); break;
                default: VoiceMessage("Something went wrong,please try again..."); break;

            }
        }
        public static void CourseMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Welcome to our main menu"); break;
                case 1: VoiceMessage("Please fill all Course data that required"); break;
                case 2: VoiceMessage("This is our Course List"); break;
                case 3: VoiceMessage("You choose to edit Course's data"); break;
                case 4: VoiceMessage("You choose to delete a Course,Please give the Course's id"); break;
                default: VoiceMessage("Something went wrong,please try again..."); break;

            }
        }
        public static void AssignmentMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Welcome to our main menu"); break;
                case 1: VoiceMessage("Please fill all Assignment data that required"); break;
                case 2: VoiceMessage("This is our Assignment List"); break;
                case 3: VoiceMessage("You choose to edit Assignment's data"); break;
                case 4: VoiceMessage("You choose to delete a Assignment,Please give the Assignment's id"); break;
                case 7: VoiceMessage("This is our Assignment List......Per Student......Per Course"); break;
                default: VoiceMessage("Something went wrong,please try again..."); break;   

            }
        }
        public static void ExtraMenuMessage(int input)
        {
            switch (input)
            {
                case 0: VoiceMessage("Welcome to our main menu"); break;
                case 1: VoiceMessage("This is our student's List per Course"); break;
                case 2: VoiceMessage("This is our trainer's List per Course"); break;
                case 3: VoiceMessage("This is our Assignment List......Per Student......Per Course"); break;
                default: VoiceMessage("Something went wrong,please try again..."); break;

            }
        }

    }
}
