using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAprilChallengeDay1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] n = new int[] { 4, 1, 2, 1, 2 };
            var res = SingleNumber(n);
        }

        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> m = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (m.ContainsKey(nums[i]))
                {
                    var val = m[nums[i]];
                    m.Remove(nums[i]);
                    m.Add(nums[i], val + 1);
                }
                else
                {
                    m.Add(nums[i], 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (m[nums[i]] == 1)
                {
                    return nums[i];
                }
            }
            return -1;

        }
    }
}
