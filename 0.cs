//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            //string str1 = "sddfffffgghh";
            Console.Write("Введите строку: ");
            string str1 =Console.ReadLine();
            int length = str1.Length;
            //Console.WriteLine(length);
            int count=1;
            int count1=1;
            
            char[] arr;
            arr = str1.ToCharArray();
            //Console.WriteLine(arr);
            
            for (int i=0; i<length-1; i++)
            {
                for (int j=i+1; j<length-1; j++)
                {
                  if (arr[i]==arr[j])
                    count++;
                    if(count1<count)
                    {
                    count1=count;
                    count=1;
                    }
                  else if(arr[i]!=arr[j])
                  {
                   int numIdx = Array.IndexOf(arr, i);
                   arr = arr.Where(val=> val != numIdx).ToArray();
                  }
                }
            }
            Console.WriteLine(count1); 
            Console.ReadKey();
        }
    }
}