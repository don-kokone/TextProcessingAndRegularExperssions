using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Repeat_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string result = "";

            foreach (var word in words)
            {
                var repeatCount = word.Length;
                for (int i = 1; i <= repeatCount; i++)
                {
                    result += word;
                }
                Console.WriteLine(result);
            }
        }
    }
}
