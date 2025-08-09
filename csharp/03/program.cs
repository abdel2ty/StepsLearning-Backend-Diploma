using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Student
    {
        public int id;
        public string name;
        public int age;

        // Functions (methods)
        // ---> one functionality
        // ---> name of the function
        // ---> input and output
        // ---> calling the function
        public void PrintPattern()
        {
            Console.WriteLine("**********");
            Console.WriteLine("** Hello **");
            Console.WriteLine("**********");
        }
        public int SumTwoNumbers(int a, int b)
        {
            return a + b;
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
            // User Defined Data Types ( Enum - Struct - Class - Interface - Delegate - Record )

            // Object from Class Student
            Student student1 = new Student();
            Student student2 = new Student();

            // Object from Struct Employee
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            // Value Types: Struct, Enum, Primitive Types (int, float, etc.) --> stored in the stack.
            // Reference Types: Class, Interface, Delegate, Record, String, Array --> stored in the heap

            // What does 'new' keyword do?
            // 1- allocates memory for the object in the heap.
            // 2- define default values for class members.
            // 3- returns allocation address to the stack.

            // Calling a method from the Student class
            student1.PrintPattern();
            student1.SumTwoNumbers(10, 20);

            // Array -> A collection of elements of the same type, stored in contiguous memory locations.
            int[] arr = new int[5]; // Array of integers with 5 elements
            arr[0] = 10; // [10, 0, 0, 0, 0]
            arr[2] = 20; // [10, 0, 20, 0, 0]
            arr[4] = 30; // [10, 0, 20, 0, 30]

            string[] names1 = new string[3]; // Array of strings with 3 elements
            string[] names2 = new string[] { "Ali", "Muhammed", "Hassan" }; // Array of strings
            string[] names3 = { "Ali", "Muhammed", "Hassan" }; // Array of strings (alternative syntax)
        }
    }
}
