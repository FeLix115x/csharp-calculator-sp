using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FunctionPlotter
    {

        public static string ReturnExpression(string expression)
        {
            return expression.Replace("y", "").Replace("=", "").Trim();
        }
    }
}
