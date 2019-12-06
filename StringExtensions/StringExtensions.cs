using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Capitalize(this String str)        /// Adding "this" makes this method an extension method.
        {
            string first = str[0].ToString().ToUpper();
            return first[0] + str.Substring(1);
        }

        public static string ToCamelCase(this String str)        /// Adding "this" makes this method an extension method.
        {
            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(" ");
            foreach(string part in parts)
            {
                sb.Append(Capitalize(part.ToLower()));
            }
            return sb.ToString();
        }

        public static int WordCount(this string s)        /// Adding "this" makes this method an extension method.
        {
            return s.Split(new char[] { ' ', '-', '\n', '\t' },StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Smurf(this string s,string toReplace)        /// Adding "this" makes this method an extension method.
        {
            return s.Replace(toReplace, "Smurf");
        }
    }
}
