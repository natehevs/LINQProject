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
