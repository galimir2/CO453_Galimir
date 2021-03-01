using System;
namespace ConsoleAppProject { }


public class ConsoleHelper
{
    public static void OutputMenu(string[] choices)
    {
        int choiceNo = 0;

        foreach (string choice in choices)
        {
            choiceNo++;
            Console.WriteLine(choiceNo + ". " + choice);
        }
    }


}
