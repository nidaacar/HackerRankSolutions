﻿class Solution
{


    static int sockMerchant(int n, int[] ar)
    {

        int result = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = i + 1; j < ar.Length; j++)
            {
                if (ar[i] == ar[j] && ar[i] != 0 && ar[j] != 0)
                {

                    result++;
                    ar[i] = 0;
                    ar[j] = 0;
                    break;

                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}