// Week 2: Individual: Loops
// Marcia L. Allen
// November 7, 2016
// Write a for loop which displays every third number beginning with ten and continuing 
// to 100, inclusive of 10 and 100. Next write a while loop which displays every third 
// number beginning with ten and continuing to 100, inclusive of 10 and 100. Next write
// a do-while loop which displays every third number beginning with ten and continuing 
// to 100, inclusive of 10 and 100.  This program may be a console application or a
// Windows Forms application, and note that only one program should be submitted - 
// thus all three loops will be in the one program. No matter whether you choose to develop a 
// Windows Forms application or a console application, be sure the interface 
// is professional looking and intuitive to use for the novice end user. Include 
// identifying information in the form of block comments at the top of each class 
// in the project (programmer name, date, program description). Include adequate
// comments throughout the program, utilize meaningful names for controls, 
// variables, fields, and forms. Include white space for readability purposes 
// in the code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class LoopsProgram
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("\n\tWELCOME TO THE LOOPS PROGRAM");
            Console.WriteLine("\n\t**********************************");

            // Call forLoop Method which displays every third number beginning 
            // with ten and continuing to 100, inclusive of 10 and 100.
            Console.WriteLine("\n\tFor Loop Method \n");
            forLoop();
            Console.WriteLine("\n\t**********************************");
            Console.Write("\n ");

            // Call whileLoop Method which displays every third number beginning 
            // with ten and continuing to 100, inclusive of 10 and 100.
            Console.WriteLine("\n\tWhile Loop Method \n");
            whileLoop();
            Console.WriteLine("\n\t***********************************");
            Console.Write("\n ");

            // Call doWhileLoop Method which displays every third number beginning
            // with ten and continuing to 100, inclusive of 10 and 100.
            Console.WriteLine("\n\tDo While Loop Method \n");
            doWhileLoop();
            Console.WriteLine("\n\t***********************************");
            Console.Write("\n ");

            // Display GoodBye Message
            Console.WriteLine("\n\tHOPE YOU ENJOYED LOOPS!");

            Console.ReadLine();

        }
        // A for loop which displays every third number beginning with ten and continuing 
        // to 100, inclusive of 10 and 100.
        public static void forLoop()
        {
            int startLoop = 1;
            int stopLoop = 100;

            for (; startLoop <= stopLoop; startLoop += 3)
            {
                Console.Write("\n\t ");
                Console.WriteLine(startLoop);
            }
        }
        // A while loop which displays every third number beginning with ten and
        // continuing to 100, inclusive of 10 and 100.
        public static void whileLoop() 
        {
            int startLoop = 10;
            int stopLoop = 100;

            while (startLoop <= stopLoop)
            {
                Console.Write("\n\t ");
                Console.WriteLine(startLoop);

                startLoop = startLoop + 3;
            }
        }
        // A do-while loop which displays every third number beginning with ten and continuing 
        // to 100, inclusive of 10 and 100.
        public static void doWhileLoop()
        {

            int startLoop = 10;

            do
            {
                Console.Write("\n\t ");
                Console.WriteLine(startLoop);

                startLoop = startLoop + 3;

            } while (startLoop <= 100);

        }
    }
}
