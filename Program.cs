using System;
using System.IO;
using System.Text;
using System.Collections.Concurrent;

namespace Task_2_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            string answer = "shadow";
            int i = 0;
            string[] meeting = File.ReadAllLines("Friendly fire.txt");
            Console.WriteLine(meeting[0]);
            Console.WriteLine();
            do
            {
                string riddler1 = File.ReadAllText("Riddlers.txt");
                Console.WriteLine(riddler1);
                Console.WriteLine($"\nWrite your answer, buddy.\n");
                i++;
                option = Console.ReadLine();
                if (answer == option)
                {
                    Console.WriteLine($"\nYEP, sir, it's correct\n");
                }
                else
                {
                    Console.WriteLine($"\nNO, it's wrong, try again, buddy\n");
                }
            }
            while (option.ToLower() != answer.ToLower() && i < 3);
            Console.WriteLine("GAME OVER");
        }
    }
}