using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    public static class MyExtentions
    {
        /// <summary>
        /// Indicates whether the specified string is null or an System.String.Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool _IsNullOrEmpty(this string value)
        {
            return !(value != null && value != string.Empty);
        }
        /// <summary>
        ///  Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="value">given string</param>
        /// <param name="sym">given char</param>
        /// <returns>Returnes true if the value contains parameter sym, otherwie - false</returns>
        public static bool _Contains(this string value, char sym)
        {
            if (!value._IsNullOrEmpty())
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i].Equals(sym))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int _IndexOf(this string value, char sym)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == sym)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int _IndexOf(this string value, char sym, int startIndex)
        {
            if (startIndex < value.Length)
            {
                for (int i = startIndex + 1; i < value.Length; i++)
                {
                    if (value[i] == sym)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public static int _IndexOf(this string value, char sym, int startIndex, int lastIndex)
        {
            if (lastIndex < value.Length && startIndex < lastIndex)
            {
                for (int i = startIndex + 1; i < lastIndex; i++)
                {
                    if (value[i] == sym)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public static string _Replace(this string value, string oldValue, string newValue)
        {
            int firstIndex = 0;
            int lastIndex = 0;
            string res;
            for (int i = 0; i < value.Length - oldValue.Length + 1; i++)
            {
                if (value.Substring(i, oldValue.Length) == oldValue)
                {
                    firstIndex = i;
                    lastIndex = i + oldValue.Length - 1;
                    break;
                }
            }
            if (firstIndex == 0)
            {
                res = newValue + value.Substring(lastIndex + 1);
            }
            else
            {
                res = value.Substring(0, firstIndex) + newValue + value.Substring(lastIndex + 1);
            }
            return res;
        }
    }
}
