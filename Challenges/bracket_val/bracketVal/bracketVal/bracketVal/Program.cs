using System;
using bracketVal.Classes;

namespace bracketVal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation("Hello World");
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
                char character = inputString[i];
                Console.WriteLine(character);
            }
            if(bracketStack.Peek() != null)
            {
                return false;
            }
            return true;
        } 
    }
}
