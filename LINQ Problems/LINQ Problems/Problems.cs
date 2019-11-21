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
        public string grades;
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

        public List<string> GetGrades()
        {
            List<string> grades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            return new List<string>(grades);
        }

        public List<string> GetString()
        {
            List<string> name = new List<string>()
            {
                "Terrill"
            };
            return new List<string>(name);
        }
    }
}
