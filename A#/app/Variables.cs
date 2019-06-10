using System;
using System.Collections.Generic;


namespace ASharp
{
    public class Variables
    {
        public static Dictionary<string, Variables> dictionaryOfVariables = new Dictionary<string, Variables>()
        {
            {"testName", new Variables("5")} // переменная нужна для теста, нигде не используется, создание новой переменной с таким же именем невозможно
        };
        private string meaning;
        public string Meaning
        {
            get
            {
                return meaning;
            }
            set
            {
                if (value != null && Int32.TryParse(value, out int rer) == true)
                {
                    this.meaning = value;
                }
            }
        }
        public Variables(string m)
        {
            Meaning = m;
        }
        public static void Creating(string key, string value) // создать переменную
        {
            dictionaryOfVariables[key] = new Variables(value);
        } 
        public static string Print(string str) // напечатать переменную
        {
            foreach (KeyValuePair<string, Variables> item in dictionaryOfVariables) // поиск переменной по ключу
            {
                if (str == item.Key)
                {
                    return ($"{item.Key} = {item.Value.Meaning}");
                }
            }
            return $"{str} - 404 not found";
        }
        public static int Search(string str) // найти значение переменной
        {
            foreach (KeyValuePair<string, Variables> item in dictionaryOfVariables)
            {
                if (str == item.Key)
                {
                    return Convert.ToInt32(item.Value.Meaning);
                }
            }
            return 0; // переменная не найдена, вернем 0
        }
    }
}