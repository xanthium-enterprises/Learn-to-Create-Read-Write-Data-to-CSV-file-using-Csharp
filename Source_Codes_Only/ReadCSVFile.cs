
// reads from a CSV file 
// www.xanthium.in

using System;
using System.Reflection.PortableExecutable;
using System.Text;


namespace CSV_TextFile_Read_Write
{
    class ReadCSVFilefromDisk
    {
        public static void Main()
        {
           
            string CSVFileName = "CSVTextFile.csv";  // Name of the file to be created

            //Read data from CSV file
            try
            {
                using (StreamReader CSVReader = new StreamReader(CSVFileName))
                {
                    string line;
                    while ((line = CSVReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                        string[] individualchar = line.Split(",");
                        foreach(string c in individualchar)
                        {
                            Console.Write($"{c} ");
                        }

                        Console.WriteLine();
                    }
                }
            }
            

            catch (Exception Ex)
            {
                Console.WriteLine($"An error occurred: {Ex.Message}");
            }
        }


    }
}
