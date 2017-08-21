using System;
using System.Collections.Generic;

namespace ReverseStringInArrayClassLibrary
{
    public static class StringArrayReverser
    {
        public static string[] ReverseStringsInArray(string[] strArr)
        {
            List<string> list = new List<string>(); 

            foreach (var item in strArr)
            {
                list.Add(ReverseStringOrder(item)); 
            }

            return list.ToArray(); 
        }

        public static string[] ReverseStringsInArray(string[] strArr, bool toLowerCase)
        {
            List<string> list = new List<string>();

            foreach (var item in strArr)
            {
                if (toLowerCase)
                    list.Add(ReverseStringOrder(item).ToLower());
                else
                    list.Add(ReverseStringOrder(item)); 
            }

            return list.ToArray();
        }

        private static string ReverseStringOrder(string str)
        {
            string tmp = string.Empty; 
            for (int i = str.Length -1; i > -1; i--)
            {
                tmp += str[i];
            }
            return tmp; 
        }
    }
}
