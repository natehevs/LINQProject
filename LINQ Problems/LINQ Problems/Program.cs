using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new thProblem().GetWords();
            var wordsWithTH =
                from m in words
                where m.Contains("th")
                select m;
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
        }
    }
}
