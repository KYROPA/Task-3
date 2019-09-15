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
            string answer1 = "shadow";
            string answer2 = "bonfire";
            string answer3 = "darkness";
            int i = 0;
            string[] meeting = File.ReadAllLines("Friendly fire.txt");
            Console.WriteLine(meeting[0]);
            Console.WriteLine();
            do
            {
                string riddler1 = File.ReadAllText("Riddler1.txt");
                Console.WriteLine(riddler1);
                Console.WriteLine($"\nWrite your answer, buddy.\n");
                i++;
                option = Console.ReadLine();
                if (answer1 == option)
                {
                    Console.WriteLine($"\nYEP, sir, it's correct\n");
                }
                else
                {
                    Console.WriteLine($"\nNO, it's wrong, try again, buddy\n");
                }
            }
            while (option.ToLower() != answer1.ToLower() && i < 3);
            
            do
            {
                string riddler2 = File.ReadAllText("Riddler2.txt");
                Console.WriteLine(riddler2);
                Console.WriteLine($"\nWrite your answer, buddy.\n");
                i++;
                option = Console.ReadLine();
                if (answer2 == option)
                {
                    Console.WriteLine($"\nYEP, sir, it's correct\n");
                }
                else
                {
                    Console.WriteLine($"\nNO, it's wrong, try again, buddy\n");
                }
            }
            while (option.ToLower() != answer2.ToLower() && i < 3);

            do
            {
                string riddler3 = File.ReadAllText("Riddler3.txt");
                Console.WriteLine(riddler3);
                Console.WriteLine($"\nWrite your answer, buddy.\n");
                i++;
                option = Console.ReadLine();
                if (answer3 == option)
                {
                    Console.WriteLine($"\nYEP, sir, it's correct\n");
                }
                else
                {
                    Console.WriteLine($"\nNO, it's wrong, try again, buddy\n");
                }
            }
            while (option.ToLower() != answer3.ToLower() && i < 3);

            Console.WriteLine("GAME OVER");
        }
    }
}