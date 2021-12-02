using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics // Note: actual namespace depends on the project name.
{
    public class Program
    {
        ///*
        public static int Main(string[] args)
        {
            printHeader();

            string file = "";
            string column = "";

            //primary loop, continue with the program until the user prompts the program to quit
            while (file != "quit" && column != "quit")
            {
                //clear the contents of these variables
                file = "";
                column = "";

                Console.WriteLine("enter a filename");
                file = Console.ReadLine();
                if (file == "quit") break;

                Console.WriteLine("enter a column name");
                column = Console.ReadLine();
                if (column == "quit") break;


                //perform statistic analysis and output to the user
                Vector data = loadFile(file, column);

            }

            Console.WriteLine("Thank you for using the Statistics program!");
            return 0;
        }
        //*/

        public static void printHeader()
        {
            Console.WriteLine("--------Welcome to Statistics in c#------");
            Console.WriteLine("--------Written by Jordan Bottrell ------");
            Console.WriteLine("----------------12/1/2021----------------");
        }

        //returns the data in the column of the indicate file in the form of a Vector object
        static Vector loadFile(string filename, string column)
        {
            //open the file stream
            Vector v = new Vector();
            return v;
            //load the data into the vector

            //close the file stream

            //return the vector

        }
    }
}