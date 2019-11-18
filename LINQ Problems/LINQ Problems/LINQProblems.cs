using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQProblems_
    {
        public LINQProblems_()
        {

        }

        public void SortStringsWithTH()
        {
            var words = new Problems().GetWords();
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

        public void SortStringsRemoveDuplicates()
        {
            var names = new Problems().GetNames();
            var namesThatDontDuplicate = names.Distinct();
            foreach (var name in namesThatDontDuplicate)
            {
                Console.WriteLine(name);
                Console.ReadLine();
            }
        }
    }
}
