class Solution
{
    static int[] permutationEquation(int[] p)
    {

        int newindex = 0;
        int[] new_arr = new int[p.Length];

        for (int x = 1; x <= p.Length; x++)
        {
            newindex = Array.IndexOf(p, x) + 1;
            newindex = Array.IndexOf(p, newindex) + 1;
            new_arr[x - 1] = newindex;
        }
        return new_arr;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
