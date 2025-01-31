//! This red bar will be used for important Concepts 
//?  Blue will be used for remembering points and concepts headings
//* It will be used for Programs practice and will be used for implementing .
//It will be used for Notes for Line of Codes.
//TODO: It will be used for Something that we will done in near future.
//FIXME: It will be used for Updating Code

//? This Project is for Some critical concepts of C# 
using System;
using System.Security.Cryptography;
namespace Revise_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            //? ----------> Methods or functions in C# <----------
            // Method allow us to define logic once and use many times
            // [attributes] access-modifiers return-types method-name(parameter) 
            //{
            // method body
            // }

            Program.EvenNumbers(20);

            Program P = new Program();
            int Sum = P.Add(10, 20);
            Console.WriteLine("Sum is : {0}", Sum);



            // below code is for types of parameters
            int i = 0;
            // Program.Simple(i); // its value parameter it will print 0; because they point different memory location.
            Program.Simple(ref i); // its reference parameter it will print 101; because they point same memory location.
            Console.WriteLine("i is : {0}", i);


            int sum = 0;
            int product = 0;
            Program.Calculate(10, 20, out sum, out product);
            Console.WriteLine("Sum is : {0}, Product is : {1}", sum, product);

            Console.WriteLine(Program.total(1, 2, 3, 4));


            // int[] a = new int[3];
            // a[0] = 10;
            // a[1] = 20;   FIXME
            // a[2] = 30;
            // Program.ParamArray(a);
            Program.ParamArray(1, 2, 3, 4, 5);

        }

        //Here's an important concept of static method and instance method 
        //Make method static when theres general method like calculate two number 
        //Make it instance when it depends on object for example generating personal introduction

        public int Add(int FN, int SN)
        {
            return FN + SN;

        }

        public static void EvenNumbers(int target)
        {
            int Start = 0;
            while (Start <= target)
            {
                if (Start % 2 == 0)
                {
                    Console.WriteLine(Start);
                }
                Start++;
            }
        }

        //? ----------> Method Parameters C# <----------
        //There are four types of parameters:
        //1. Value Parameters: They are passed by value, which means that changes made to the parameter inside the method do not affect the original variable outside the method.
        //2. Reference Parameters: They are passed by reference, which means that changes made to the parameter inside the method, affect the original variable outside the method.
        //3. Out Parameters: They are passed by reference, but the method has to specify that it will receive a value.
        // Parameter arrays
        //4. Ref Return Parameters: They are passed by reference, but the method has to specify that it will return a value.


        // value and reference
        static void Simple(ref int j)
        {
            j = 101;
        }

        // a method can return only one value like FN + SN ; but what if we want product as well FN * SN;
        // so we need to use out parameter to return more than one value.
        public static void Calculate(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }

        // Param array parameters
        public static int total(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        public static void ParamArray(params int[] Numbers)
        {
            Console.WriteLine("There are {0} number of elements", Numbers.Length);
            // FIXME: Uncomment these lines
            // foreach (int num in Numbers)
            // {
            //     Console.WriteLine(num);
            // }

        }

    }
}