using System;
using System.IO;
using System.Collections.Generic;

namespace ASharp.Core
{
    public class IO
    {
        public const bool FILE_APPEND = true;
        public string ReadFile(string path)
        {
            if (Path.HasExtension(path))
            {
                string code = File.ReadAllText(path);
                return code;
            }
            else
            {
                return "";
            }
        }

        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string text = "")
        {
            Console.Write(text);
        }
        public void Write(int number)
        {
            Console.Write(number);
        }

        public void WriteLine(string text = "")
        {
            Console.WriteLine(text);
        }
        public void WriteLine(int number)
        {
            Console.WriteLine(number);
        }
        public void Write(Dictionary<string, string> data)
        {
            foreach (KeyValuePair<string, string> keyValue in data)
            {
                Console.WriteLine(keyValue.Key + "=" + keyValue.Value);
            }
        }
    }
}