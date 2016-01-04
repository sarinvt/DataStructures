using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays
{
    public class MissingNumbers : IProblem
    {
        public void Solve()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var readLine = Console.ReadLine();
            var array = new List<int>();
            if (readLine != null){
                array = readLine.Split(' ').Select(int.Parse).ToList();
            }

            var vector = new BitArray(n+1);
            foreach (var item in array){
                vector[item] = true;
            }

            for (var i=1;i<vector.Count-1;i++){
                if (vector[i].Equals(false)){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
