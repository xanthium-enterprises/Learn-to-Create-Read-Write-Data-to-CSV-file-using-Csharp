
// Writes the data present in a 2D array  to a CSV text file on the disk 
// www.xanthium.in

using System;
using System.Text;


namespace CSV_TextFile_Read_Write
{
    class WriteCSVDataToFile
    {
        public static void Main()
        {
            //CSVfile creation parameters
            string SeperatorCharacter = ",";                // Comma Seperated file
            string CSVFileName        = "CSVTextFile.csv";  // Name of the file to be created

            string[] CSVHeaderTextArray = { "No", "Name", "Age", "Address" }; //CSV header data

            //CSV data to be stored
            string[,] CSVDataArray = {
                                   { "1", "Alice", "30", "123 Main St, New York" },
                                   { "2", "Bob", "25", "456 Elm St, Los Angeles" },
                                   { "3", "Charlie", "35", "789 Oak St, Chicago" },
                                   { "4", "David", "40", "321 Pine St, Houston"  },
                                   { "5", "Eve", "28", "654 Maple St, Seattle" }
                                };

            string CSVHeaderText = string.Join(SeperatorCharacter, CSVHeaderTextArray); // join the header text with seperator
                                  

           // Console.WriteLine(CSVHeaderText);
           // Console.WriteLine($"Number of Rows    {CSVDataArray.GetLength(0)} "); // Number of rows
           // Console.WriteLine($"Number of Columns {CSVDataArray.GetLength(1)} "); // Number of column


            //create and write data into the CSV file
            try
            {
                // Using StreamWriter to create and write to a file
                // using (StreamWriter fwriter = new StreamWriter(CSVFileName, true)) //true opens the file in append mode,true is optional
               
                using (StreamWriter fwriter = new StreamWriter(CSVFileName)) //file created fresh everytime ,previous data destroyed
                {
                    fwriter.WriteLine(CSVHeaderText); // write the header text to file

                    // Write 
                    for (int i = 0; i < CSVDataArray.GetLength(0); i++)
                    {
                        StringBuilder sb = new StringBuilder(); // create a string builder object 

                        for (int j = 0; j < CSVDataArray.GetLength(1); j++)
                        {
                            
                            sb.Append(CSVDataArray[i, j]); // append the character 
                            sb.Append(SeperatorCharacter); // append the comma 
                        }

                        sb.Length--;                          //remove the trailing comma,  1,Alice,30,123 Main St, New York,<- trailing comma
                        fwriter.WriteLine(sb.ToString());     //Write data to file

                        //Console.WriteLine(sb.ToString());
                    }//end of internal for loop
                }//end of using
            }//end of try

            catch (Exception Ex)
            {
                Console.WriteLine($"An error occurred: {Ex.Message}");
            }
        }


    }
}
