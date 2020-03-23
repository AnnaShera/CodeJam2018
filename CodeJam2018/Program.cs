using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam2018
{
    class Program
    {
        //Code Jam to I/O for Women 2018
        //Burger Optimization
        static void Main(string[] args)
        {
            double result = 0;
            int numOfCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCases; i++)
            {
                int numOfingredients = int.Parse(Console.ReadLine());
                if (numOfingredients > 0)
                {
                    string[] data = Console.ReadLine().Split();
                    int[] actualDic = new int[numOfingredients];
                    for (int j = 0; j < numOfingredients; j++)
                    {
                        actualDic[j] = int.Parse(data[j]);
                    }
                    Array.Sort(actualDic);

                    result = calcResult(numOfingredients, actualDic);
                }
                Console.WriteLine("Case #{0}: {1}", i + 1, result);
            }
        }

        private static int calcResult(int numOfingredients, int[] arr)
        {
            double result = 0;
            int dis = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += Math.Pow((arr[i] - dis),2);
                if (i % 2 != 0) dis++;
            }
            return Convert.ToInt32(result);
        }
    }
}
