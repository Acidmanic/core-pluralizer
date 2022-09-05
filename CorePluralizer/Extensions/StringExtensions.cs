namespace CorePluralizer.Extensions
{
    public static class StringExtensions
    {

        public static string ToPlural(this string noun)
        {
            return Pluralizer.ToPlural(noun);
        }
    }
}