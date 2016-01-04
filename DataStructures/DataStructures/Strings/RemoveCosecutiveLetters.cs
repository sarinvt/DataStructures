using System;

namespace DataStructures.Strings
{
    public class RemoveCosecutiveLetters : IProblem
    {
        public void Solve()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var readLine = Console.ReadLine();
                if (readLine == null) continue;
                var str = readLine.ToCharArray();
                RemoveCosecutive(str);
            }
        }

        private static void RemoveCosecutive(char[] str)
        {
            var strNew = new char[str.Length];
            var prev = strNew[0] = str[0];
            Console.Write(str[0]);
            var j = 0;
            for (var i = 1; i < str.Length; i++)
            {
                if (prev == str[i]) continue;
                j++;
                prev = str[i];
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
