﻿class Solution
{
    static int hurdleRace(int k, int[] height)
    {
        int len = height.Count();
        int max = 0;
        int count = 0;
        for (int i = 0; i < len; i++)
        {
            if (height[i] > k && height[i] > max)
            {
                max = height[i];
                count = max - k;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
        ;
        int result = hurdleRace(k, height);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}