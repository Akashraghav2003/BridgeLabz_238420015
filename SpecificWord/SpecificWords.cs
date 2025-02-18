using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificWord
{
    internal class SpecificWords
    {
        public string Specific(string[] sentences, string specificWord)
        {
            int len = sentences.Length;
            string result = " ";

            foreach (string sentence in sentences)
            {
                string []  words = sentence.Split(" ");
                bool flag = false;
                foreach (string word in words)
                {
                    if(word == specificWord)
                    {
                        flag = true;
                        result = sentence;
                        break;
                    }
                }
                if (flag) break;
            }
            return result;
        }
    }
}
