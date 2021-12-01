using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageMedianModeRange
{
    public static class Program
    {
        //Average
        public static double findMean(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)sum / (double)n;
        }

        // Median
        public static double findMedian(int[] a, int n)
        {
            // First we sort
            // the array
            Array.Sort(a);

            // check for
            // even case
            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }

        public static int GetMode(this IEnumerable<int> list)
        {
         
            int mode = default(int);
            // Test for a null reference and an empty list
            if (list != null && list.Count() > 0)
            {
                // Store the number of occurences for each element
                Dictionary<int, int> counts = new Dictionary<int, int>();
                // Add one to the count for the occurence of a character
                foreach (int element in list)
                {
                    if (counts.ContainsKey(element))
                        counts[element]++;
                    else
                        counts.Add(element, 1);
                }
                // Loop through the counts of each element and find the 
                // element that occurred most often
                int max = 0;
                foreach (KeyValuePair<int, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        // Update the mode
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }
            return mode;
        }

        public static void Main()
        {
            int[] a = { 1, 3, 3, 4, 2, 7, 5, 8, 6 };
            int n = a.Length;


          
            Console.Write("Mean = " + findMean(a, n) + "\n");
            Console.Write("Median = " + findMedian(a, n)+ "\n");
            Console.Write("Moda ="+GetMode(a).ToString()+"\n");



        }
    }
}
