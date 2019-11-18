using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public class Problems
    {
        public string words;
        public string names;
        public List<string> GetWords()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            return new List<string>(words);
        }

        public List<string> GetNames()
        {
             List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            return new List<string>(names);
        }
    }
}
