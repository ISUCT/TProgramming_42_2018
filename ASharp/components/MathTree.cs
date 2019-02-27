using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ASharp.Runtime
{
    public class MathTree
    {
        public const char PLUS = '+';
        public const char SUB = '-';
        public const char MUL = '*';
        public const char DIV = '/';
        public const char POW = '^';
        public const char AND = '&';
        public const char OR = '|';
        private char? operation;
        private string variable;
        private MathTree left;
        private MathTree right;

        public MathTree(string varname)
        {
            variable = varname;
        }
        public MathTree(MathTree left, char operation, MathTree right)
        {
            this.left = left;
            this.operation = operation;
            this.right = right;
        }

        public int Solve()
        {
            int result;
            switch (operation)
            {
                case PLUS:
                    result = left.Solve() + right.Solve();
                    break;
                case SUB:
                    result = left.Solve() - right.Solve();
                    break;
                case MUL:
                    result = left.Solve() * right.Solve();
                    break;
                case DIV:
                    int rightVal = right.Solve();
                    if (rightVal == 0)
                    {
                        throw new System.DivideByZeroException(left.ToString() + " " + operation.ToString() + " " + right.ToString());
                    }
                    result = left.Solve() / rightVal;
                    break;
                case POW:
                    result = (int) Math.Pow((double) left.Solve(), (double) right.Solve());
                    break;
                case AND:
                    result = left.Solve() & right.Solve();
                    break;
                case OR:
                    result = left.Solve() | right.Solve();
                    break;
                default:
                    result = (int) Program.GetVariable(variable);
                    break;
            }
            return result;
        }
        public override string ToString()
        {
            if (operation == null) return variable;
            else return left.ToString() + " " + operation.ToString() + " " + right.ToString();
        }

        public static MathTree Parse(string str)
        {
            MatchCollection matches = new Regex(@"[\+\-\*\/\^\&\|]|([a-z0-9]+)").Matches(str);
            List<MathTree> trees = new List<MathTree>();
            List<char> operations = new List<char>();

            for (int i = 0; i < matches.Count; i++)
            {
                if (new Regex(@"[\+\-\*\/\^\&\|]").Match(matches[i].Value).Success)
                {
                    operations.Add(matches[i].Value.ToCharArray()[0]);
                }
                else
                {

                    if (Program.GetVariable(matches[i].Value) == null)
                    {
                        if (new Regex(@"^\d+$").Match(matches[i].Value).Success)
                        {
                            Program.SetVariable(matches[i].Value, Int32.Parse(matches[i].Value));
                        }
                        else
                        {
                            throw new ArgumentException($"Variable {matches[i].Value} does not exists");
                        }
                    }
                    MathTree tree = new MathTree(matches[i].Value);
                    trees.Add(tree);
                }
            }
            for (int i = 0; i < operations.Count; i++)
            {
                if (new Regex(@"[\*\/\^\&\|]").Match(operations[i].ToString()).Success)
                {
                    MathTree tree = new MathTree(trees[i], operations[i], trees[i + 1]);
                    trees[i] = tree;
                    trees.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < operations.Count; i++)
            {
                MathTree tree = new MathTree(trees[0], operations[0], trees[1]);
                trees[0] = tree;
                trees.RemoveAt(1);
                operations.RemoveAt(0);
                i--;
            }

            return trees[0];
        }
    }
}