using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {//hello
            bool cycle = true;

            while (cycle)
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1.Start calculating.");
                Console.WriteLine("2.Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Start calculating...");
                        Console.WriteLine("Enter first operand");

                        double firstOperand = EnterOperand();

                        Console.WriteLine("Choose operation : + , - , * , / .");
                        OperationTypes operation;
                        EnterOperation(out operation);

                        if (operation == OperationTypes.Unassigned)
                        {
                            Console.WriteLine("Error! Unknown operation. Restart the application.");
                        }

                        Console.WriteLine("Enter second operand");
                        double secondOperand = EnterOperand();
                        double result = Calculate(firstOperand, secondOperand, operation);
                        Console.WriteLine($"Result  {firstOperand} {operation.GetUserString()} {secondOperand} = {result}");

                        break;

                    case "2":
                        cycle = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Error! Unknown operation.");
                        break;
                }
            }         
        }

        private static double EnterOperand() 
        {
            bool convertResult;
            double firstOperandDouble;

            do
            {
                string firstOperandStr = Console.ReadLine();
                convertResult = double.TryParse(firstOperandStr, out firstOperandDouble);

                if (convertResult)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Enter operand using 0-9 and ',': ");
                }
            } while (!convertResult);

            return firstOperandDouble;
        }

        private static void EnterOperation(out OperationTypes oper) 
        {
            bool operationResult;

            do
            {
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        oper= OperationTypes.Plus;
                        operationResult = true;
                        break;

                    case "-":
                        oper=  OperationTypes.Substact;
                        operationResult = true;
                        break;
                    case "*":
                        oper= OperationTypes.Multiply;
                        operationResult = true;
                        break;
                    case "/":
                        oper= OperationTypes.Devide;
                        operationResult = true;
                        break;
                    default:
                        Console.WriteLine("Error! Choose operation: + , - , * , / .");
                        operationResult = false;
                        oper = OperationTypes.Unassigned;
                        break;
                }

            } while (!operationResult);
        }

        private static double Calculate(double firstOpr, double secondOpr, OperationTypes operation)
        {
            double result = 0;

            switch (operation)
            {
                case OperationTypes.Plus:
                    return result = firstOpr + secondOpr;

                case OperationTypes.Substact:
                    return result = firstOpr - secondOpr;

                case OperationTypes.Multiply:
                    return result = firstOpr * secondOpr;

                case OperationTypes.Devide:
                    return result = firstOpr / secondOpr;

                default:
                    return result;
            }
        }
    }
}
