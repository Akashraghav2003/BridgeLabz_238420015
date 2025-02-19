using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertMap
{
    internal class DictionaryInverter
    {
        public static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> inputDict)
        {
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            foreach (var pair in inputDict)
            {
                if (!invertedDict.ContainsKey(pair.Value))
                {
                    invertedDict[pair.Value] = new List<K>();
                }
                invertedDict[pair.Value].Add(pair.Key);
            }

            return invertedDict;
        }
    }
}
