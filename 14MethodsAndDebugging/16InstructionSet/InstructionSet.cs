using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16InstructionSet
{
    class InstructionSet
    {
        static void Main(string[] args)
        {
            string opCode = string.Empty;

            long result = 0;

           

            while (opCode != "END")
            {
                opCode = Console.ReadLine();
                switch (opCode)
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(Console.ReadLine());
                            operandOne++;
                            result = operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(Console.ReadLine());
                            operandOne--;
                            result = operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(Console.ReadLine());
                            int operandTwo = int.Parse(Console.ReadLine());
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(Console.ReadLine());
                            int operandTwo = int.Parse(Console.ReadLine());
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                    case "END":
                        Console.WriteLine(result);
                        return;
                }
            }

        }
    }
}
