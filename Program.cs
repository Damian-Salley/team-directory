using System;

namespace TeamDirectory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Team Directory");

            string[] teamMembers = File.ReadAllLines("team.txt");

            foreach (string member in teamMembers)
            {
                Console.WriteLine(member);
            }
        }
    }
}