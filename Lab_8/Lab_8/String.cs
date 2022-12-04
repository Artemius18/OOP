
namespace Lab09
{
    class StringRe
    {
        public static string Remove(string str)
        {
            str = str.Replace(".", string.Empty);
            str = str.Replace(",", string.Empty);
            str = str.Replace("!", string.Empty);
            str = str.Replace("?", string.Empty);
            return str;
        }


        public static string AddToString(string str)
        {
            return str += "символ";
        }


        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }


        public static string ToUpper(string str) => str.ToUpper();


        public static string ToLower(string str) => str.ToLower();
    }
}