using System;
using MethodMarathon;

namespace MethodMarathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.FullName("Alan", "Kay"));
            Console.WriteLine(Methods.Times("Alan", "Kay"));
            Console.WriteLine(Methods.IsIn('A', "Kay"));
            Console.WriteLine(Methods.InCommon("Alan", "Kay"));
            Console.WriteLine(Methods.HowMuchLonger("Tim", "Stappen"));
            Console.WriteLine(Methods.ForenameOf("Alan Kay"));
            Console.WriteLine(Methods.SurnameOf("Alan Kay"));
        }
    }

    class Methods
    {

        // I
        public static string FullName(string forename, string surname)
        {
            return forename + " " + surname;
        }
        // II
        public static int Times(string forename, string surname)
        {
            return forename.Length * surname.Length;
        }
        // IIIa
        public static bool IsIn(char character, string word)
        {
            return word.IndexOf(character) > -1;
        }
        // IIIb
        public static string InCommon(string forename, string surname)
        {
            string letters = "";

            foreach(char letter in forename)
            {
                if (IsIn(letter, surname))
                {
                    letters += letter;
                }
            }

            return letters;
        }

        // IV
        public static int HowMuchLonger(string forename, string surname)
        {
            return Math.Max(surname.Length - forename.Length, 0);
        }

        // V
        public static string ForenameOf(string fullname)
        {
            return fullname.Substring(0, fullname.IndexOf(' '));
        }

        // VI
        public static string SurnameOf(string fullname)
        {
            int start = fullname.IndexOf(' ') + 1;
            return fullname.Substring(start, fullname.Length - start);
        }

        // forenameReverse
        // surnameReverse
        // UmAndUmFrontBack
        // UmAndUmBackFront
        // WordCount
        // MeanLength
        // IsSchrikkel
        // NumberOfDayInFeb
        // NumberOfDaysInYear
    }
}