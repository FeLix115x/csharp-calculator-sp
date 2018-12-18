using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /**
     * Custom defined exception for validating parentheses of a
     * mathematical expression
     */
    public class ParenthesesException : Exception
    {
        public ParenthesesException()
        {

        }

        public ParenthesesException(string msg) : base(msg)
        {

        }

        public ParenthesesException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
