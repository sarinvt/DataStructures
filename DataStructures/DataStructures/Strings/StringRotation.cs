using System;

namespace DataStructures.Strings
{
    public class StringRotation:IProblem
    {
        public void Solve()
        {
            var inputStr = Console.ReadLine();
            var testCases = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < testCases; i++)
            {
                var testCaseStr = Console.ReadLine();
                Console.WriteLine(IsRotation(inputStr,testCaseStr) ? "True" : "False");
            }
        }

        private static bool IsRotation(string inputStr, string testCaseStr)
        {
            return testCaseStr.Length == inputStr.Length && (inputStr + inputStr).Contains(testCaseStr);
        }
    }
}
