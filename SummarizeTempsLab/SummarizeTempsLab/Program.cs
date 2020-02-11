using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter File Name");
            string file = Console.ReadLine();

            Console.WriteLine(File.Exists(file) ? "File exists" : "File does not exist");
            Console.WriteLine("Enter Temperature Threshold");

            string input;
            int threshold;
            input = Console.ReadLine();
            threshold = int.Parse(input);

            int sumTemps = 0;
            int numAbove = 0;
            int numBelow = 0;
            int tempCount = 0;

            using (StreamReader sr = File.OpenText(file))
            {
                string line = sr.ReadLine();
                int temp;
                while (line != null)
                {
                    temp = int.Parse(line);
                    sumTemps += temp;

                    if (temp >= threshold)
                    {
                        numAbove += 1;
                    }
                    else
                    {
                        numBelow += 1;
                    }
                    line = sr.ReadLine();
                }
                Console.WriteLine("Temperatures above = " + numAbove);

                Console.WriteLine("Temperatures below = " + numBelow);

                int average = sumTemps / tempCount;

                Console.WriteLine("Average temp = " + average);
            }
        }
    }
}
