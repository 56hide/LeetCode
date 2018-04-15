using System;
public class Soultion
{
    public int[] TwoSum(int[] nums,int target)
    {
        int[] result = new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            for(int j = i+1;j<nums.Length;j++)
            {
                int a = nums[i]+nums[j];
                if(a==target)
                {
                    result[0]=i;
                    result[1]=j;
                }
            }
        }
        if(result!=null)
        {
            System.Console.WriteLine("["+result[0]+","+result[1]+"]");
            return result;
        }
        else
        {
            return null;
        }
    }
}