using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "log.txt";
        string logMessage = "This is my stream writer logging details";

        // Create a new StreamWriter instance to write to the log file
        using (var sw = File.AppendText(filePath))
        {
            // Append the log message along with the current date and time
            sw.WriteLine(logMessage + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        // Create a new StreamReader instance to read from the log file
        using (var sr = new StreamReader(filePath))
        {
            string line;

            // Read and display each line of the log file in the console
            while ((line = sr.ReadLine() ?? String.Empty) != String.Empty)
            {
                Console.WriteLine(line);
            }
        }

        Console.ReadLine();
    }
}
