﻿//! This red bar will be used for important Concepts 
//?  Blue will be used for remembering points and concepts headings
//* It will be used for Programs practice and will be used for implementing .
//It will be used for Notes for Line of Codes.
//TODO: It will be used for Something that we will done in near future.
//FIXME: It will be used for Updating Code

// ? This project is for revising C# concepts.... Kudvenkat playlist Part: 1 - 15
using System;
using System.Globalization;
namespace Revise
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Concatenation method of printing line
            string name = "Samir";
            Console.WriteLine("Hi this is Concatenation " + name);

            //Place holder method of printing line
            Console.WriteLine("Hi this is Place Holder {0}", name);


            // What if we want to print samir as it is in the double quotation mark "Samir" 
            // It will give error for this: Console.WriteLine(""Samir"");
            // So we have to use --- "\" Escape Sequence when declaring value to string.
            string escapeName = "\"Samir\"";
            Console.WriteLine("Hi this is Escape Sequence {0}", escapeName);


            // What if we have to print "//" as well
            //For Example: Print this C\\program\\file
            // Console.WriteLine("C\\program\\file"); ----- Obviously it will give error!!!
            //So here the method: using "@" in front of value when declaring a string.
            string slashName = @"C\\program\\file";
            Console.WriteLine("My Folder Path is: {0}", slashName);


            // Here's the method to find min and max values of a specific data type
            int valueInt = 0; // Int value
            Console.WriteLine("Minimum value of int: {0}", int.MinValue);
            Console.WriteLine("Maximum value of int: {0}", int.MaxValue);

            double valueDouble = 0.0; // Double value
            Console.WriteLine("Minimum value of double: {0}", double.MinValue);
            Console.WriteLine("Maximum value of double: {0}", double.MaxValue);

            float valueFloat = 0.0f; // Float value
            Console.WriteLine("Minimum value of float: {0}", float.MinValue);
            Console.WriteLine("Maximum value of float: {0}", float.MaxValue);


            //*-----------> Here two short programs <-----------------
            // Here's the method to check if a number is positive or negative -- it is just for practice 
            Console.WriteLine("Checking if a number is negative...");
            int number = -5;
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero", number);
            }

            // Here's the method to check if a number is odd or even ---Just for Practice 
            Console.WriteLine("Checking if a number is odd or even...");
            // Console.Write("Enter a number: "); 
            // int number1 = int.Parse(Console.ReadLine()); // Read a number from the user
            int number1 = 10; // FIXME  Comment this line and uncomment above two...
            if (number1 % 2 == 0)
            {
                Console.WriteLine("The number {0} is even", number1);
            }
            else
            {
                Console.WriteLine("The number {0} is odd", number1);
            }


            //!  Ternary operator --- "? & :" -- important!!
            //* here's a basic program...
            Console.WriteLine("Simple if-else code ");
            int ternaryNumber = 15;
            bool ternary;
            if (ternaryNumber == 15)
            {
                ternary = true;
            }
            else
            {
                ternary = false;
            }
            Console.WriteLine("The number is: {0} ", ternary); // its a simple if else program anyone can easily write

            // we can write this in one line using ternary operator ---- ('? & :') 
            Console.WriteLine("Above if-else code using ternary operator");
            int ternaryNumber2 = 15;
            bool ternary2 = ternaryNumber2 == 15 ? true : false;
            Console.WriteLine("The number is: {0}", ternaryNumber2);



            //? -------- Types in C# -----------
            // In C#, types are divided into two categories:  
            // 1. Value types: int, float, double, char, bool, byte, short, long, decimal
            // 2. Reference types: string, object, class, interface, delegate, arrays

            // Description:
            //  Reference types are objects that store the memory address of the actual object, and they are allocated on the heap.
            //  Value types are objects that store the actual value, and they are allocated on the stack.

            //* Here's a simple program to show the difference between value and reference types
            Console.WriteLine("Difference between value and reference types...");
            int valueInt2 = 5;
            int referenceInt = valueInt2;
            referenceInt++;
            Console.WriteLine("Value Int: {0}, Reference Int: {1}", valueInt2, referenceInt);
            // Here, valueInt2 and referenceInt are two different variables.
            // When we increment referenceInt, valueInt2 also gets incremented because they are pointing to the same memory location.
            // This is because int is a value type.


            // Now, let's see what happens with reference types
            string valueString = "Hello";
            string referenceString = valueString;
            referenceString += " World!";
            Console.WriteLine("Value String: {0}, Reference String: {1}", valueString, referenceString);
            // Here, valueString and referenceString are two different variables.
            // When we concatenate referenceString, valueString also gets updated because they are pointing to the same memory location.
            // This is because string is a reference type.
            // In summary, value types are copied when assigned, while reference types are copied by reference.


            // ---------->  There is a point to be noted: value types cannot have "null" value. non-nullable <--------------
            // int = null;    // This will give a compile-time error
            // but here's the solution for assigning null value to value types: Using " ? "...
            int? nullableInt = null;
            Console.WriteLine("Nullable Int: {0}", nullableInt);
            // nullableInt.Value = 5; // This will not give a compile-time error because nullableInt is of type int?

            // But for reference types, null value can be assigned.
            string nullString = null;
            Console.WriteLine("Null String: {0}", nullString);
            // Note: In C#, null is not a valid value for value types. It is used to represent the absence of a value.


            // ? ----------> Null Coalescing Operator <--------------
            // The null coalescing operator (??) is used to provide a default value when a nullable value is null.
            // It returns the value of the left-hand operand if the left-hand operand is not null; otherwise, it returns the value of the right-hand operand.
            int? nullableInt2 = null;
            int defaultValue = 10;
            int result = nullableInt2 ?? defaultValue; // if nullableInt2 is null then it will assign default value to result.
            Console.WriteLine("Nullable Int with null coalescing operator: {0}", result);

            //* To better understand here's a simple example:
            int? ticketsOnSale = null;
            int availableTickets;
            if (ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
                // availableTickets = ticketsOnSale; ---- This will give a compile-time error because ticketsOnSale is of type int?
                // availableTickets = ticketsOnSale.Value; ----- This is will work properly. -----> It is coonverting nullable to int...
                availableTickets = (int)ticketsOnSale; // This is another way to convert nullable int to int.
            }
            Console.WriteLine("Available tickets: {0}", availableTickets);

            //* Better version of above code:
            int? ticketsOnSale2 = null;
            int availableTickets2;
            if (ticketsOnSale2.HasValue)
            {
                availableTickets2 = ticketsOnSale2.Value;
            }
            else
            {
                availableTickets2 = 0;
            }
            Console.WriteLine("Available tickets with null coalescing operator: {0}", availableTickets2);

            //? ----------> Nullable Types <--------------
            // Nullable types are used to make reference types nullable.
            // They add a "?" after the type name, and the compiler will automatically handle the null checking.
            // int? nullableInt = 5; // This is a nullable int.

            //TODO ----------> Boxing and Unboxing <-------------- 


            //? ----------> int.parse && int.tryparse: Some things to remember <--------------
            // int.Parse() is used to convert a string to an integer.
            // It throws an exception if the string is not a valid integer.
            // int.Parse("123"); // This will work properly.
            // int.Parse("abc"); // This will throw an exception.

            // int.TryParse() is used to convert a string to an integer.
            // It returns false if the string is not a valid integer, and it does not throw an exception.
            //* Here's an example:
            string inputString = "123";
            int resultInt;
            if (int.TryParse(inputString, out resultInt))
            {
                Console.WriteLine("Converted string to integer: {0}", resultInt);
            }
            else
            {
                Console.WriteLine("Could not convert string to integer.");
            }

            // Use int.parse() when we are sure that the input is a valid integer.
            // Use int.TryParse() when we want to handle invalid inputs gracefully. when we are not sure that the input is a valid integer e.g in case of user's form inputs. here we are not sure.


            //? -------> Arrays in C# <---------
            /* 
               Why we use arrays?
               We cannot store multiple values of same datatype in a single variable.
               So the solution is array.
               Arrays are used to store multiple values of the same data type in a single variable.
            
               Description: An array is a collection of elements of the same data type stored in contiguous memory locations. 
            */

            //*Example: Lets say we want to store 3 even number in variable.
            //So we have to create an integer array whose size is three and store three integers within that.

            int[] evenNumbers = new int[3];
            // int[] --> it indicates that its an array && new int[3] --> it indicates that its size of an array.
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;
            // Accessing array elements
            Console.WriteLine("Second element of array: {0}", evenNumbers[1]);

            //* Other operations on arrays
            // Array.Length property returns the number of elements in the array.
            Console.WriteLine("Length of the array: {0}", evenNumbers.Length);

            //Note: Instead of array we will study more useful collection classes.


            //? ----------> While && For Loop && For Each Loop <------------
            // A while loop is used to repeatedly execute a block of code as long as a specified condition is true.
            // Syntax:
            // while (condition)
            // {
            //      Code to be executed
            // }
            //* Using array example.
            int[] Numbers = new int[3];
            Numbers[0] = 2;
            Numbers[1] = 6;
            Numbers[2] = 10;

            // while loop
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            //For Loop
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }

            //For-Each Loop
            //We use this loop for the collection of numbers collection of strings.
            //Where-ever we have to print collections we have to use for-each loop.
            foreach (int k in Numbers) // here it will look in numbers and store them in k and will print everything that is in Numbers.
            {
                Console.WriteLine(k);
            }

            // Its another example of foreach loop.
            string[] names = { "John", "Alice", "Bob" };
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            //? ------> Two important keywords for loops: Break && Continue <--------

            //* lets say we have a loop that will print 20 numbers but we want to print only 10 numbers....
            for (int a = 0; a < 20; a++)
            {
                Console.WriteLine(a);
                if (a == 10)
                    break; // This will break the loop and will not print the remaining numbers.
            }


            //*Lets say we want to print even numbers 
            /* this code will test condition lets say for 0 it will divide by 2 the result will not equal to 1 then it moves to the next line ... cancelling continue .. but if lets say the next is 1 ... it will test and result is equal to 1 then it will continue iteration not gonna move to next line...*/

            // continue keyword is used to skip the current iteration and move to the next iteration.
            for (int b = 0; b < 20; b++)
            {
                if (b % 2 == 1)
                    continue; // This will skip the current iteration and will move to the next iteration.
                Console.WriteLine(b);
            }

            //?-----------------------------

            //TODO: Here our basic revision is complete but intermediate revision is still continued in Revise Project 2


        }
    }
}



