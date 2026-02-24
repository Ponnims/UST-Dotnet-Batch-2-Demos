using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class Arraysdemo
    {
        static void Main(string[] args)
        {
            int[] scores= new int[5] { 90, 80, 70, 60, 50}; // fixed Array
            int[] marks= new int[] { 85, 75, 65, 55, 45,90,89 };// Dynamic Array
            int[] grades= { 95, 85, 75, 65, 55,89 }; // Implicitly typed Array / Dynamic Array

            // type inference in C# 14.0
            // it infers the datatype from the right hand side assigned value
            // implicitly typed local variables using the "var" keyword, which allows the compiler to infer the type of the variable based on the assigned value. This feature can help reduce code verbosity and improve readability by eliminating the need to explicitly specify the type of a variable when it can be easily inferred from the context. For example, instead of declaring a variable as "string name = "John";", you can simply write "var name = "John";" and the compiler will infer that "name" is of type string. This feature is particularly useful when working with complex types or when the type can be easily determined from the assigned value, making code more concise and easier to read.
            var x = 100;

            var namelist= new string[] { "Alice", "Bob", "Charlie" };

            //x = "Welcome";

            //var y; this will give a compile time error because the compiler cannot infer the type of y without an assigned value. In C#, when using the "var" keyword for implicit type inference, you must provide an initial value for the variable so that the compiler can determine its type. If you declare a variable with "var" without assigning it a value, the compiler will not be able to infer the type and will throw a compile-time error. Therefore, it is important to always initialize variables declared with "var" to ensure that the compiler can correctly infer their types.

            for(int i=0; i<scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach (int sc in scores)
            {
                Console.WriteLine(sc);
            }

            var emplist= new string[] { "John", "Jane", "Doe" };


            int[] myscoreslist = new int[] { 88, 77, 66 };
            // multidimensional arrays

            int[,] matr1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            int[,] matr2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            int[,] matr3= new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] jaggedArray = new int[3][]; // jagged array with 3 rows
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[1] { 6 };

        }
    }
}
