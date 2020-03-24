class Solution
{


    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        long count = 0;
        if (y1 > y2)
        {
            count = (y1 - y2) * 10000;
        }
        else if (y1 < y2)
        {
            count = 0;
        }
        else if (m1 > m2 && y1 == y2)
        {
            count = (m1 - m2) * 500;
        }
        else if (d1 > d2 && m1 == m2 && y1 <= y2)
        {
            count = (d1 - d2) * 15;
        }

        return (int)count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] d1M1Y1 = Console.ReadLine().Split(' ');

        int d1 = Convert.ToInt32(d1M1Y1[0]);

        int m1 = Convert.ToInt32(d1M1Y1[1]);

        int y1 = Convert.ToInt32(d1M1Y1[2]);

        string[] d2M2Y2 = Console.ReadLine().Split(' ');

        int d2 = Convert.ToInt32(d2M2Y2[0]);

        int m2 = Convert.ToInt32(d2M2Y2[1]);

        int y2 = Convert.ToInt32(d2M2Y2[2]);

        int result = libraryFine(d1, m1, y1, d2, m2, y2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}