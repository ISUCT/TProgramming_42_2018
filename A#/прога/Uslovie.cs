using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp5
{
    public class Uslovie 
    {
          Convertor a1 = new Convertor();
            Convertor b1 = new Convertor();
       public string More (string a, string b, Dictionary<string, string> ver) 
       {
            
           if (a1.Con(a,ver) > b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

        public string Less (string a, string b, Dictionary<string, string> ver) 
       {
           if (a1.Con(a,ver) < b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

        public string Equally (string a, string b, Dictionary<string, string> ver) 
       {
           if (a1.Con(a,ver) == b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

        public string NotEqual (string a, string b, Dictionary<string, string> ver) 
       {
           if (a1.Con(a,ver) != b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

 public string MoreOrEqually (string a, string b, Dictionary<string, string> ver) 
       {
           if (a1.Con(a,ver) >= b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

        public string LessOrEqually (string a, string b, Dictionary<string, string> ver) 
       {
           if (a1.Con(a,ver) <= b1.Con(b,ver)){ return "true";}
           else { return "fals";}

       }

    }
}