using System;
using System.IO;
using System.Text;
using System.Collections.Concurrent;
using System.Text;

namespace Task_2_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            string answer = "shadow";
            int i = 0;
          
            do
            {
                string riddler1 = File.ReadAllText("Riddlers.txt");
                Console.WriteLine(riddler1);
                
                i++;
                option = Console.ReadLine();

            }
            while (option.ToLower() != answer.ToLower() && i < 3);
        }
    }
}
