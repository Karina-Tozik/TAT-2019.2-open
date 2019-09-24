//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str1 = Console.ReadLine();
            int length = str1.Length;
            int count = 0;
            int count1 = 0;

            char[] arr;
            arr = str1.ToCharArray();

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                    if (count1 < count)
                    {
                        count1 = count;
                        count = 1;
                    }
                    else if (arr[i] != arr[j])
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(count1);
        }
    }
}