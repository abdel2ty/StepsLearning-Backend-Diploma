using System;

namespace lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write
            Console.WriteLine("Hello, World!");

            // Read
            Console.ReadLine();

            // Mini Program
            Console.WriteLine("Enter your name:");
            Console.ReadLine();

            // Variables => DataType variableName = value;
            string name; //Declare a variable
            name = "Abdelaty"; //Assign a value to the variable
            string address = "Cairo"; //Declare and assign a value to the variable
            int age = 18; //Declare and assign a value to the variable

            // Data Types
            // Storage
            bool isTrue; //1 byte
            short a; //2 bytes
            char ch; //2 bytes
            int b; //4 bytes
            float c; //4 bytes
            long d; //8 bytes
            double e; //8 bytes
            decimal f; //16 bytes

            float k = 1.5f; //Single precision floating point
            double g = 1.5; //Double precision floating point
            decimal i = 1.5m; //Decimal type for financial calculations

            // Casting
            float h = (float)1.5; //Explicit casting from double to float
            decimal j = (decimal)1.5; //Explicit casting from double to decimal

            // Validation
            int x = "Muhammed"; // This will cause a compile-time error because "Muhammed" is not an integer
            string y = 123; // This will also cause a compile-time error because 123 is not a string

            // Operations
            int u = 10;
            int v = 20;
            int sum = u + v; // Addition
            int difference = u - v; // Subtraction
            string st1 = "Hello";
            string st2 = "World";
            string concatenated = st1 + " " + st2; // String concatenation

            // Mini Program
            Console.WriteLine("Enter your Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName); // String concatenation
            Console.WriteLine("Hello {userName}", userName); // String formatting
            Console.WriteLine($"Hello {userName}!"); // String interpolation

            // Implicit casting: converting a smaller data type to a larger one
            int implicitInt = 10; // Implicitly typed variable
            double implicitDouble = implicitInt; // Implicit casting from int to double

            // Explicit casting: converting a larger data type to a smaller one
            double explicitDouble = 10.5;
            int explicitInt = (int)explicitDouble; // Explicit casting from double to int

            // Convert String into any Data Type
            Console.WriteLine("Enter your Age:");
            int userAge = int.Parse(Console.ReadLine()); // Parsing string input to integer

            Console.WriteLine("Enter your Height:");
            decimal userHeight = decimal.Parse(Console.ReadLine()); // Parsing string input to decimal

            Console.WriteLine($"Your Age is: {userAge} and your Height is: {userHeight}");

            // Convert any Data Type into String
            int number = 123;
            string numberAsString = number.ToString(); // Converting integer to string
            decimal decimalNumber = 123.45m;
            string decimalAsString = decimalNumber.ToString(); // Converting decimal to string

            // Operators
            // 1- Arithmetic Operators (+ - * / %)
            // 1.1 - Binary operators: require two operands
            // 1.2 - Unary operators: require one operand
            // 1.2.1 - Prefix: ++x, --x
            // 1.2.2 - Postfix: x++, x--

            // 2- Assignment Operators (= += -= *= /= %=)

            // 3- Comparison Operators (== != > < >= <=)

            // 4- Logical Operators (&& || !)

            // 5- Bitwise Operators (& | ^ ~ << >>)

            // 6- Ternary Operator (condition ? trueValue : falseValue) 

            // Control Statements
            // 1- Conditional Statements
            // 1.1 - If Statement
            int number1 = 10;
            if (number1 > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number1 < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }

            // 1.2 - Switch Statement
            int day = 3;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // 2- Looping Statements
            // 2.1 - For Loop
            for (int forVar = 0; forVar < 5; forVar++)
            {
                Console.WriteLine($"Iteration {forVar}");
            }

            // 2.2 - While Loop
            int whileVar = 0;
            while (whileVar < 15)
            {
                Console.WriteLine($"Current number: {whileVar}");
                whileVar++;
            }

            // 2.3 - Do-While Loop
            int doWhileVar = 0;
            do
            {
                Console.WriteLine($"Current number: {doWhileVar}");
                doWhileVar++;
            } while (doWhileVar < 10);

            // 2.4 - Foreach Loop
            string[] foreachVar = { "Alice", "Bob", "Charlie" };
            foreach (string var in foreachVar)
            {
                Console.WriteLine($"Hello, {var}!");
            }


            // Error Types
            // 1- Syntax Error: Occurs when the code does not conform to the language syntax rules.
            // 2- Runtime Error: Occurs during program execution, such as division by zero or null reference.
            // 3- Logical Error: Occurs when the code runs without crashing but produces incorrect results.
            // 4- Warning: A warning indicates a potential issue in the code that may not prevent it from running but could lead to unexpected behavior.
            // 5- Exception: An exception is an error that occurs during program execution, which can be caught and handled using try-catch blocks.
            // 6- Null Reference Exception: Occurs when trying to access a member on a null object reference.
            // 7- Overflow Exception: Occurs when an arithmetic operation exceeds the limits of the data type.
            // 8- etc..
        }
    }
}
