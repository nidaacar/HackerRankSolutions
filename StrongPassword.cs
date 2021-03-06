﻿class Solution
{
    static int minimumNumber(int n, string password)
    {
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        int countupper = 0;
        int countlower = 0;
        int countspecial = 0;
        int countnumber = 0;
        int result = 0;
        int total = 0;
        foreach (var item in password)
        {
            if (numbers.Contains(item) && countnumber == 0)
            {
                countnumber = 1;
            }
            else if (lower_case.Contains(item) && countlower == 0)
            {
                countlower = 1;
            }
            else if (upper_case.Contains(item) && countupper == 0)
            {
                countupper = 1;
            }
            else if (special_characters.Contains(item) && countspecial == 0)
            {
                countspecial = 1;
            }
        }
        total = countspecial + countupper + countlower + countnumber;


        if (n < 6)
        {
            if ((6 - n) >= (4 - total))
            {
                result = 6 - n;
            }
            else if ((6 - n) < (4 - total))
            {
                result = 4 - total;
            }
        }
        else if (n >= 6)
        {
            if (total == 4)
            {
                result = 0;
            }
            else if (total == 3)
            {
                result = 1;

            }
            else if (total == 2)
            {
                result = 2;
            }
            else if (total == 1)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}