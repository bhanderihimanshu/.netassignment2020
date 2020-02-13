using System;
using System.Collections.Generic;
using System.Text;

namespace prectical4
{
    class Class1
    {
        public static void infixtopostfix(string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for( int i=0;i<infix.Length;i++)
            {
                ch = infix[i];
                if(isOparator(ch))
                {
                    if(stack.Count==0)
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if(ch=='(')
                        {
                            stack.Push(ch);
                        }
                        else if(ch == ')')
                        {   
                            while(stack.Peek()!='(')
                            {
                                postfix += stack.Pop();
                            }
                            stack.Pop(); 
                        }
                        else
                        {
                            if(priority(ch) > priority(stack.Peek()))
                            {
                                stack.Push(ch);
                            }
                            else
                            {
                                postfix += stack.Pop();
                                i--;
                            }
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            foreach (var item in stack)
                postfix += item;
        }

        private static int priority(char ch)
        {
           
            switch(ch)
            {
                case '*':
                    return 2;

                case '/':
                    return 2;

                case '+':
                    return 1;

                case '-':
                    return 1;

                case '(':
                    return 0;

                default:
                    return 3;

                    
            }
        }

        private static bool isOparator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')')
            {
                return true;
            }
            return false;

        }
    }
}
