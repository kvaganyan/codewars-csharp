using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            for (int j = 0; j <= dirList.Count()-1; j++)
            {
                dirList[j] = dirArray[randomizer.Next(0, 3)];
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
            switch (arr[i])
            {
                case "NORTH":
                    if (arr[i - 1] == "SOUTH")
                    {
                        dirInstructions.RemoveAt(i);
                        dirInstructions.RemoveAt(i - 1);
                        i = dirInstructions.Count - 1;
                    }
                    break;
                case "SOUTH":
                    if (arr[i - 1] == "NORTH")
                    {
                        dirInstructions.RemoveAt(i);
                        dirInstructions.RemoveAt(i - 1);
                        i = dirInstructions.Count - 1;
                    }
                    break;
                case "EAST":
                    if (arr[i - 1] == "WEST")
                    {
                        dirInstructions.RemoveAt(i);
                        dirInstructions.RemoveAt(i - 1);
                        i = dirInstructions.Count - 1;
                    }
                    break;
                case "WEST":
                    if (arr[i - 1] == "EAST")
                    {
                        dirInstructions.RemoveAt(i);
                        dirInstructions.RemoveAt(i - 1);
                        i = dirInstructions.Count - 1;
                    }
                    break;
            }
        }

        return dirInstructions.ToArray();
    }
}