using System.Linq;
using CorePluralizer.InMemoryData;

namespace CorePluralizer.Pluralizers
{
    public class EnglishPluralizer : IPluralizer
    {
        private readonly string[] _endingWithEs = {"s", "sh", "ch", "x", "z","o"};
        private readonly string[] _vowels = {"a", "e", "i", "o", "u"};

        /// <summary>
        /// https://www.grammarly.com/blog/plural-nouns/
        /// </summary>
        /// <param name="nounSingular"></param>
        /// <returns></returns>
        public string ToPlural(string nounSingular)
        {
            
            var nounLowercase = nounSingular.ToLower();
            
            
            if (EnglishPlurals.PluralsBySingular.ContainsKey(nounLowercase))
            {
                return EnglishPlurals.PluralsBySingular[nounLowercase];
            }


            var nounMinusOne = nounSingular.Length > 1
                ? nounSingular.Substring(0, nounSingular.Length - 1)
                : nounSingular;
            var nounMinusTwo = nounSingular.Length > 2
                ? nounSingular.Substring(0, nounSingular.Length - 2)
                : nounSingular;

            // If the noun ends with ‑f or ‑fe, the f is often changed to ‑ve before adding the -s to form the plural version.
            if (nounLowercase.EndsWith("f"))
            {
                return nounMinusOne + "ves";
            }
            if (nounLowercase.EndsWith("fe"))
            {
                return nounMinusTwo + "ves";
            }
            // If the singular noun ends in ‑s, -ss, -sh, -ch, -x, or -z, add ‑es to the end to make it plural.
            //If the singular noun ends in ‑o, add ‑es to make it plural.
            if (_endingWithEs.Any(ending => nounLowercase.EndsWith(ending)))
            {
                return nounLowercase + "es";
            }
            // If a singular noun ends in ‑y and the letter before the -y is a consonant, change the ending to ‑ies to make the noun plural.
            if (nounLowercase.EndsWith("y") && nounLowercase.Length > 1 && _vowels.Any(vow => nounLowercase.Substring(nounLowercase.Length - 1, 1) == vow))
            {
                return nounMinusOne + "ies";
            }
            // If the singular noun ends in ‑us, the plural ending is frequently ‑i.
            if (nounLowercase.EndsWith("us"))
            {
                return nounMinusTwo + "i";
            }
            // If the singular noun ends in ‑is, the plural ending is ‑es.
            if (nounLowercase.EndsWith("is"))
            {
                return nounMinusTwo + "es";
            }
            //If the singular noun ends in ‑on, the plural ending is ‑a.
            if (nounLowercase.EndsWith("on"))
            {
                return nounMinusTwo + "a";
            }

            return nounSingular + "s";
        }

    }
}