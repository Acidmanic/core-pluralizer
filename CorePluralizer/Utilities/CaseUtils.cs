using System;

namespace CorePluralizer.Utilities
{
    public static class CaseUtils
    {
        public static string MatchCase(string reference, string value)
        {
            var uppers = new bool[value.Length];

            var length = value.Length < reference.Length ? value.Length : reference.Length;

            var refChars = reference.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                uppers[i] = Char.IsUpper(refChars[i]);
            }

            string result = "";

            var valueChars = value.ToCharArray();

            for (int i = 0; i < value.Length; i++)
            {
                result += uppers[i] ? char.ToUpper(valueChars[i]) : char.ToLower(valueChars[i]);
            }

            return result;
        }
    }
}