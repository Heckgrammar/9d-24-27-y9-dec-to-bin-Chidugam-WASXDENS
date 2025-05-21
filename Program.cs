using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            Console.WriteLine("Write down a number");
            string numb = Console.ReadLine(); 
            int? ProperNumber = Convert.ToInt32(numb);
            Console.WriteLine(ProperNumber);
            Console.WriteLine("wait");
            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE
            NumberConversion(in);

            
        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static void NumberConversion(int number, int numberbase)
        {
            int count = 0;
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            while (UserNumber != 1 || UserNumber != 0)
            {
                int result = UserNumber % 2;
                count += 1;
            }
            int[] binary = 
        }
    }
}
