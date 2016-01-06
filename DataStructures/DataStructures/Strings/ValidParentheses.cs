using System;

namespace DataStructures.Strings
{
    class ValidParentheses : IProblem
    {
        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            PrintParentheses(n);
        }

        private void PrintParentheses(int n)
        {
            Validparentheses(n / 2, n / 2, "");
        }

        private void Validparentheses(int openP, int closeP, string str)
        {
            if (openP == 0 && closeP == 0)
                Console.WriteLine(str);
            if (openP > closeP)
                return;
            if (openP > 0)
                Validparentheses(openP - 1, closeP, str + "(");
            if (closeP > 0)
                Validparentheses(openP, closeP - 1, str + ")"); 
        }
    }
}
