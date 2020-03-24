class Solution
{
    static string timeConversion(string s)
    {
        string str = s.Substring(0, 2);

        string str1 = null;

        int k = Convert.ToInt32(str);

        if (k < 12 && s.Substring(s.Length - 2) != "AM")
        {
            k = k + 12;
            str1 = Convert.ToString(k);
        }

        else if (k == 12 && s.Substring(s.Length - 2) != "PM")
        {
            str1 = "00";
        }

        else
        {
            str1 = str;
        }

        s = s.Replace(str, str1);
        s = s.Remove(8);
        return s;
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}