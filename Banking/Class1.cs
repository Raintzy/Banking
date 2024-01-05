using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{ 

    class Class1
    {

        public string [] userinfo = new string [4];

        public void getUserinfo()
        {
            string filePath = "C:\\Users\\oscar\\Documents\\Example.txt";
            string separator = ""; // Change this to your desired separator
            int i = 0;                       // Read the file and process its content
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        // Read a line from the file
                        string line = reader.ReadLine();

                        // Split the line based on the separator
                        string[] values = line.Split(separator);
                        //   // Process each value
                        foreach (var value in values)
                        {
                            userinfo[i] = value.Split(" ")[1];
                            i++;// Print values to console (you can modify this based on your requirements)
                        }

                        // //   Console.WriteLine(values[i]);
                        // Console.WriteLine();

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
