﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class20220107
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] arr = new int[3];

            ////read the value of this array from the user
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"please enter the {i} value");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //PrintIntgArray(arr);
            ////1---
            //string[] strArray = new string[] { "1", "2", "3" };
            //PrintStirngArray(strArray);

            //2---
            int[] intArray = new int[] { 2, 4, 5, 2, 8, 2 };
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());
            int countNumber = CountNumberInArray(intArray, num);
            Console.WriteLine(countNumber);
        }

        //2---write a method to return the frequency of a number in an interger array
        //{2,4,5,2,8,2} freq(2) =3
        static int CountNumberInArray(int[] intArray,int freq)
        {
            int countSum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == freq)
                    countSum++;
            }
            return countSum;

        }

        //1---write a method to print a String Array
        static void PrintStirngArray(string[] strArray)
        {
            for(int i=0;i< strArray.Length;i++)
                Console.WriteLine(strArray[i]);
        }

        //write a method to print a Int Array
        static void PrintIntgArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        //写一个可以输入array元素的方法
        static string[] WriteArray()
        {
            Console.WriteLine("How nuch number do you want in your array");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine("please enter a element of array");

            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"please enter the {i} string");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }
    }
}
