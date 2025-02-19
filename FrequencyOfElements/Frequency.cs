using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfElements
{
    internal class Frequency
    {
        public  Dictionary<string, int > Occurance(List <String> list)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                
                if (dict.ContainsKey(list[i]))
                {
                    dict[list[i]]++;

                }
                else
                {
                    dict.Add(list[i],1);
                }
            }
            return dict;
        }
    }
}
