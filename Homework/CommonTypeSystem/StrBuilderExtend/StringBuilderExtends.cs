namespace ExtendMethod
{
    using System.Text;
    public static class StringBuilderExtend
    {
        public static StringBuilder Substring(this StringBuilder item, int posFrom)
        {
            var str = item.ToString().Substring(posFrom);
            return new StringBuilder(str);  
        }

        // this is second overload of string.Substring();
        public static StringBuilder Substring(this StringBuilder item, int posFrom, int length)
        {
            var str = item.ToString().Substring(posFrom, length);
            return new StringBuilder(str);
        }
    }
}
