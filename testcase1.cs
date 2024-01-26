using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merge_Sorted_Array_leetcode_problem1
{
    public class testcase1
    {
        public async Task TestcaseAsync()
        {
            await Task.Delay(1000);
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            var m = 3;
            var n = 3;
            var i = 0;
            var j = 0;
            try
            {
                while (m > i && m > 0)
                {
                    nums1[i] = nums1[i];
                    i++;
                }
                while (n > j && n > 0)
                {
                    nums1[i] = nums2[j];
                    i++;
                    j++;
                }
            Array.Sort(nums1);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(nums1));
            }
            catch (System.Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException);
                Environment.Exit(0);
            }
        }
    }
}