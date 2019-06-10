using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    public class Convertor
    {
        public int Con(string a, Dictionary<string, string> ver)
        {
            foreach (string k in ver.Keys)
            {
               
                if (a == k) {  return Convert.ToInt32(ver[k]);  }
                if (!Regex.IsMatch(a.ToString(), @"[A-Z]+$") && !Regex.IsMatch(a.ToString(), @"[a-z]+$")) {  return Convert.ToInt32(a); }
                
            }
            return 0;
        }

    }
}
