using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessorLib
{
    public static class CsvProcessor
    {
        public static string FileName { get; set; }

        public static string[] ReadFile()
        {
            if (!string.IsNullOrWhiteSpace(FileName))
            {
                using (var reader = new StreamReader(FileName))
                {
                    List<string> fileLines = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        fileLines.Add(line);
                    }

                    return fileLines.ToArray();
                }
            }
            else
            {
                throw new FileNotFoundException("FileName is empty. Please provide a file name by using the FileName() function");
            }
        }

        public static void AddLine(string line)
        {
            if (!string.IsNullOrWhiteSpace(FileName))
            {
                using (var writer = new StreamWriter(FileName, true))
                {
                    writer.WriteLine(line);
                    writer.Flush();
                }
            }
            else
            {
                throw new FileNotFoundException("FileName is empty. Please provide a file name by using the FileName() function");
            }
        }

    }
}
