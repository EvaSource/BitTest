using System;


class Program
{
    static void Main()
    {
        int[] massive = {1,2,3,4,5};
        int[] massive2 = {0,1,2,3,4};

        System.Console.WriteLine(Sum(massive));
    }
    static int Sum(int[] nums)
    {
       int result = 0;
       int limit = 0;
       foreach(int number in nums)
        {
            if(Isbooled(number, limit)) result += number;
        }
       return result;
    }
    static bool Isbooled(int nums, int limit)
    {
        return nums > limit;
    }
}
