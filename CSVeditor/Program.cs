using System;
using System.Collections.Generic;
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
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> mainListOfLists = new List<List<string>>();
            Data data = new Data(mainListOfLists);
            List<string> list1 = data.CreateNewList();
            List<string> list2 = data.CreateNewList();
            list1.Add("nick");
            list1.Add("26");
            list2.Add("Bob");
            list2.Add("32");
            mainListOfLists.Add(list1);
            mainListOfLists.Add(list2);
            data.WriteMainListToFile(mainListOfLists);
            FileWriter.WriteToFile("CSVeditor.txt", mainListOfLists);
            FileReader.ReadFromFile("CSVeditor.txt");
            Search search = new Search();
            search.FindWord("32", "CSVeditor.txt");
            Console.ReadLine();
        }
    }
}
