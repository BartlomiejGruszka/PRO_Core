using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Extensions
{
    static class StringExtensions
    {
        public static bool CaseInsensitiveContains(this string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            bool test = text.IndexOf(value, stringComparison) >= 0;
            return test;
        }
    }
}
