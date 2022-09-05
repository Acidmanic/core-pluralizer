using System.Diagnostics;
using CorePluralizer.Pluralizers;

namespace CorePluralizer
{
    /// <summary>
    /// The library's control panel!
    /// </summary>
    public static class Pluralizer
    {
        public static IPluralizer Default { get; private set; } = new EnglishPluralizer();

        public static void SetDefault(IPluralizer pluralizer)
        {
            Default = pluralizer;
        }

        public static string ToPlural(string nounSingular)
        {
            return Default.ToPlural(nounSingular);
        }
    }
}