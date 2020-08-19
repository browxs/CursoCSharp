namespace System
{
    static class StringExtension
    {
        public static string Cut(this string obj, int count)
        {
            if (obj.Length <= count)
            {
                return obj;
            }
            else
            {
                return $"{obj.Substring(0, count)} ...";
            }
        }
    }
}
