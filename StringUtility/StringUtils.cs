using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtility
{
    public class StringUtils
    {
        public string str { get; set; }

        public StringUtils(string str)
        {
            this.str = str;
        }

        public string Reverse()
        {
            string result = "";
            
            int j =str.Length-1;
            while (j>=0)
            {
                result += str[j];
                j--;

            }
            return result;
        }
        public bool IsPalindrome()
        {
            bool flag = true;
            int j =str.Length-1, i=0;
            while (i<j)
            {
                if (str[i] != str[j])
                {
                    flag = false; 
                    break;
                }
                i++;
                j--;
            }
            return flag;
        }

        public string ToUpperCase()
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                // Convert only lowercase letters ('a' to 'z') to uppercase
                if (ch >= 'a' && ch <= 'z')
                {
                    result += (char)(ch - 32);
                }
                else
                {
                    result += ch; // Keep other characters unchanged
                }
            }
            return result;
        }



    }
}
