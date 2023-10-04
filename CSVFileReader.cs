using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVAssignment
{
    class CSVFileReader : IFileReader
    {
        public List<string[]> ReadFile(string filename)
        {
            try
            {
                var lines = File.ReadAllLines(filename);
                var data = new List<string[]>();

                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    data.Add(values);
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return null;
            }
        }
    }

}
