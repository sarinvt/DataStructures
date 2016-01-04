using DataStructures.Strings;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProblem problem = new StringReverse();
            IProblem problem = new RemoveCosecutiveLetters();
            problem.Solve();
        }
    }
}
