using System;

namespace DataStructures.Strings
{
    class StringReverse : IProblem
    {
        public void Solve()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var readLine = Console.ReadLine();
                if (readLine == null) continue;
                var str = readLine.ToCharArray();
                Console.WriteLine(Reverse(str));
            }
        }

        private string Reverse(char[] str)
        {
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                var temp = str[i];
                str[i] = str[j];
                str[j] = temp;
            }
            return new String(str);
        }
    }
}
