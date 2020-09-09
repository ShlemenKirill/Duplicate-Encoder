using System;
using System.Collections.Generic;

namespace Duplicate_Encoder
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            string lower = word.ToLower();
            char[] a = lower.ToCharArray();
            List<char> str = new List<char>();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i].Equals(a[j]))
                    {
                        count++;
                    }

                }
                if (count > 1)
                {
                    str.Add(')');

                }

                if (count < 2)
                {
                    str.Add('(');

                }
                count = 0;
            }

            var result = String.Join("", str.ToArray());
            return result;
        }
    }    
}