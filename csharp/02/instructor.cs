using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            #region Variables
            //Variables    => Datatype variableName ;
            //string txt; //Declare
            //txt = "ahmed"; //assign
            //int num; 
            #endregion
            #region Datatypes
            //DataTypes
            //// Storage
            //short y;  //2byte
            //int x;    //4 byte
            //long l;   //8 byte

            ////float f = 1.6f;             //4byte
            //float f = (float)1.6;
            //double d = 1.5;               //8byte
            ////decimal k = 1.7m;
            //decimal k = (decimal)1.7;     //16byte


            //string txt2 = " ";
            //char c = 's';
            //bool b = true;

            //// Validation
            //int p = "Ahmed";

            //// Operation
            //string t1 = " ";
            //string t2 = " "; 
            #endregion
            #region Casting
            //Casing
            //implicit Casting small => large
            //int x = 20;
            //long l = x;

            //explicit Casing large => small
            //long l = long.MaxValue;
            //int x = (int)l;
            //Console.WriteLine(x);
            /*-5 -4 -3 -2 -1 0 1 2 3 4 5 */
            #endregion
            #region Read&Write
            // Write 
            //Console.WriteLine("Enter Your Name");
            //Console.ReadLine();

            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);
            //Console.WriteLine("Hello " + name);      //String Concatunation
            //Console.WriteLine("Hello {0} ", name);     //String Format
            //Console.WriteLine($"Hello   {name}");      //String Interpolition

            #endregion
            #region Parse & to String
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age");
            //int age =int.Parse(Console.ReadLine());

            //Parse
            //string from screen to any datatype by parse
            //Console.WriteLine($"Your name is {name} and your age is {age}");

            //convert any datatype to string 
            //int => string
            //int x = 60;
            //Console.WriteLine(x.ToString()); 
            #endregion

            #region Operators
            /*
             *  1- Arthmatic Operators 
             *     Binary 
             *     +  * - /
             *     
             *     Unary
             *     Prefix    ++x
             *     Postfix   x++
             *     
             *   2- Assignment Operators
             *      =  += -= 
             *      x=8 ;
             *      x+=y       x=x+y
             *      
             *   3- Comparsion Operators 
             *      == != > <  >=  <=
             *   
             *   4- Logical Operators 
             *      &&  ||  
             *      
             *   5- Bitwise Operator 
             *   6- Ternary Operator
             */

            #endregion
            #region Conditional Statment
            // Conditional Statment 

            //int x = 2;
            //if(x > 0)
            //{
            //    Console.WriteLine("Positive Number");
            //}

            //int x = 2;
            //if (x > 0)
            //{
            //    Console.WriteLine("Positive Number");
            //}else
            //{
            //    Console.WriteLine("Negative Number");
            //}

            //Console.WriteLine("Enter Your Level");
            //int x =int.Parse(Console.ReadLine());

            //if (x == 1 )
            //{
            //    Console.WriteLine(" your salary is 1000");
            //}
            //else if(x == 2 ) 
            //{
            //    Console.WriteLine(" your salary is 2000");
            //}
            //else
            //{
            //    Console.WriteLine(" Not valied");
            //}

            //Console.WriteLine("Enter Your Level");
            //int level = int.Parse(Console.ReadLine());

            //switch (level)
            //{
            //    case 1:
            //        Console.WriteLine(" your salary is 1000");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine(" your salary is 2000");
            //        break;
            //    default:
            //        Console.WriteLine("Not valied");
            //        break;
            //} 
            #endregion
            #region Loop Statment
            // Loop Statment
            //for(int i = 0; i < 10;i++)
            //{
            //    Console.WriteLine($"{i+1} - Test");
            //}

            //int x = 0;
            //while(x<10);
            //{
            //    Console.WriteLine("Test");
            //    x++;
            //}

            //int y = 0;
            //do
            //{
            //    Console.WriteLine("Test");
            //    y++;
            //}
            //while (y<10);

            //Foreach 
            #endregion
            #region Error Types
            // Syntax
            //int x = 0;
            //int y = 20;
            //Console.WriteLine($"y = {y}");
            // Runtime
            // Overflow 
            // NullRef
            // Logical  =>Unit Test
            // *
            // Warning 
            #endregion 
        }
    }
}
