﻿class Solution
{

    static long repeatedString(string s, long n)
    {

        long result = 0;
        long count = n / s.Length;
        long add_count = n % s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        result = result * count;

        for (int i = 0; i < add_count; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        return result;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}