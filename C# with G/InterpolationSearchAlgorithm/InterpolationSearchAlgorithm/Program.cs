using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationSearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // The idea of formula is to return higher value of pos
            // when element to be searched is closer to arr[hi]. And
            // smaller value when closer to arr[lo]
            // pos = lo + [(x - arr[lo]) * (hi - lo) / (arr[hi] - arr[Lo])]
            // if pos < x, use the left sub-array
            // if pos > x, use the right sub-array
            // loop this until arr[pos] = x or return -1 if the element is not found
            //x ==> Element to be searched
            //lo ==> Starting index in arr[]
            //hi ==> Ending index in arr[]
            
            int x = 18;
            
            int result = InterpolationSearch(x);

            if (result == -1)
                Console.WriteLine("The element was not found!");
            else
                Console.WriteLine("The element is at position {0}", result);

            Console.ReadLine();
        }

        static int InterpolationSearch (int searched)
        {
            int[] arr = { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };

            int lo = 0;
            int hi = arr.Length - 1;

            while (lo <= hi && arr[lo] <= searched && arr[hi] >= searched)
            {
                int pos = lo + (searched - arr[lo]) * (hi - lo) / (arr[hi] - arr[lo]);

                if (arr[pos] == searched)
                    return pos;
                else if (arr[pos] > searched)
                    hi = pos - 1;
                else if (arr[pos] < searched)
                    lo = pos + 1;
            }
            return -1;
        }
    }
}
