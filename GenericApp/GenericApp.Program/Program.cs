using GenericApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GenericApp.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileType;

            /// <summary> 
            /// Sample usage of Regular Expressions
            /// </summary>

            var RegexSamples = new GenericApp.Common.RegexSamples();

            string[] names = { "123A.TXT", "12345B.TXT", "badone.xyz", "12345678A.TXT", "12B.TXT", "123.txt" };
            foreach (string name in names)
            {

                RegexSamples.FileName = name;

                fileType = RegexSamples.ParseType();

                // If length of filetype is Zero, then the filename did not match the pattern.
                if (fileType.Length != 0)
                {
                    Console.WriteLine("Type: {0} Filename: {1}", fileType, name);
                }
                else
                {
                    // Error!  file does not match the pattern
                    Console.WriteLine("File does not match pattern: {0} ", name);
                }
            }


        }
    }
}
