using System;
using System.Text;

namespace CSV_TextFile_Read_Write
{
    class CSVTextFileCreator
    {
        public static void Main()
        {
            try
            {
                // Using StreamWriter to create and write to a file
                using (StreamWriter fwriter = new StreamWriter("CSVFileName.csv", true)) //true opens the file in append mode 
                {
                    fwriter.WriteLine("Text to be written to the file "); // write the header text to file
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"An error occurred: {Ex.Message}");
            }
        }//end of main()
    }//end of class
}//end of namespace

