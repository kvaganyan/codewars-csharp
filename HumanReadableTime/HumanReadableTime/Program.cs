using System;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, seconds % 3600 / 60, seconds % 60);
        }
    }
}
