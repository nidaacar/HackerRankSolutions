class Solution
{

    static int utopianTree(int n)
    {
        int height = 1;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0 && i != 0)
            {
                height = height + 1;
            }
            else if (i % 2 == 1)
            {
                height = height * 2;
            }

        }

        return height;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}