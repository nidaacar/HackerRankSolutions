class Solution
{

    static string pangrams(string s)
    {

        string result = null;
        char[] Original_alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] arr;

        s = s.ToLower();
        arr = s.ToCharArray();

        for (int i = 0; i < Original_alphabet.Length; i++)
        {
            if (arr.Contains(Original_alphabet[i]) == true)
            {
                result = "pangram";

            }
            else if (arr.Contains(Original_alphabet[i]) == false)
            {
                result = "not pangram";
                break;
            }
        }

        return result;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}