using System;
using System.Collections.Generic;
using System.Linq;

namespace RangeExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            List<List<int>> listGroups = new List<List<int>>();

            for (int i = 0; i < args.Count(); i++)
            {
                if (i == 0 || args[i] - 1 != args[i - 1])
                {
                    listGroups.Add(new List<int>() { args[i] });
                    continue;
                }

                if (args[i] - 1 == args[i - 1])
                {
                    listGroups.Find(list => list.Contains(args[i - 1])).Add(args[i]);
                }
            }

            List<string> returnCommaList = new List<string>();

            foreach(List<int> intList in listGroups)
            {
                if(intList.Count == 1)
                {
                    returnCommaList.Add(intList.First().ToString());
                }
                else if (intList.Count == 2)
                {
                    returnCommaList.Add(intList.First().ToString());
                    returnCommaList.Add(intList.Last().ToString());
                }
                else if(intList.Count > 2)
                {
                    returnCommaList.Add(string.Format("{0}-{1}", intList.First(), intList.Last()));
                }
            }

            return string.Join(',',returnCommaList);
        }
    }
}
