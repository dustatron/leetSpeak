using System;
using LeetSpeak.Models;

namespace LeetSpeak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Get Leet Words");
            Console.Write("Enter : ");
            string input = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(Speak.GetSentence(input));
            Console.WriteLine();
            Main();

        }
    }
}
