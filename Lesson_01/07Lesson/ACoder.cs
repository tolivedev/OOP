using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._07Lesson
{
    interface ICoder
    {
        string Encode(string s);
        string Decode(string s);

    }
    class ACoder : ICoder
    {

        private string EncStr { get; set; } = string.Empty;
        private string PlainText { get; set; } = string.Empty;

        public string Encode(string str)
        {
            if (str != "")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    EncStr += (char)(str[i] + 1);
                }
                return EncStr;
            }
            else return "Нет данных для шифрования!";
        }

        public string Decode(string str)
        {
            if (str != "")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    PlainText += (char)(str[i] - 1);
                }
                return PlainText;
            }
            else return "Нет данных для дешифрования!";
        }



        //public string Encode(string str)
        //{
        //    List<byte> ls = new();
        //    string someString = string.Empty;
        //    if (str != null)
        //    {
        //        //byte[] bytes = Encoding.UTF8.GetBytes(str);
        //        char[] chr = str.ToCharArray();
        //        foreach (char c in chr)
        //        {
        //            //(c) => c << 1;
        //            ls.Add((byte)(c & aa1));
        //        }
        //        //someString = Encoding.UTF8.GetString(ls.ToArray<byte>());
        //        return someString;
        //    }
        //    //c1 = null;
        //    else return someString;
        //}

        //public string Decode(string str)
        //{
        //    List<byte> ls = new();
        //    string someString = string.Empty;
        //    if (str != null)
        //    {
        //        byte[] bytes = Encoding.UTF8.GetBytes(str);
        //        foreach (byte c in bytes)
        //        {
        //            //(c) => c << 1;
        //            ls.Add((byte)(c >> 1));
        //        }
        //        someString = Encoding.UTF8.GetString(ls.ToArray<byte>());
        //        return someString;

        //        //byte[] bytes = Encoding.ASCII.GetBytes(str.ToString());

        //    }
        //    //c1 = null;
        //    else return someString;
        //}
    }
}
