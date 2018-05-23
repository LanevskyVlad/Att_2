using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class StringConverter
    {
        public static List<int> StrToIntList(string str)
        {
            return new List<int>(Array.ConvertAll(str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), (s) => int.Parse(s)));
        }
        public static string IntListToString(List<int> list)
        {
            return string.Join(" ", list);
        }
        public static List<string> StrToStrList(string str)
        {
            return new List<string>(str.Split(new char[] { ' ', ',', '.', ':', ';', '\'', '"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '|', '>', '<', '/', '\\', '=', '-', '+', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
        }
        public static string StrListToStr(List<string> list)
        {
            return string.Join(" ", list);
        }
    }
}
