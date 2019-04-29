using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp5
{
    public class Arefmetika
    {
        public String Sum(string a, string b, Dictionary<string, string> ver)
        {
            Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
            return Convert.ToString(a1.Con(a, ver) + b1.Con(b, ver));
        }

        public String Sub(string a, string b, Dictionary<string, string> ver)
        {
            Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
            return Convert.ToString(a1.Con(a, ver) - b1.Con(b, ver));
        }

        public String Div(string a, string b, Dictionary<string, string> ver)
        {
            Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
            return Convert.ToString(a1.Con(a, ver) / b1.Con(b, ver));
        }

        public String Mul(string a, string b, Dictionary<string, string> ver)
        {
            Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
            return Convert.ToString(a1.Con(a, ver) * b1.Con(b, ver));
        }

         public String res(string a, string b, Dictionary<string, string> ver)
        {
            Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
            return Convert.ToString(a1.Con(a, ver) % b1.Con(b, ver));
        }

    }
}