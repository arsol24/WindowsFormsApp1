using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using System;

    namespace Calculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                double num1, num2, result;
                char op;

                Console.WriteLine("Welcome to the Calculator program!");
                Console.WriteLine("Please enter the first number:");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the operator (+, -, *, /, %, ^):");
                op = char.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number:");
                num2 = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                        break;

                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                        }
                        break;

                    case '%':
                        result = num1 % num2;
                        Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
                        break;

                    case '^':
                        result = Math.Pow(num1, num2);
                        Console.WriteLine("{0} ^ {1} = {2}", num1, num2, result);
                        break;

                    default:
                        Console.WriteLine("Invalid operator entered");
                        break;
                }

                Console.WriteLine("Thank you for using the Calculator program!");
                Console.ReadKey();
            }
        }
    }
