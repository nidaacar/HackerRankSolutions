class Solution
{

    static int[] rotLeft(int[] a, int d)
    {
        int temp = 0;
        List<int> list_Array = new List<int>(a);

        for (int i = 0; i < d; i++)
        {
            temp = list_Array[0];
            list_Array.RemoveAt(0);
            list_Array.Add(temp);

        }

        int[] array = list_Array.ToArray();

        return array;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
