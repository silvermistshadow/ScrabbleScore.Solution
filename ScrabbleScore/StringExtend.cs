using System;
using System.Collections.Generic;
using System.Linq;
    
namespace custExtensions.StringExtend
{
    public static class StringExtend
    {
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
            .Where(c => !Char.IsWhiteSpace(c))
            .ToArray());
        }
    }
}
