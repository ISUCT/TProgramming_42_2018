using System;
using System.Collections.Generic;

namespace ASharp
{
    public class Mathem
    {
        public static string Result(string n1, string n2, string operation)
        {
            switch (operation)
            {
                case "+":
                {
                    return Sum(n1, n2);
                }
                case "-":
                {
                    return Min(n1, n2);
                }
                case "*":
                {
                    return Multiply(n1, n2);
                }
                case "/":
                {
                    return Divide(n1, n2);
                }
                case "%":
                {
                    return Mod(n1, n2);
                }
                case "^":
                {
                    return Power(n1, n2);
                }
                default:
                {
                    return "bad";
                }
            }
        }
        public static int InDigit(string n1)   // определить число или переменная
        {
            if (Int32.TryParse(n1, out int num1) == true)
            {
                return Convert.ToInt32(n1);
            }
            else
            {
                return Variables.Search(n1);                
            }
        }
        public static bool More(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Less(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 < num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Equally(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool MoreOrEqually(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 >= num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool LessOrEqually(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 <= num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool NotEqually(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);

            if (num1 != num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Sum(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(num1 + num2);
        }
        public static string Min(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(num1 - num2); 
        }
        public static string Multiply(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(num1 * num2); 
        }
        public static string Divide(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(num1 / num2); 
        }
        public static string Mod(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(num1 % num2); 
        }
        public static string Power(string n1, string n2)
        {
            int num1 = Mathem.InDigit(n1);
            int num2 = Mathem.InDigit(n2);
            return Convert.ToString(Math.Pow(num1, num2)); 
        }
    }
}