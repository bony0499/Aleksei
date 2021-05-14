using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class StringExtension
    {
        public static string GetUserString(this OperationTypes oper)
        {
            switch (oper)

            {
                case OperationTypes.Unassigned:
                    return "unknown";
 
                case OperationTypes.Plus:
                    return "+";

                case OperationTypes.Substact:
                    return "-";
                case OperationTypes.Multiply:
                    return "*";
                case OperationTypes.Devide:
                    return "/";
                default:
                    return "unknown";
            }
        }
    }
}
