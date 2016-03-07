using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVeditor
{
    public class Search
    {
        public Search()
        {

        }
        public void FindWord(string wordToFind, string filename)
        {
            List<List<string>> tempList = FileReader.ReadFromFile("CSVeditor.txt");

            using (StreamReader sr = new StreamReader(filename))
            {

                string str = sr.ReadToEnd();

                {
                    for (int i = 0; i < tempList.Count; i++)
                    {
                        List<string> forrealTempList = tempList[i];
                        for (int j = 0; j < forrealTempList.Count; j++)
                        {
                            if (forrealTempList[j].Contains(wordToFind))
                            {
                                Console.WriteLine(filename + " contains '" + wordToFind + "' on line " + (i + 1));
                            }
                        }
                    }
                    if (!str.Contains(wordToFind))
                    {
                        Console.WriteLine("Your word is not in the file.");
                    }
                }
            }
        }
    }
}
