class Solution
{

    static int minimumDistances(int[] a)
    {
        int count = -1;
        int loopcount = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    if (loopcount == 0)
                    {
                        count = Math.Abs(i - j);
                        loopcount++;
                    }
                    else if (count > Math.Abs(i - j))
                    {
                        count = Math.Abs(i - j);

                    }

                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
