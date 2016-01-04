using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays
{
    public class MissingNumber: IProblem
    {
        public void Solve(){
            var n = Convert.ToInt32(Console.ReadLine());
            Int64 expSum = (n * (n + 1)) / 2;
            var readLine = Console.ReadLine();
            var array = new List<int>();
            if (readLine != null){
                array = readLine.Split(' ').Select(int.Parse).ToList();
            }           
            var sum = array.Aggregate<int, long>(0, (current, t) => current + t);
            Console.WriteLine("Missing number is " + (expSum-sum));
        }
    }
}
