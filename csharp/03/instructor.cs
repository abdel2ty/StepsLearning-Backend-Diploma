using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int id;
        public string name;
        public int age;

        //Functions
        //one Functionality 
        //name of Function 
        //Input
        //OutPut 
        //Calling
        public void PrintPattern()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("__________________________");
            Console.WriteLine("**************************");
        }

        public int SumTwoNumbers(int a,int b)
        {
            return a - b;
        }

    }
    struct Employee
    {
        public int id;
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User Defined Data Types
            //Built DataTypes (short - int - long - string - boolen - char)
            //User Defined DataTypes
            // Class 
            // Struct

            // Enum
            // Interface
            // Delegate
            // Record

            //Student s1 = new Student();
            //Student s2 = new Student();

            //Employee e1 = new Employee(); 
            #endregion
            #region Value Types Vs Refrence Types
            // Value Types Vs Referance Types

            // Value Types  =>  short ,int ,long ,char ,struct ,Enum ,bool

            //int x = 20;
            //long y = 70;
            //Employee e1 = new Employee();

            // Ref Types  => class ,string , interface , Array 
            //Student s1 = new Student(); //object

            // new => new keyword in refrence type
            // allocate memory
            // define default values for class members
            // return allocated address to stack


            // Employee e1 = new Employee();  //instance
            // new => new keyword in value type
            // define default values for struct

            //int num = new int();
            //int num = 0; 

            #endregion
            #region Functions
            //Student s = new Student();
            //s.PrintPattern(); //calling

            //int result = s.SumTwoNumbers(5, 6);
            //Console.WriteLine(result);

            //s.PrintPattern(); //calling 
            #endregion
            #region Debugging
            //Student s = new Student();
            //Console.WriteLine(s.SumTwoNumbers(6,5));
            //s.PrintPattern();
            //s.PrintPattern(); 
            #endregion
            #region One-Dim Array
            //string[] names = new string[5];
            //string[] names = new string[] { "ahmed", "mohamed" };
            //string[] names = { "ahmed", "mohamed" };


            //Console.WriteLine("Enter Number grads");
            //int numberOfGrads = int.Parse(Console.ReadLine());


            //int[] arr = new int[numberOfGrads];
            //arr[0] = 50;
            //arr[1] = 60;
            //arr[2] = 90;
            //arr[3] = 150;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //  Console.WriteLine($"Enter Item of {i+1}");
            //  arr[i] =int.Parse(Console.ReadLine());
            //}

            //Student student = new Student();
            //student.PrintPattern();

            //for(int i = 0; i < arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Console.WriteLine(arr[2]);

            #endregion
        }
    }
}
