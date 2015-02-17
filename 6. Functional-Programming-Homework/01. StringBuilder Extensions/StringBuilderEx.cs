﻿using System.Collections.Generic;
using System.Text;

namespace _01.StringBuilder_Extensions
{
    static class StringBuilderEx
    {
        public static string Substring(this StringBuilder sb, int startIndex, int length)
        {
            return sb.ToString().Substring(startIndex, length);
        }
        public static StringBuilder RemoveText(this StringBuilder sb, string text)
        {
            return sb.Replace(text, string.Empty);
        }
        public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
        {
            return sb.Append(string.Join(string.Empty, items));
        }
    }
}
