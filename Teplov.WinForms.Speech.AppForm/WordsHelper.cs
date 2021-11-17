using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teplov.WinForms.Speech.AppForm
{
    class WordsHelper
    {
        Dictionary<string, string> wordsDictionary;
        string[] keys;
        int i;
        public int Length;
        public WordsHelper(Dictionary<string, string> words)
        {
            wordsDictionary = words;
            keys = words.Keys.ToArray();
            i = -1;
            Length = keys.Length;
            RandMas(keys);
        }


        public string GetNextKey()
        {
            i++;
            if (i >= keys.Length)
                return "";
            return keys[i];
        }

        public string GetValue(string key)
        {
            string str;
            if (wordsDictionary.TryGetValue(key, out str))
                return str;
            return "";
        }
        public void Reset()
        {
            i = -1;
            RandMas(keys);
        }

        void RandMas(string[] key)
        {
            Random rand = new Random();
            for (int i = key.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                string tmp = key[j];
                key[j] = key[i];
                key[i] = tmp;
            }
        }


    }
}
