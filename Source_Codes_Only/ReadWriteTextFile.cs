
// code to create a text file, write some data to it and read back the data 


using System;
using System.Text;

namespace FileOperations
{
    class FileReadWrite
    {
        public static void Main()
        {
            string filename = "MyTextFile.txt";

            string[] TexttoWrite = { "first line", 
                                     "second line",
                                     "third line " };

            try
            {
                // Using StreamWriter to create and write to a file
                using (StreamWriter fwriter = new StreamWriter(filename, true)) //true opens the file in append mode 
                {
                    foreach (string line in TexttoWrite)
                    {
                        fwriter.WriteLine(line);
                    }
                }
            }

            catch(Exception Ex)
            {
                Console.WriteLine($"An error occurred: {Ex.Message}");
            }


            // Using StreamReader to read line by line 
            using (StreamReader freader = new StreamReader(filename))
            {
                string line;
                while((line = freader.ReadLine()) != null )
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
    
}