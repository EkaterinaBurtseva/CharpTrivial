using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(2, 3, '*');
        }
        public static void TestSwitch(int op1, int op2, char opr) {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return;
            }
            Console.WriteLine("Result:{0}", result);
            return;
            }
        }
    }

