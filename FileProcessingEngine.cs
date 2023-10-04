using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVAssignment
{
    class FileProcessingEngine
    {
        private List<IFileReader> readers;

        public FileProcessingEngine(List<IFileReader> readers)
        {
            this.readers = readers;
        }

        public List<string[]> ProcessFiles(List<string> fileNames)
        {
            var processedData = new List<string[]>();

            foreach (var fileName in fileNames)
            {
                foreach (var reader in readers)
                {
                    var data = reader.ReadFile(fileName);
                    if (data != null)
                    {
                        processedData.AddRange(data);
                        break; // Exit the loop once a reader successfully processes the file
                    }
                }
            }

            return processedData;
        }
    }
}
