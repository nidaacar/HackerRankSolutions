class Solution
{

    static int jumpingOnClouds(int[] c)
    {
        int result = 0;

        for (int i = 0; i < c.Length - 1; i++)
        {
            if (i != c.Length - 2)
            {
                if (c[i + 2] == 0)
                {
                    result++;
                    i++;
                }
                else if (c[i + 1] == 0)
                {
                    result++;
                }
            }
            else
            {
                result++;
            }
        }
        return result;
    }



    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}