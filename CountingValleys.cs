class Solution
{
    static int countingValleys(int n, string s)
    {
        var str = s.ToCharArray();
        int result = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (str[i] == 'U')
            {
                if (count == -1)
                {
                    result++;
                }
                count++;
            }
            else if (str[i] == 'D')
            {
                count--;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}