using System;
using System.Collections.Generic;

namespace StudioTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<char, int> charsDictionary = new Dictionary<char, int>();

            Console.WriteLine("Write something (anything, but use your words!):");
            input = Console.ReadLine();
            char[] inputCharacters = input.Trim().ToCharArray();

            foreach (char c in inputCharacters) {
                //if that key already exists in the dictionary...
                if (charsDictionary.ContainsKey(c))
                {
                    //then access that key and add +1 to the corresponding value! but, like.. in C# .. 
                    charsDictionary[c]++;
                }
                else
                {
                    //if that key doesn't already exist, do this:
                    charsDictionary.Add(c, 1);
                }

            }

            //NOW LET'S PRINT THIS SUCKER!
            foreach (KeyValuePair<char, int> character in charsDictionary)
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }


        }
    }
}
