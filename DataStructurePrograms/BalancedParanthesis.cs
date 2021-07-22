using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class BalancedParanthesis
    {
        public void ReadInput()
        {

            Stack<char> stack = new Stack<char>();
            int balanced = 0;
            string equation = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)(";
            Console.WriteLine("Equation : \n" + equation);
            //Checking if the paranthesisi balanced or not
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i].Equals('('))
                {
                    stack.Push(equation[i]);
                }
                else if (equation[i].Equals(')'))
                {
                    balanced = stack.pop();
                }
            }
            if (stack.Peek() == 1)
            {
                Console.WriteLine("The Equation is balanced");
            }
            else if (stack.Peek() == 0 && balanced == 1)
            {
                Console.WriteLine("The Equation is not balanced");
            }
        }
    }

}

