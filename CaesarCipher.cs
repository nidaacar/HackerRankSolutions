﻿
    class Solution
    {
        static string caesarCipher(string s, int k)
        {

            char[] Original_alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] arr;
            arr = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(arr[i]) && char.IsUpper(arr[i]))
                {
                    arr[i] = Char.ToLower(arr[i]);
                    arr[i] = Original_alphabet[(Array.IndexOf(Original_alphabet, arr[i]) + k) % 26];
                    arr[i] = Char.ToUpper(arr[i]);
                }
                else if (Char.IsLetter(arr[i]) && char.IsLower(arr[i]))
                {
                    arr[i] = Original_alphabet[(Array.IndexOf(Original_alphabet, arr[i]) + k) % 26];
                }
            }
            string result = new string(arr);
            return result.ToString();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

