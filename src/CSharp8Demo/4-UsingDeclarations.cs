using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharp8Demo
{
    public static class UsingDeclarationsDemo
    {
        public static int ConvertFiles()
        {
            int counter = 0;

            //// traditional way of using "using" keyword
            //using (var inputFile = new StreamReader(@"TestFile.txt"))
            //{
            //    using (var outputFile = new StreamWriter(@"OutputFile.txt"))
            //    {
            //        string line;
            //        while ((line = inputFile.ReadLine()) != null)
            //        {
            //            outputFile.WriteLine(line);
            //            counter++;
            //        }
            //    }
            //}

            //Above same code can be written now using "using declaration"
            using var inputFile = new StreamReader(@"TestFile.txt");    // the using statement will get terminated and dispose method will get properly called 
            using var outputFile = new StreamWriter(@"OutputFile.txt"); // when these variables will go out of scope

            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                counter++;
            }

            return counter;
        }
    }
}
