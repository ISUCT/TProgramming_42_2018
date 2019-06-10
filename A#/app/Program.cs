using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ASharp
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("введите полный путь к файлу");
            string roadToFile = Console.ReadLine(); 

            string[] linesOfFile = File.ReadAllLines(roadToFile);
            string allTextOfProgram = LinesToString(linesOfFile);

            allTextOfProgram = Removing(allTextOfProgram);
            allTextOfProgram = allTextOfProgram.PadLeft(allTextOfProgram.Length + 1);
            allTextOfProgram = allTextOfProgram.PadRight(allTextOfProgram.Length + 1);

            allTextOfProgram = allTextOfProgram + " 1 2 3 4 5 6 7 "; // чтобы не было выхода за границы массива
            
            string[] textOfProgram = allTextOfProgram.Split(' ');          

            Console.WriteLine(" работа программы ");

            Parser.Parsing(textOfProgram);

            System.Console.WriteLine(" конец работы ");
        }
        public static string LinesToString(string[] str)
        {
            string allLines = " ";
            foreach (string s in str)
            {
                allLines = allLines + " " + s;
            }
            return allLines;
        }
        public static string Removing(string s) // удаление лишних пробелов
        {
            for (int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == ' ' && (s[i-1] == ' ' || s[i+1] == ' ' ))
                {
                    s = s.Remove(i, 1);
                    s = Removing(s);
                }
            }
            return s;
        }
    }
}
