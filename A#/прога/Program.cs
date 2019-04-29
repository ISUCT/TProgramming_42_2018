using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp5;


namespace ConsoleApp5
{
   public class Program
    {
        public static string LastElement(string a)
        {
          string[] w = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  
          return w[w.Length-1];
        }
        public static string IfElse(string str,Dictionary<string, string> ver)
            {
 //условные конструкции
            
                Uslovie uslov = new Uslovie();
                
                   
               string[] w = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < w.Length; j++)
                {
                    if (w[j] == ">")
                    {
                     
                         if(uslov.More(w[j-1],w[j+1],ver) == "true") { return "true";}
                         else{return "fals";}
                         
                    }

                    if (w[j] == "<")
                    {
                         if(uslov.Less(w[j-1],w[j+1],ver) == "true"){  return "true";}
                         else{return "fals";}
                         
                    }

                    if (w[j] == ">=")
                    {
                         if(uslov.MoreOrEqually(w[j-1],w[j+1],ver) == "true"){ return "true"; }
                         else{return "fals";}
                         
                    }

                    if (w[j] == "<=")
                    {
                         if(uslov.LessOrEqually(w[j-1],w[j+1],ver) == "true"){ return "true"; }
                         else{return "fals";}
                         
                    }

                    if (w[j] == "==")
                    {
                         if(uslov.Equally (w[j-1],w[j+1],ver) == "true"){return "true";  }
                         else{return "fals";}
                         
                    }

                    if (w[j] == "!=")
                    {
                         if(uslov.NotEqual(w[j-1],w[j+1],ver) == "true"){return "true"; }
                         else{return "fals";}
                         
                    }
                }
                  return "";
 
            

            }

        static void Main()
        {
            int km = 0;
            Dictionary<string, string> variables = new Dictionary<string, string>();
             Dictionary<string, int> metki = new Dictionary<string, int>();


            string[] s = File.ReadAllLines("./Text.txt");

            for(int i = 0; i < s.Length; i++ )
            {
               if(Oshibki.Okaziia(s[i]) == "Okaziia")
               {
                   Console.WriteLine($"Оказия, ошибка в строке {i}");
                 throw new Exception();
               }
            }

            for(int i = 0; i < s.Length; i++ )//запоменание переменных
            {
                string[] w = s[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               
                for (int j = 0; j < w.Length; j++)
                {
                  
                    
                    if (w[j] == "read") { variables.Add(w[j + 1], Console.ReadLine()); break; }


                    if (s[i].Contains("+") || s[i].Contains("-") || s[i].Contains("/") || s[i].Contains("*")) { break; }
                    else
                    {
                        if (w[j] == "=" )
                        {
                            variables.Add(w[j - 1], w[j + 1]); break;
                        }

                    }
                   
                }

            }
             for(int i = 0; i < s.Length; i++ )//запоменание меток
            {
                string[] w = s[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               
                for (int j = 0; j < w.Length; j++)
                {
                    if(w[j].Contains(":")){metki.Add(w[j].Trim(new char[]{':'}),i);}

                }
            }

            
   
while(km < s.Length) 
{

    
if (s[km].Contains("goto") && !s[km].Contains("if"))
{
    
      string[] word = s[km].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      for (int l =0; l <word.Length; l++)
      {
          if (word[l] == "goto")
          {
              km = metki[word[l+1]];
               
          }
      }
      
}

if (s[km].Contains("if"))
{
    if(IfElse(s[km],variables)=="true")
    {
        km=metki[LastElement(s[km])];
     
    }
  
}


 //арефметические действия
            
                string[] w = s[km].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < w.Length; j++)
                {
                    if (w[j] == "+")
                    {
                        Arefmetika summa = new Arefmetika();
                        variables[w[0]] = summa.Sum(w[j - 1], w[j + 1], variables);
                      
                    }
                    if (w[j] == "-")
                    {
                        Arefmetika subtraction = new Arefmetika();
                        variables[w[0]] = subtraction.Sub(w[j - 1], w[j + 1], variables);
                       
                    }

                    if (w[j] == "/")
                    {
                        Arefmetika division = new Arefmetika();
                        variables[w[0]] = division.Div(w[j - 1], w[j + 1], variables);
                        
                    }

                    if (w[j] == "*")
                    {
                        Arefmetika multiplication = new Arefmetika();
                        variables[w[0]] = multiplication.Mul(w[j - 1], w[j + 1], variables);
                        
                    }
                    
                     if (w[j] == "%")
                    {
                        Arefmetika residue = new Arefmetika();
                        variables[w[0]] = residue.res(w[j - 1], w[j + 1], variables);
                        
                    }
                }

                km++;
   
}
//вывод переменной 
for(int i=0; i< s.Length; i++)
{
    if (s[i].Contains("print"))
    {
       string[] w = s[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
       for(int j = 0;j < w.Length;j++)
       {
           if(w[j]=="print"){Console.WriteLine($"{w[j+1]}= {variables[w[j+1]]}");}
       }
    }
}

            Console.ReadLine();
        }

    }
}
