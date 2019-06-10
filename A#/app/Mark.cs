using System;
using System.Collections.Generic;

namespace ASharp
{
    public class Mark
    {
        public static Dictionary <string, Mark> marks = new Dictionary<string, Mark>();
        private string meaning;
        public string M
        {
            get
            {
                return meaning;
            }
            set
            {
                if (value != null)
                {
                    this.meaning = value;
                }
            }
        }
        public Mark(string markName)
        {
            M = markName;
        }
        public static void Creating(string name, string meaning) // создать метку
        {
            marks[name] = new Mark(meaning);
        }
        public static int Search(string str)    // найти метку
        {
            foreach (KeyValuePair<string, Mark> item in marks)
            {
                if (str == item.Key)
                {
                    return Convert.ToInt32(item.Value.meaning);
                }
            }
            return -1; // метки не найдено, развалить программу
        }
        public static int Move(string go)   // перейти по метке
        {
            return Mark.Search(go.Trim(':'));
        }
    }
}