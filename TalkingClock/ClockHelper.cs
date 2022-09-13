

namespace TalkingClock
{
    public class ClockHelper
    {
        public static string ConvertTimeToWord(string inputTime)
        {
            string time = string.Empty;
            string[] inputTimeArray = inputTime.Split(':');

            int.TryParse(inputTimeArray[0], out int hour);
            int.TryParse(inputTimeArray[1], out int minute);

            string[] nums = { "zero", "One", "two", "three", "four",
               "five", "six", "seven", "eight", "nine",
               "ten", "eleven", "twelve", "thirteen",
               "fourteen", "fifteen", "sixteen", "seventeen",
               "eighteen", "nineteen", "twenty", "twenty one",
               "twenty two", "twenty three", "twenty four",
               "twenty five", "twenty six", "twenty seven",
               "twenty eight", "twenty nine",
              };

            if (minute == 0)
            {
                time = nums[ConvertTo12HourFormate(hour)] + " o'clock";
            }
            else if (minute == 59)
            {
                time = "one minute to " + nums[(hour % 12) + 1];
            }
            else if (minute == 15)
            {
                time = "Quarter past " + nums[ConvertTo12HourFormate(hour)];
            }
            else if (minute == 30)
            {
                time = "Half past " + nums[ConvertTo12HourFormate(hour)];
            }
            else if (minute == 45)
            {
                time = "Quarter to " + nums[(hour % 12) + 1];
            }
            else if (minute <= 30)
            {
                time = nums[minute] + " past " + nums[ConvertTo12HourFormate(hour)];
            }
            else if (minute > 30)
            {
                time = nums[60 - minute] + " to " + nums[(hour % 12) + 1];
            }

            return time.Substring(0, 1).ToUpper() + time.Substring(1);
        }

        public static int ConvertTo12HourFormate(int hour)
        {
            if (hour > 12)
            {
                return hour % 12;
            }
            else if (hour == 0)
            {
                return 12;
            }
            return hour;
        }
    }
}
