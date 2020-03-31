class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int count1 = 0;
        int count2 = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                {
                    count1 = count1 + arr[i][j];
                }
                if (i == arr.Count - j - 1)
                {
                    count2 = count2 + arr[i][j];
                }
            }
        }
        int result = Math.Abs(count1 - count2);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
