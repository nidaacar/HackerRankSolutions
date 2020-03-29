class Solution
{


    static string angryProfessor(int k, int[] a)
    {

        string result = null;

        int count = 0;

        foreach (var item in a)
        {
            if (item <= 0)
            {
                count++;
            }
        }

        if (count >= k)
        {
            result = "NO";
        }
        else
        {
            result = "YES";
        }
        return result;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

