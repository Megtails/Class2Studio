using System;
using Class2Studio;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char, double> letters = new Dictionary<char, double>();
        Console.WriteLine("Please enter a sentence: ");
        string input = Console.ReadLine();
        //string input = AddFile.text;
        string lowercase = input.ToLower();
        string nonAlpha = "!@#$%^&*()+={}[]|:;\"\\'<>?,./ '";
        //string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

        foreach (char i in lowercase)
        {
            if (nonAlpha.Contains(i))
            { 
                continue;
            }
            else if (!letters.ContainsKey(i))
            {
                letters.Add(i, 1);
            } else
            {
                letters[i] += 1;
            }
        }

        foreach (char dictKey in letters.Keys)
        {
            Console.WriteLine(dictKey + ": " + letters[dictKey]);
        }
    }

}