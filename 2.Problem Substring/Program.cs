using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Problem_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                var startIndex = text.IndexOf(stringToRemove);
                text = text.Remove(startIndex, stringToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
