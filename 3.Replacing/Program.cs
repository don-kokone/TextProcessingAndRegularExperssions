using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Replacing
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsAsString = Console.ReadLine();
            var wordsToRemove = wordsAsString.Split(',');
            string text = Console.ReadLine();

            foreach (var wordToRemove in wordsToRemove)
            {

                string newString = "";
                for (int i = 0; i < wordToRemove.Length; i++)
                {
                    newString = "*";
                }
            }
            Console.WriteLine(text);
        }
    }
}
