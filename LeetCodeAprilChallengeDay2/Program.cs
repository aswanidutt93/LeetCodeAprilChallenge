using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAprilChallengeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            IsHappy(188);
        }


        public static bool IsHappy(int n)
        {
            int count = 0;
            while (n != 1 && count < 25)
            {
                n = SumofSquares(n);
                count++;
            }
            if (n == 1)
            {
                return true;
            }
            else return false;
        }



        public static int SumofSquares(int n)
        {
            int sum = 0;
            if (n > 9)
            {
                var arr = Convert.ToString(n).ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += Convert.ToInt32(arr[i] - '0') * Convert.ToInt32(arr[i] - '0');
                }
            }

            else
            {
                sum = n * n;
            }
            return sum;
        }
    }


}