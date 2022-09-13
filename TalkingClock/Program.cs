using System;
using System.Text.RegularExpressions;

namespace TalkingClock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string timeInWord = string.Empty;
                string userinput = string.Empty;
                string time = DateTime.Now.ToString("HH:mm");

                timeInWord = ClockHelper.ConvertTimeToWord(time);
                Console.WriteLine(timeInWord);
                do
                {
                    Console.WriteLine("Do you want to read user provided input time? Please enter 'Y' for yes 'N' for No");
                    userinput = Console.ReadLine();
                }
                while (!(userinput.ToLower() == "y" || userinput.ToLower() == "n"));

                if (userinput.ToLower() == "y")
                {
                    bool isInputTimeFormateIsValid = false;
                    do
                    {
                        Console.WriteLine("Please enter time in hh:mm formate");
                        time = Console.ReadLine().Trim();
                        Regex timeRegex = new Regex(@"^(2[0-3]|[01]?[0-9]):([0-5]?[0-9])$");
                        isInputTimeFormateIsValid = timeRegex.IsMatch(time);
                    }
                    while (!isInputTimeFormateIsValid);
                    timeInWord = ClockHelper.ConvertTimeToWord(time);
                    Console.WriteLine(timeInWord);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something is not working please try after some time");
            }
        }
    }
}
