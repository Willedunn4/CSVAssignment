using CSVAssignment;

class Program
{
    static void Main(string[] args)
    {
        // List of file readers
        var readers = new List<IFileReader>
        {
            new CSVFileReader(),
            new PipeFileReader()
        };

        // List of files to be processed (assuming they are in the same directory as the executable)
        var fileNames = new List<string>
        {
            "SampleCSV.csv",
            "SamplePipe.txt"
        };

        // Print the contents of input files
        Console.WriteLine("Contents of SampleCSV.csv:");
        Console.WriteLine(string.Join(Environment.NewLine, File.ReadAllLines("SampleCSV.csv")));
        Console.WriteLine();

        Console.WriteLine("Contents of SamplePipe.txt:");
        Console.WriteLine(string.Join(Environment.NewLine, File.ReadAllLines("SamplePipe.txt")));
        Console.WriteLine();

        // Create an engine instance and process files
        var engine = new FileProcessingEngine(readers);
        var processedData = engine.ProcessFiles(fileNames);

        // Print the processed data
        Console.WriteLine("Processed Data:");
        Console.WriteLine(string.Join(Environment.NewLine, processedData.Select(row => string.Join(",", row))));
        Console.WriteLine();

        Console.WriteLine("Files processed and output generated.");
    }
}