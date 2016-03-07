using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-    File Read Write
//-    Read from a CSV file
//-    Each line should be its own list of strings
//-    Entire file should be a list of strings
//-    Search file for a specific keyword and then print out the line where the keyword resides

namespace CSVeditor
{
    public class FileReader
    {
        public static List<List<string>> ReadFromFile(string filename)
        {
            List<List<string>> subList = new List<List<string>>();

            using (StreamReader streamreader = new StreamReader(filename))

                while (!streamreader.EndOfStream)
                {
                    string str = streamreader.ReadLine();
                    string[] parseStrings = str.Split(',');
                    List<string> parsedList = parseStrings.ToList();
                    subList.Add(parsedList);
                }
            return subList;
        }

    }
}
