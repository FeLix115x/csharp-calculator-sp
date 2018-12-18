using System;
using System.Collections.Generic;

namespace Calculator
{

    // TODO clean up && debug
    public class ExpressionParser
    {
        public ExpressionParser()
        {
        }

        /**
         * First converts the equation to postfix by calling the function ToPostfix()
         * Then validates parentheses
         * then computes the result
         * 
         * @param inputEquation
         */
        public double ExecuteStringEquation(string inputEquation)
        {
            List<string> expr = ToPostfix(inputEquation);
            if (!ValidateParentheses(expr)) throw new ParenthesesException();

            Stack<double> s = new Stack<double>();
            double a, b, input;

            foreach (string str in expr)
            {
                if (!IsOperator(str))
                {
                    Double.TryParse(str.Replace(",", "."), out input);
                    s.Push(input);
                }
                else
                {
                    if (s.Count > 1)
                    {
                        a = s.Pop();
                        b = s.Pop();
                        switch (str)
                        {
                            case "+":
                                s.Push(b + a);
                                break;
                            case "-":
                                s.Push(b - a);
                                break;
                            case "*":
                                s.Push(b * a);
                                break;
                            case "/":
                                if (a == 0) throw new ArithmeticException();
                                s.Push(b / a);
                                break;
                            case "^":
                                s.Push(Math.Pow(b, a));
                                break;
                        }
                    }
                }
            }

           
            return s.Pop();
        }

        /**
         * Convert infix to posfix expression
         * 
         * @param expression
         * @return posfix expression as a List object of Strings
         */
        private List<string> ToPostfix(string expression)
        {
            List<string> posfix = new List<string>();
            Stack<char> opstack = new Stack<char>();
            int k;
            bool lastOp = false;	// true if last substring was an operator

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ')
                    continue;

                if (expression[i] >= '0' && expression[i] <= '9' || !lastOp && expression[i] == '-')
                {
                    string sb = "";
                    k = i;
                    while (k < expression.Length && (expression[k] >= '0' && expression[k] <= '9' || expression[k] == ',' || expression[k] == '.' || !lastOp && expression[i] == '-'))
                    {
                        sb += expression[k];
                        i = k++;
                    }

                    posfix.Add(sb);
                }

                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' || expression[i] == '^')
                {
                    if (!(opstack.Count == 0))
                    {
                        while (!StackIsEmpty(opstack) && Precedence(opstack.Peek()) <= Precedence(expression[i])
                                && opstack.Peek() != '(')
                            posfix.Add(char.ToString(opstack.Pop()));
                    }
                    lastOp = true;
                    opstack.Push(expression[i]);
                }
                else if (expression[i] == '(')
                {
                    lastOp = false;
                    opstack.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (!StackIsEmpty(opstack) && opstack.Peek() != '(')
                        posfix.Add(char.ToString(opstack.Pop()));

                    opstack.Pop();
                }
            }

            while (!StackIsEmpty(opstack))
                posfix.Add(char.ToString(opstack.Pop()));

            return posfix;
        }

        private bool ValidateParentheses(List<string> expr)
        {
            Stack<string> s = new Stack<string>();
            foreach(string substring in expr)
            {
                if (substring.Equals("("))
                {
                    s.Push(substring);
                } else if(substring.Equals(")"))
                {
                    if (StackIsEmpty(s))
                        return false;
                    if (s.Pop() != "(")
                        return false;
                }
            }
            if (StackIsEmpty(s))
                return true;

            return false;
        }

        /**
         * Compute precedence
         */
        private int Precedence(char op)
        {
            if (op == '^')
                return 1;
            else if (op == '*' || op == '/')
                return 2;
            else
                return 3;
        }

        /**
         * Check if a char sequence is an operator
         */
        private bool IsOperator(string op)
        {
            return op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/") || op.Equals("^");
        }

        /**
         * Help function to check if stack of generic type T is empty
         */
        private bool StackIsEmpty<T>(Stack<T> s)
        {
            return s.Count == 0;
        }



    }
}

