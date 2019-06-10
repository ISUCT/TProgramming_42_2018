using System;
using System.Collections.Generic;


namespace ASharp
{
    public static class Parser
    {
        public static void Parsing(string[] textOfProgram)
        {
            // найти и запомнить метки
            for (int i = 0; i < textOfProgram.Length; i++)
            {
                if ( textOfProgram[i].EndsWith(":") && textOfProgram[i+1] != "=" && Mark.Search(textOfProgram[i]) == -1)
                {
                    Mark.Creating(textOfProgram[i].Trim(':'), Convert.ToString(i));
                }
            }
            
            // основная работа
            for (int i = 0; i < textOfProgram.Length - 6; i++)
            {
                // условные конструкции
                if (textOfProgram[i] == "if" && textOfProgram[i+4] == "goto")
                {
                    bool b = false;
                    switch (textOfProgram[i+2]) 
                    {
                        case ">":
                            b = Mathem.More(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        case "<":
                            b = Mathem.Less(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        case "==":
                            b = Mathem.Equally(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        case ">=":
                            b = Mathem.MoreOrEqually(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        case "<=":
                            b = Mathem.LessOrEqually(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        case "!=": 
                            b = Mathem.NotEqually(textOfProgram[i+1],textOfProgram[i+3]);
                            break;
                        default:
                            b = false;
                            break;    
                    }

                    if (b == true)
                    {
                        i = Mark.Move(textOfProgram[i+5]);
                    }
                    else
                    {
                        i = i + 6;
                    }                   
                }

                // переход по меткам
                if (textOfProgram[i] == "goto")
                {
                    i = Mark.Move(textOfProgram[i+1]);
                }

                // операции с переменными
                if (Int32.TryParse(textOfProgram[i], out int x1 ) == false && textOfProgram[i+1] == "=")
                {
                    string forVariable = textOfProgram[i+2];

                    if (Int32.TryParse( textOfProgram[i+2], out int x2) == false)
                    {
                        forVariable = Convert.ToString(Variables.Search(textOfProgram[i+2]));
                    }

                    if (Parser.WordInList(textOfProgram[i+3], new List<string> {"+", "-", "*", "/", "%", "^"}) == true)
                    {
                        forVariable = Mathem.Result(textOfProgram[i+2], textOfProgram[i+4], textOfProgram[i+3]);
                    }

                    if (Parser.WordInList(textOfProgram[i], new List<string> {"=", "+", "-", "*", "/", "%", "^", "print", "read", "goto", "if", "==", "!=", ">", "<", ">=", "<=", "testName"}) == false)
                    {
                        Variables.Creating(textOfProgram[i], forVariable);
                    }
                }

                // напечатать переменную
                if (textOfProgram[i] == "print")
                {
                    System.Console.WriteLine(Variables.Print(textOfProgram[i+1]));
                }

                // считать переменную
                if (textOfProgram[i] == "read")
                {
                    Console.Write(textOfProgram[i+1] + " = ");
                    string forVariable = Console.ReadLine();
                    if (Int32.TryParse(forVariable, out int x3) == true)
                    {
                        Variables.Creating(textOfProgram[i+1], forVariable);
                    }
                    else
                    {
                        throw new Exception(" недопустимое значение переменной ");
                    }
                }                
            }
        }
        
        static public bool WordInList(string str, List<string> list)   // если подстрока есть в листе - true, иначе false
        {
            foreach (string i in list)
            {
                if (i == str)
                {
                    return true;
                }
            }
            return false;    
        }
    }
}