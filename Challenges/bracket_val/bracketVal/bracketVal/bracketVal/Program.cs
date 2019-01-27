using System;
using bracketVal.Classes;

namespace bracketVal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application contains a function for validating multiple pairs of brackets in a string to see if they're balanced. For instance:");
            string[] bracketStrings = new string[] {"","{}", "{}(){}", "()[[Extra Characters]]", "(){}[[]]", "{}{Code}[Fellows](())", "[({}]", "(](", "{(})" };
            foreach( string bracketString in bracketStrings)
            {
                if (MultiBracketValidation(bracketString))
                {
                    Console.WriteLine($"\"{bracketString}\" is an example of balanced brackets.");
                }
                else
                {
                    Console.WriteLine($"\"{bracketString}\" is an example of unbalanced brackets.");
                }
            }
        }

        public static bool MultiBracketValidation(string inputString)
        {
            Stack bracketStack = new Stack();
            for(int i = 0; i < inputString.Length; i++)
            {
                switch (inputString[i])
                {
                    case '[':
                        bracketStack.Push(inputString[i]);
                        break;
                    case '{':
                        bracketStack.Push(inputString[i]);
                        break;
                    case '(':
                        bracketStack.Push(inputString[i]);
                        break;
                    case ']':
                        if (bracketStack.Peek() != null && bracketStack.Peek().Value == '[')
                        {
                            bracketStack.Pop();
                            break;
                        }
                        else return false;
                    case '}':
                        if (bracketStack.Peek() != null && bracketStack.Peek().Value == '{')
                        {
                            bracketStack.Pop();
                            break;
                        }
                        else return false;
                    case ')':
                        if (bracketStack.Peek() != null && bracketStack.Peek().Value == '(')
                        {
                            bracketStack.Pop();
                            break;
                        }
                        else return false;
                    default:
                        break;
                }
            }
            if(bracketStack.Peek() != null)
            {
                return false;
            }
            return true;
        } 
    }
}
