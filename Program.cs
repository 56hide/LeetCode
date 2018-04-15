using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Soultion instance = new Soultion();
            int[] nums={1,5,9,6,3};
            int target = 6;
            int[] a = new int[2];
            a = instance.TwoSum(nums,target);
        }
    }
}
