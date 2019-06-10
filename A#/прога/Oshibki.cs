using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp5;

namespace ConsoleApp5
{
    public class Oshibki
    {
        public static string Okaziia(string a)
        {
           
            if (a.Contains("if") && !a.Contains("goto"))
            {
                 
               return "Okaziia" ;
            }
            string[] w = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0;j < w.Length;j++)
        {
            if (w[j]=="=" && j != 1 ) 
            {
                 return "Okaziia" ;
            }

        
        }

        if ((a.Contains(">") || a.Contains(">=") || a.Contains("<=") || a.Contains("<") || a.Contains("==") || a.Contains("!=")) && !a.Contains("if"))
        {
           return "Okaziia" ;
        }
        return"";


        
        }
    }
}