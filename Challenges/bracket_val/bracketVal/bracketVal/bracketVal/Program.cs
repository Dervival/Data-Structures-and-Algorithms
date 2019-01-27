using System;
using bracketVal.Classes;

namespace bracketVal
{
    public class Program
    {

        /// <summary>
        /// Main method to show off the functionality of the MultiBracketValidation method in the console.
        /// </summary>
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

        /// <summary>
        /// A method to determine if a string has balanced brackets in it, using a stack. An empty string is considered balanced. If a string has an opening bracket of a type with no corresponding closing bracket later on in the string, it is considered unbalanced. If a string has a closing bracket of a type, and the most recently seen bracket is not an opening bracket of the same type (ex: ')' and '(' or there are no previously seen brackets, it is considered unbalanced. Otherwise, the string is considered balanced.
        /// </summary>
        /// <param name="inputString">The string whose contents are to be evaluated for bracket balance.</param>
        /// <returns>True if the brackets are balanced, false if they are not.</returns>
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
