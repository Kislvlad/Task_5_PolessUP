using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1 };
            int max = 0;
            for(int i=1;i<nums.Length; i++)
                if (nums[i] > nums[max])
                    max = i;
            Console.WriteLine(max);
        }
    }
}
