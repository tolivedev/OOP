using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._07Lesson
{
    class BCoder : ICoder
    {
        private string InStr { get; set; } = string.Empty;
        private string PlainText { get; set; } = string.Empty;
        char[] _alfRevers;

        private readonly char[] _alf = new[] {'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п',
            'р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            ' ',',','!','?','&','@'};

        public BCoder()
        {
            _alfRevers = _alf.Reverse().ToArray<char>();
        }

        private int BrutForce(char chars, char[] array)
        {
            int j = 0;
            for (int i = 0; i < 65; i++)
            {
                j++;
                if (chars == array[i]) return j;
            }
            return 0;
        }

        public string Encode(string str)
        {
            if (str != "")
            {
                string strLower = str.ToLower();
                for (int i = 0; i < strLower.Length; i++)
                {
                    InStr += _alfRevers[BrutForce(strLower[i], _alf) - 1];
                }
                return InStr;
            }
            else return "Нет данных для шифрования!";
        }

        public string Decode(string str)
        {
            if (str != "")
            {
                string strLower = str.ToLower();
                for (int i = 0; i < strLower.Length; i++)
                {
                    PlainText += _alf[BrutForce(strLower[i], _alfRevers) - 1];
                }
                return PlainText;
            }
            else return "Нет данных для дешифрования!";
        }


    }
}