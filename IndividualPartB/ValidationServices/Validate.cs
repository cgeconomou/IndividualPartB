using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.ValidationServices
{
    public class Validate
    {/// <summary>
     /// The method IsAllLetters() is checks if string that takes as a parameter
     /// has only characters or not.
     /// </summary>
     /// <param name="input"></param>
     /// <returns></returns>
        public static bool IsAllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        /// <summary>
        ///  The method Strings() is a method that checks if the user 
        ///  typed characters or not using the method IsAllLetters()
        ///  and ask the user to type again if he type the wrong 
        ///  format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Strings(string input)
        {
            bool isValid = IsAllLetters(input);
            while (!isValid)
            {
                Console.WriteLine("Dont use numbers on this area,pls try again");
                input = Console.ReadLine();
                isValid = IsAllLetters(input);
            };
            return input;
        }
        /// <summary>
        ///   The Integer() method checks if the user type only numbers
        ///  using the TryParse() method and ask the user to type again 
        ///  if he type the wrong format.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Integer(string input)
        {
            int result;
            var isValid = Int32.TryParse(input, out result);
            while (!isValid)
            {
                Console.WriteLine("Use numbers on this area,pls try again");
                input = Console.ReadLine();
                isValid = Int32.TryParse(input, out result);
            }
            return result;
        }

        /// <summary>
        ///   The Doubles() method checks if the user type only numbers
        ///  using the TryParse() method and ask the user to type again
        ///  if he type the wrong format.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double Doubles(string input)
        {
            double result;
            var isValid = double.TryParse(input, out result);
            while (!isValid)
            {
                Console.WriteLine("Use numbers on this area,pls try again");
                input = Console.ReadLine();
                isValid = double.TryParse(input, out result);
            }
            return result;
        }
        /// <summary>
        ///   The Doubles() method checks if the user typed the right format
        ///  using the TryParse() method and ask the user to type again
        ///  if he type the wrong format.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static DateTime Date(string input)
        {
            DateTime result;
            var isValid = DateTime.TryParse(input, out result);
            while (!isValid)
            {
                Console.WriteLine("Your input should be in this format:yyyy/mm/dd");
                input = Console.ReadLine();
                isValid = DateTime.TryParse(input, out result);
            }
            return result;
        }
     

    }

}
