using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Extensions
{
    public static class StringExtensions
    {
        public static bool CaseInsensitiveContains(this string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            bool test = text.IndexOf(value, stringComparison) >= 0;
            return test;
        }
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
