using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        //Creating a few different test cases to do more thorough testing
        Random randomizer = new Random();
        string[] dirArray = new string[] { "NORTH", "SOUTH", "WEST", "EAST" };

        for (int i = 0; i <= 10; i++)
        {
            string[] dirList = new string[randomizer.Next(1, 10)];

            for (int j = 0; j <= dirList.Count() - 1; j++)
            {
                dirList[j] = dirArray[randomizer.Next(0, 4)];
                Thread.Sleep(250);
            }

            Console.WriteLine(string.Join(",", dirList));
        }

        Console.ReadLine();
    }
}

public class DirReduction
{
    public static string[] dirReduc(String[] arr)
    {
        List<string> dirInstructions = new List<string>();
        dirInstructions = arr.Select(a => a.ToUpper()).ToList();

        for (int i = dirInstructions.Count - 1; i > 0; i--)
        {
            if (dirInstructions[i] == "NORTH" && dirInstructions[i - 1] == "SOUTH")
            {
                dirInstructions.RemoveAt(i);
                dirInstructions.RemoveAt(i - 1);
                i = dirInstructions.Count;
                continue;
            }

            if (dirInstructions[i] == "SOUTH" && dirInstructions[i - 1] == "NORTH")
            {
                dirInstructions.RemoveAt(i);
                dirInstructions.RemoveAt(i - 1);
                i = dirInstructions.Count;
                continue;
            }

            if (dirInstructions[i] == "EAST" && dirInstructions[i - 1] == "WEST")
            {
                dirInstructions.RemoveAt(i);
                dirInstructions.RemoveAt(i - 1);
                i = dirInstructions.Count;
                continue;
            }

            if (dirInstructions[i] == "WEST" && dirInstructions[i - 1] == "EAST")
            {
                dirInstructions.RemoveAt(i);
                dirInstructions.RemoveAt(i - 1);
                i = dirInstructions.Count;
                continue;
            }
        }

        return dirInstructions.ToArray();
    }
}