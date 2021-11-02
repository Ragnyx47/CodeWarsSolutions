using System;
using System.Text.RegularExpressions;

namespace StringUtility
{
    public static class Replacer
    {
        /// <summary>
        /// Replace all dots
        /// </summary>
        /// <param name="str">String with dots</param>
        /// <returns>Returns string without dots</returns>
        public static string ReplaceDots(string str)
        {
            // Problem: dot (".") is a special character used to match any one character
            // Solution: a) use ("\.") which means literal dot, 
            //           b) preceding it with ("escaping it") another ("\")
            return Regex.Replace(str, "\\.", "-");
        }
    }
}
